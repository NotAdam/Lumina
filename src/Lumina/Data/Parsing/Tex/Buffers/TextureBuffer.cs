using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a texture in .tex file.
    /// </summary>
    public abstract class TextureBuffer
    {
        /// <summary>
        /// Indicates whether this texture is a cube map.
        /// </summary>
        public readonly bool IsDepthConstant;

        /// <summary>
        /// Width of this texture in pixels unit.
        /// </summary>
        public readonly int Width;

        /// <summary>
        /// Height of this texture in pixels unit.
        /// </summary>
        public readonly int Height;

        /// <summary>
        /// Depth of this texture.
        /// </summary>
        public readonly int Depth;

        /// <summary>
        /// Offsets to mipmaps in this texture.
        /// </summary>
        public readonly int[] MipmapAllocations;

        /// <summary>
        /// Raw data.
        /// </summary>
        public readonly byte[] RawData;

        /// <summary>
        /// Number of bytes in this texture.
        /// </summary>
        public readonly int NumBytes;

        /// <summary>
        /// Create a new instance of TextureBuffer.
        /// </summary>
        /// <param name="isDepthConstant">Specify whether the secondary mipmap and later get lesser number of depth.</param>
        /// <param name="width">Width of the primary mipmap.</param>
        /// <param name="height">Height of the primary mipmap.</param>
        /// <param name="depth">Depth of the primary mipmap.</param>
        /// <param name="mipmapAllocations">Number of bytes allocated for each mipmap.</param>
        /// <param name="buffer">Byte array containing multiple mipmaps, one right after another allocation.</param>
        protected TextureBuffer( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
        {
            IsDepthConstant = isDepthConstant;
            Width = width;
            Height = height;
            Depth = depth;

            // Test if there are sufficient room for every mipmap in the texture
            for( var i = 0; i < mipmapAllocations.Length; i++ )
            {
                if( mipmapAllocations[ i ] >= NumBytesOfMipmap( i ) )
                    continue;

                MipmapAllocations = new int[mipmapAllocations.Length];
                break;
            }

            if( MipmapAllocations == null )
            {
                // Sufficient; use provided params

                MipmapAllocations = mipmapAllocations;
                NumBytes = mipmapAllocations.Sum();
                RawData = buffer;
                if( RawData.Length < NumBytes )
                    throw new InvalidOperationException( "Buffer size mismatch" );
            }
            else
            {
                // Insufficient; create a new buffer

                var mipmapSizes = new int[MipmapAllocations.Length];
                for( var i = 0; i < MipmapAllocations.Length; i++ )
                {
                    mipmapSizes[ i ] = NumBytesOfMipmap( i );
                    MipmapAllocations[ i ] = ( mipmapSizes[ i ] + 3 ) / 4 * 4;
                }

                NumBytes = MipmapAllocations.Sum();
                RawData = new byte[NumBytes];

                for( int i = 0, srcOffset = 0, dstOffset = 0;
                    i < MipmapAllocations.Length;
                    srcOffset += MipmapAllocations[ i ], dstOffset += mipmapAllocations[ i ], i++ )
                    Buffer.BlockCopy( buffer, srcOffset, RawData, dstOffset, Math.Min( mipmapSizes[ i ], mipmapAllocations[ i ] ) );
            }
        }

        /// <summary>
        /// Get the width of specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int WidthOfMipmap( int mipmapIndex ) => Math.Max( 1, Width >> mipmapIndex );

        /// <summary>
        /// Get the height of specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int HeightOfMipmap( int mipmapIndex ) => Math.Max( 1, Height >> mipmapIndex );

        /// <summary>
        /// Get the depth of specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int DepthOfMipmap( int mipmapIndex ) => IsDepthConstant ? Depth : Math.Max( 1, Depth >> mipmapIndex );

        /// <summary>
        /// Get the number of pixels of a plane in specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int NumPixelsOfMipmapPerPlane( int mipmapIndex ) => WidthOfMipmap( mipmapIndex ) * HeightOfMipmap( mipmapIndex );

        /// <summary>
        /// Get the number of pixels of specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int NumPixelsOfMipmap( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * DepthOfMipmap( mipmapIndex );

        /// <summary>
        /// Get the number of bytes of a plane in specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public abstract int NumBytesOfMipmapPerPlane( int mipmapIndex );

        /// <summary>
        /// Get the number of bytes of specified mipmap. Does not check whether mipmapIndex is out of bounds.
        /// </summary>
        public int NumBytesOfMipmap( int mipmapIndex ) => NumBytesOfMipmapPerPlane( mipmapIndex ) * DepthOfMipmap( mipmapIndex );

        /// <summary>
        /// Create a new instance of same class.
        /// </summary>
        protected abstract TextureBuffer CreateNew( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer );

        /// <summary>
        /// Convert specified portion of raw data into A8R8G8B8 format.
        /// </summary>
        protected abstract void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth );

        /// <summary>
        /// Filter out the plane at specified Z.
        /// </summary>
        public TextureBuffer Filter( int? mip = null, int? z = null, TexFile.TextureFormat? format = null )
        {
            var b8g8r8a8 = false;
            if( format.HasValue )
            {
                if( format.Value == TexFile.TextureFormat.B8G8R8A8 )
                    b8g8r8a8 = true;
                else
                    throw new ArgumentException( $"Unsupported target format {format.Value}", nameof( format ) );
            }

            if( z == 0 && Depth == 1 )
                z = 0;

            if( mip == null && MipmapAllocations.Length == 1 )
                mip = 0;

            if( mip == null )
            {
                if( z == null )
                {
                    if( format == null )
                        return this;
                }
                else
                {
                    if( MipmapAllocations.Length > 1 )
                        throw new ArgumentException( "Mipmap index must be specified to filter specific Z if when there are multiple mipmaps.", nameof( z ) );
                    z = 0;
                }
            }
            else
            {
                if( mip < 0 || mip >= MipmapAllocations.Length )
                    throw new ArgumentOutOfRangeException( nameof( mip ) );
                if( z != null && ( z < 0 || z >= DepthOfMipmap( mip.Value ) ) )
                    throw new ArgumentOutOfRangeException( nameof( z ) );
            }

            List< Tuple< int, int, int, int, int, int > > copyList = new();
            int[] newMipmapAllocations;
            int newWidth, newHeight, newDepth;
            if( mip == null )
            {
                newMipmapAllocations = new int[MipmapAllocations.Length];
                newWidth = Width;
                newHeight = Height;
                newDepth = Depth;
                int srcOffset = 0, dstOffset = 0;
                for( var i = 0; i < newMipmapAllocations.Length; i++ )
                {
                    newMipmapAllocations[ i ] = b8g8r8a8 ? 4 * NumPixelsOfMipmap( i ) : NumBytesOfMipmap( i );

                    copyList.Add( new Tuple< int, int, int, int, int, int >(
                        srcOffset,
                        dstOffset,
                        newMipmapAllocations[ i ],
                        WidthOfMipmap( i ),
                        HeightOfMipmap( i ),
                        z == null ? DepthOfMipmap( i ) : 1
                    ) );

                    newMipmapAllocations[ i ] = ( newMipmapAllocations[ i ] + 3 ) / 4 * 4;
                    srcOffset += MipmapAllocations[ i ];
                    dstOffset += newMipmapAllocations[ i ];
                }
            }
            else
            {
                newWidth = WidthOfMipmap( mip.Value );
                newHeight = HeightOfMipmap( mip.Value );
                newDepth = z == null ? DepthOfMipmap( mip.Value ) : 1;

                if( z == null )
                    newMipmapAllocations = new[] { b8g8r8a8 ? 4 * NumPixelsOfMipmap( mip.Value ) : NumBytesOfMipmap( mip.Value ) };
                else
                    newMipmapAllocations = new[] { b8g8r8a8 ? 4 * NumPixelsOfMipmapPerPlane( mip.Value ) : NumBytesOfMipmapPerPlane( mip.Value ) };

                copyList.Add( new Tuple< int, int, int, int, int, int >(
                    MipmapAllocations[ ..mip.Value ].Sum() + ( z == null ? 0 : z.Value * NumBytesOfMipmapPerPlane( mip.Value ) ),
                    0,
                    newMipmapAllocations[ 0 ],
                    newWidth,
                    newHeight,
                    newDepth
                ) );
                newMipmapAllocations[ 0 ] = ( newMipmapAllocations[ 0 ] + 3 ) / 4 * 4;
            }

            var buffer = new byte[newMipmapAllocations.Sum()];
            if( b8g8r8a8 )
            {
                foreach( var (srcOffset, dstOffset, _, w, h, d) in copyList )
                    ConvertToB8G8R8A8( buffer, dstOffset, srcOffset, w, h, d );

                return new B8G8R8A8TextureBuffer( z == null && IsDepthConstant, newWidth, newHeight, newDepth, newMipmapAllocations, buffer );
            }
            else
            {
                foreach( var (srcOffset, dstOffset, dstSize, _, _, _) in copyList )
                    Buffer.BlockCopy( RawData, srcOffset, buffer, dstOffset, dstSize );

                return CreateNew( z == null && IsDepthConstant, newWidth, newHeight, newDepth, newMipmapAllocations, buffer );
            }
        }

        /// <summary>
        /// Create a new instance of <see cref="TextureBuffer"/>, depending on the specified texture format.
        /// </summary>
        public static TextureBuffer FromTextureFormat(
            TexFile.Attribute attribute,
            TexFile.TextureFormat format,
            int width,
            int height,
            int depth,
            int[] mipmapAllocations,
            byte[] buffer )
        {
            var isDepthConstant = false;

            if( ( attribute & TexFile.Attribute.TextureTypeCube ) != 0 )
            {
                isDepthConstant = true;
                depth = 6;
            }

            switch( format )
            {
                // Integer types
                case TexFile.TextureFormat.L8:
                    return new L8TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.A8:
                    return new A8TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B4G4R4A4:
                    return new B4G4R4A4TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B5G5R5A1:
                    return new B5G5R5A1TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B8G8R8A8:
                    return new B8G8R8A8TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B8G8R8X8:
                    return new B8G8R8X8TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );

                // Floating point types
                case TexFile.TextureFormat.R16G16B16A16F:
                    return new R16G16B16A16FTextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.R32G32B32A32F:
                    return new R32G32B32A32FTextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );

                // Block compression types
                case TexFile.TextureFormat.BC1:
                case TexFile.TextureFormat.BC2:
                case TexFile.TextureFormat.BC3:
                case TexFile.TextureFormat.BC5:
                case TexFile.TextureFormat.BC7:
                    return new BlockCompressionTextureBuffer( format, isDepthConstant, width, height, depth, mipmapAllocations, buffer );

                default:
                    var numBitsPerPixel = 1 << ( (int)( format & TexFile.TextureFormat.BppMask ) >> (int)TexFile.TextureFormat.BppShift );
                    var numBytesPerPixel = numBitsPerPixel >> 3;
                    if( numBytesPerPixel == 0 )
                        throw new NotImplementedException( $"TextureFormat 0x{(int)format:X04} is not supported for image conversion." );
                    return new UnsupportedTextureBuffer( numBytesPerPixel, isDepthConstant, width, height, depth, mipmapAllocations, buffer );
            }
        }

        /// <summary>
        /// Create a new instance of <see cref="TextureBuffer"/> from a BinaryReader that supports seeking.
        /// </summary>
        public static unsafe TextureBuffer FromStream( TexFile.TexHeader header, BinaryReader Reader )
        {
            var mipmapAllocations = new int[Math.Min( 13, (int)header.MipLevels )];
            for( var i = 0; i < mipmapAllocations.Length - 1; i++ )
                mipmapAllocations[ i ] = (int)( header.OffsetToSurface[ i + 1 ] - header.OffsetToSurface[ i ] );
            mipmapAllocations[ ^1 ] = (int)( Reader.BaseStream.Length - header.OffsetToSurface[ mipmapAllocations.Length - 1 ] );

            var buffer = new byte[mipmapAllocations.Sum()];
            Reader.BaseStream.Position = header.OffsetToSurface[ 0 ];
            // ReSharper disable once MustUseReturnValue
            Reader.BaseStream.Read( buffer );

            return FromTextureFormat( header.Type, header.Format, header.Width, header.Height, header.Depth, mipmapAllocations, buffer );
        }
    }
}