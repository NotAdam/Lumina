using System;
using System.Linq;
using System.Threading.Tasks;
using Lumina.Data.Parsing.Tex.SquishInternal;

namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Exported methods from Squish, for de/compressing DXT1/3/5 (BC1/2/3) image buffers.
/// </summary>
public static class Squish
{
    /// <summary>
    /// Calculate the required number of bytes for compressing using given configuration.
    /// </summary>
    /// <param name="width">The width in pixels of the image to compress.</param>
    /// <param name="height">The height in pixels of the image to compress.</param>
    /// <param name="flags">The flags specifying the compression method.</param>
    /// <returns>The number of required bytes.</returns>
    public static int GetStorageRequirements( int width, int height, SquishOptions flags )
        => GetStorageRequirements( width, height, new SquishOptions2( flags ) );

    /// <summary>
    /// Calculate the required number of bytes for compressing using given configuration.
    /// </summary>
    /// <param name="width">The width in pixels of the image to compress.</param>
    /// <param name="height">The height in pixels of the image to compress.</param>
    /// <param name="options">The options specifying the compression method.</param>
    /// <returns>The number of required bytes.</returns>
    public static int GetStorageRequirements( int width, int height, SquishOptions2 options )
    {
        var blockCount = ( width + 3 ) / 4 * ( ( height + 3 ) / 4 );
        return blockCount * options.BytesPerBlock;
    }

    #region On ReadOnlySpan for inputs and Span for outputs

