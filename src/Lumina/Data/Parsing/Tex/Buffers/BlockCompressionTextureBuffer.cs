using System;
using BCnEncoder.Decoder;
using BCnEncoder.Shared;
using CommunityToolkit.HighPerformance;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in either BC1(DXT1), BC2(DXT3), BC3(DXT5), BC5(ATI2), or BC7 texture format.
    /// </summary>
    public class BlockCompressionTextureBuffer : TextureBuffer
    {
        private static readonly BcDecoder _decoder = new();

        private int _version;

        private BlockCompressionTextureBuffer( int version, TexFile.Attribute attribute, int width, int height,
            int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer,
                tb => ( (BlockCompressionTextureBuffer)tb )._version = version )
        {
            _version = version;
        }

        /// <inheritdoc />
        public BlockCompressionTextureBuffer( TexFile.TextureFormat format, TexFile.Attribute attribute, int width,
            int height, int depth,
            int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer, tb => {
                ( (BlockCompressionTextureBuffer)tb )._version = format switch
                {
                    TexFile.TextureFormat.BC1 => 1,
                    TexFile.TextureFormat.BC2 => 2,
                    TexFile.TextureFormat.BC3 => 3,
                    TexFile.TextureFormat.BC5 => 5,
                    TexFile.TextureFormat.BC7 => 7,
                    _ => throw new ArgumentException( null, nameof( format ) ),
                };
            } )
        {
            _version = format switch
            {
                TexFile.TextureFormat.BC1 => 1,
                TexFile.TextureFormat.BC2 => 2,
                TexFile.TextureFormat.BC3 => 3,
                TexFile.TextureFormat.BC5 => 5,
                TexFile.TextureFormat.BC7 => 7,
                _ => throw new ArgumentException( null, nameof( format ) ),
            };
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) =>
            CalculateNumBytesPerPlane( WidthOfMipmap( mipmapIndex ), HeightOfMipmap( mipmapIndex ) );

        /// <inheritdoc />
        protected override void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width,
            int height, int depth )
        {
            var format = _version switch
            {
                1 => CompressionFormat.Bc1,
                2 => CompressionFormat.Bc2,
                3 => CompressionFormat.Bc3,
                5 => CompressionFormat.Bc5,
                7 => CompressionFormat.Bc7,
                _ => throw new NotSupportedException( "Unknown block compression version." ),
            };

            // decoding 1 block at a time into one reused tile keeps this allocation free
            var cbBlock = _version == 1 ? 8 : 16;
            var cbPlane = CalculateNumBytesPerPlane( width, height );
            var blocksPerRow = Math.Max( 1, ( width + 3 ) / 4 );

            Span< ColorRgba32 > tile = stackalloc ColorRgba32[16];
            var tile2D = Span2D< ColorRgba32 >.DangerousCreate( ref tile[ 0 ], 4, 4, 0 );

            for( var i = 0; i < depth; i++ )
            {
                var plane = RawData.AsSpan( sourceOffset + cbPlane * i, cbPlane );
                var planeOffset = destOffset + i * width * height * 4;

                for( var by = 0; by < height; by += 4 )
                {
                    for( var bx = 0; bx < width; bx += 4 )
                    {
                        var block = ( by / 4 ) * blocksPerRow + bx / 4;
                        _decoder.DecodeBlock( plane.Slice( block * cbBlock, cbBlock ), format, tile2D );

                        var rows = Math.Min( 4, height - by );
                        var cols = Math.Min( 4, width - bx );
                        for( var py = 0; py < rows; py++ )
                        {
                            var dest = planeOffset + ( ( by + py ) * width + bx ) * 4;
                            for( var px = 0; px < cols; px++ )
                            {
                                var color = tile[ py * 4 + px ];
                                buffer[ dest + px * 4 + 0 ] = color.b;
                                buffer[ dest + px * 4 + 1 ] = color.g;
                                buffer[ dest + px * 4 + 2 ] = color.r;
                                buffer[ dest + px * 4 + 3 ] = color.a;
                            }
                        }
                    }
                }
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth,
            int[] mipmapAllocations, byte[] buffer )
            => new BlockCompressionTextureBuffer( _version, attribute, width, height, depth, mipmapAllocations,
                buffer );

        private int CalculateNumBytesPerPlane( int w, int h ) =>
            Math.Max( 1, ( ( w + 3 ) / 4 ) ) *
            Math.Max( 1, ( ( h + 3 ) / 4 ) ) *
            ( _version == 1 ? 8 : 16 );
    }
}