    /// <summary>
    /// Compress a 4x4 block of pixels.
    /// </summary>
    /// <param name="pixels">Input pixel values of the 4x4 source pixels.</param>
    /// <param name="block">The output compressed block.</param>
    /// <param name="options">Options to use with compression procedure.</param>
    /// <typeparam name="TPixel">Type of underlying buffer for pixels. It must be at least 16 bytes.</typeparam>
    /// <typeparam name="TBlock">Type of underlying buffer for the block. It must be at least 64 bytes.</typeparam>
    public static void CompressBlock< TPixel, TBlock >(
        ReadOnlySpan< TPixel > pixels,
        Span< TBlock > block,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged =>
        CompressBlockMasked( pixels, 0xFFFF, block, options );

    /// <summary>
    /// Compress a 4x4 block of pixels.
    /// </summary>
    /// <param name="pixels">Input pixel values of the 4x4 source pixels.</param>
    /// <param name="mask">The valid pixel mask.</param>
    /// <param name="block">The output compressed block.</param>
    /// <param name="options">Options to use with compression procedure.</param>
    /// <typeparam name="TPixel">Type of underlying buffer for pixels. It must be at least 16 bytes.</typeparam>
    /// <typeparam name="TBlock">Type of underlying buffer for the block. It must be at least 64 bytes.</typeparam>
    public static unsafe void CompressBlockMasked< TPixel, TBlock >(
        ReadOnlySpan< TPixel > pixels,
        int mask,
        Span< TBlock > block,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged
    {
        fixed( void* pPixels = pixels )
        fixed( void* pBlock = block )
        {
            var pixelsBytes = new Span< byte >( pPixels, pixels.Length * sizeof( TPixel ) );
            var blockBytes = new Span< byte >( pBlock, block.Length * sizeof( TBlock ) );

            // initialise the block output
            var compresser = new BlockCompresser( options );

            // map channel layout
            compresser.RemapChannelsFromMasked( pixelsBytes, mask );

            // compress it into the output
            compresser.CompressMaskedInto( blockBytes );
        }
    }

    /// <summary>
    /// Compress a whole image.
    /// </summary>
    /// <param name="pixels">Input pixel values of the image.</param>
    /// <param name="stride">Stride of the source image, in number of <see cref="TPixel"/>, rather than number of bytes.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="blocks">Output buffer for the compression.</param>
    /// <param name="options">Options to use with compression procedure.</param>
    /// <typeparam name="TPixel">Type of underlying buffer for pixels.</typeparam>
    /// <typeparam name="TBlock">Type of underlying buffer for the block.</typeparam>
    public static unsafe void CompressImage< TPixel, TBlock >(
        ReadOnlySpan< TPixel > pixels,
        int stride,
        int width,
        int height,
        Span< TBlock > blocks,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged
    {
        fixed( void* pPixels = pixels )
        fixed( void* pBlocks = blocks )
        {
            var pixelsBytes = new Span< byte >( pPixels, pixels.Length * sizeof( TPixel ) );
            var blocksBytes = new Span< byte >( pBlocks, blocks.Length * sizeof( TBlock ) );

            // initialise the block output
            var compresser = new BlockCompresser( options );

            // loop over blocks
            for( var y = 0; y < height; y += 4 )
            {
                for( var x = 0; x < width; x += 4 )
                {
                    options.CancellationToken.ThrowIfCancellationRequested();

                    // map channel layout
                    compresser.RemapChannelsFrom( pixelsBytes, x, y, stride, width, height );

                    // compress it into the output
                    compresser.CompressMaskedInto( blocksBytes );

                    // advance
                    blocksBytes = blocksBytes[ options.BytesPerBlock.. ];
                }
            }
        }
    }

    /// <summary>
    /// Compress a whole image, using multiple threads by default.
    /// </summary>
    /// <param name="pixelsMemory">Input pixel values of the image.</param>
    /// <param name="stride">Stride of the source image, in number of <see cref="TPixel"/>, rather than number of bytes.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="blocksMemory">Output buffer for the compression.</param>
    /// <param name="options">Options to use with compression procedure.</param>
    /// <typeparam name="TPixel">Type of underlying buffer for pixels.</typeparam>
    /// <typeparam name="TBlock">Type of underlying buffer for the block.</typeparam>
    public static unsafe Task CompressImageAsync< TPixel, TBlock >(
        ReadOnlyMemory< TPixel > pixelsMemory,
        int stride,
        int width,
        int height,
        Memory< TBlock > blocksMemory,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged
    {
        var horzBlockCount = ( width + 3 ) / 4;
        var vertBlockCount = ( height + 3 ) / 4;
        var totalBlockCount = horzBlockCount * vertBlockCount;
        var threads = Math.Min( options.Threads < 1 ? Environment.ProcessorCount : options.Threads, totalBlockCount );

        if( threads == 1 )
        {
            return Task.Run(
                () => CompressImage( pixelsMemory.Span, stride, width, height, blocksMemory.Span, options ) );
        }

        return Task.WhenAll(
            Enumerable.Range( 0, threads ).Select(
                i => Task.Run(
                    () => {
                        var compresser = new BlockCompresser( options );
                        var blockIndex = totalBlockCount * i / threads;
                        var blockIndexTo = totalBlockCount * ( i + 1 ) / threads;

                        fixed( void* pPixels = pixelsMemory.Span )
                        fixed( void* pBlocks = blocksMemory.Span )
                        {
                            var pixels = new Span< byte >( pPixels, pixelsMemory.Length * sizeof( TPixel ) );
                            var blocks = new Span< byte >( pBlocks, blocksMemory.Length * sizeof( TBlock ) );
                            blocks = blocks[ ( options.BytesPerBlock * blockIndex ).. ];

                            // loop over blocks
                            for( ; blockIndex < blockIndexTo; blockIndex++ )
                            {
                                var y = blockIndex / horzBlockCount * 4;
                                var x = blockIndex % horzBlockCount * 4;

                                options.CancellationToken.ThrowIfCancellationRequested();

                                // map channel layout
                                compresser.RemapChannelsFrom( pixels, x, y, stride, width, height );

                                // compress it into the output
                                compresser.CompressMaskedInto( blocks );

                                // advance
                                blocks = blocks[ options.BytesPerBlock.. ];
                            }
                        }
                    },
                    options.CancellationToken ) ) );
    }

    /// <summary>
    /// Decompress a 4x4 block of pixels.
    /// </summary>
    /// <param name="pixels">Storage for the 16 decompressed pixels.</param>
    /// <param name="block">The compressed DXT block.</param>
    /// <param name="options">Compression flags.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static unsafe void DecompressBlock< TPixel, TBlock >(
        Span< TPixel > pixels,
        ReadOnlySpan< TBlock > block,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged
    {
        var decompresser = new BlockDecompresser( options );
        fixed( void* pPixels = pixels )
        fixed( void* pBlock = block )
        {
            var pixelsBytes = new Span< byte >( pPixels, pixels.Length * sizeof( TPixel ) );
            var blockBytes = new Span< byte >( pBlock, block.Length * sizeof( TBlock ) );
            decompresser.DecompressFrom( blockBytes );
            decompresser.RemapChannelsInto( pixelsBytes );
        }
    }

    /// <summary>
    /// Decompress an image in memory.
    ///
    /// Note that an async variant of this method is not provided, because the operation is computationally light.
    /// </summary>
    /// <param name="pixels">Output pixel values of the image.</param>
    /// <param name="stride">Stride of the source image, in number of <see cref="TPixel"/>, rather than number of bytes.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="blocks">Input buffer for the decompression.</param>
    /// <param name="options">Options to use with decompression procedure.</param>
    /// <typeparam name="TPixel">Type of underlying buffer for pixels.</typeparam>
    /// <typeparam name="TBlock">Type of underlying buffer for the block.</typeparam>
    public static unsafe void DecompressImage< TPixel, TBlock >(
        Span< TPixel > pixels,
        int stride,
        int width,
        int height,
        ReadOnlySpan< TBlock > blocks,
        SquishOptions2 options )
        where TPixel : unmanaged
        where TBlock : unmanaged
    {
        fixed( void* pPixels = pixels )
        fixed( void* pBlocks = blocks )
        {
            var decompresser = new BlockDecompresser( options );
            var pixelsBytes = new Span< byte >( pPixels, pixels.Length * sizeof( TPixel ) );
            var blocksBytes = new Span< byte >( pBlocks, blocks.Length * sizeof( TBlock ) );
            var strideBytes = sizeof( TPixel ) * stride;

            // loop over blocks
            for( var y = 0; y < height; y += 4 )
            {
                for( var x = 0; x < width; x += 4 )
                {
                    // decompress the block
                    decompresser.DecompressFrom( blocksBytes );

                    // write the decompressed pixels to the correct image locations
                    decompresser.RemapChannelsInto( pixelsBytes, x, y, strideBytes, width, height );

                    // advance
                    blocksBytes = blocksBytes[ options.BytesPerBlock.. ];
                }
            }
        }
    }

    #endregion

    #region On byte arrays as inputs and return values, operating on BGRA (just in case someone was using these functions using Lumina as a dependency)

    /// <summary>
    /// Compress the given BGRA 4x4 pixels into a new byte array.
    /// </summary>
    /// <param name="bgra">4x4 input pixel values in BGRA pixel format.</param>
    /// <param name="flags">Flags to use for compression.</param>
    /// <returns></returns>
    public static byte[] CompressBlock( byte[] bgra, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var blocks = new byte[options.BytesPerBlock];
        CompressBlock< byte, byte >( bgra, blocks, options );
        return blocks;
    }

    /// <summary>
    /// Compress the given BGRA 4x4 pixels into a new byte array.
    /// </summary>
    /// <param name="bgra">4x4 input pixel values in BGRA pixel format.</param>
    /// <param name="mask">The valid pixel mask.</param>
    /// <param name="flags">Flags to use for compression.</param>
    /// <returns></returns>
    public static byte[] CompressBlockMasked( byte[] bgra, int mask, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var blocks = new byte[options.BytesPerBlock];
        CompressBlockMasked< byte, byte >( bgra, mask, blocks, options );
        return blocks;
    }

    /// <summary>
    /// Compress the given image in BGRA pixel format into a new byte array.
    /// </summary>
    /// <param name="bgra">Input pixel values in BGRA pixel format.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="flags">Compression flags.</param>
    /// <returns></returns>
    public static byte[] CompressImage( byte[] bgra, int width, int height, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var blocks = new byte[GetStorageRequirements( width, height, options )];
        CompressImage< byte, byte >( bgra, 4 * width, width, height, blocks, options );
        return blocks;
    }

    /// <summary>
    /// Decompress a 4x4 block of pixels into a new byte array of pixels in BGRA pixel format.
    /// </summary>
    /// <param name="block">The compressed DXT block.</param>
    /// <param name="blockOffset">Offset of data inside the block array.</param>
    /// <param name="flags">Compression flags.</param>
    public static byte[] DecompressBlock( byte[] block, int blockOffset, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var bgra = new byte[64];
        DecompressBlock< byte, byte >( bgra.AsSpan(), block.AsSpan( blockOffset ), options );
        return bgra;
    }

    /// <summary>
    /// Decompress a compressed image into a new byte array of pixels in BGRA pixel format.
    /// </summary>
    /// <param name="blocks">The compressed DXT blocks.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="flags">Compression flags.</param>
    public static byte[] DecompressImage( byte[] blocks, int width, int height, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var bgra = new byte[4 * width * height];
        DecompressImage< byte, byte >( bgra, 4 * width, width, height, blocks, options );
        return bgra;
    }

    /// <summary>
    /// Decompress a compressed image into a new byte array of pixels in BGRA pixel format.
    /// </summary>
    /// <param name="blocks">The compressed DXT blocks.</param>
    /// <param name="offset">Offset of data inside the block array.</param>
    /// <param name="width">Width of the input image.</param>
    /// <param name="height">Height of the input image.</param>
    /// <param name="flags">Compression flags.</param>
    public static byte[] DecompressImage( byte[] blocks, int offset, int width, int height, SquishOptions flags )
    {
        var options = new SquishOptions2( flags ) { ChannelOffsets = SquishOptions2.OffsetBgra };
        var bgra = new byte[4 * width * height];
        DecompressImage< byte, byte >( bgra, 4 * width, width, height, blocks.AsSpan( offset ), options );
        return bgra;
    }

    #endregion
}