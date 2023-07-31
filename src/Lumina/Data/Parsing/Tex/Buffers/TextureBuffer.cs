using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data.Files;
using Lumina.Data.Structs;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a texture in .tex file.
    /// </summary>
    public abstract class TextureBuffer
    {
        /// <summary>
        /// Attribute of the texture contained within.
        /// </summary>
        public readonly TexFile.Attribute Attribute;
        
        /// <summary>
        /// Indicates whether this texture is a cube map or 2D texture array. See <see cref="Attribute"/>.
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
        /// Depth(for 3D textures)/number of faces(for cube maps)/number of images(for 2D texture arrays) of this texture. 
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
        /// <param name="attribute">Attribute of the texture buffer.</param>
        /// <param name="width">Width of the primary mipmap.</param>
        /// <param name="height">Height of the primary mipmap.</param>
        /// <param name="depth">Depth of the primary mipmap.</param>
        /// <param name="mipmapAllocations">Number of bytes allocated for each mipmap.</param>
        /// <param name="buffer">Byte array containing multiple mipmaps, one right after another allocation.</param>
        /// <param name="invokeFirst">Function to run before constructing. Hack to work around design failure on expecting subclass ctor to have run.</param>
        protected TextureBuffer( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer,
            Action<TextureBuffer>? invokeFirst = null)
        {
            invokeFirst?.Invoke(this);
            
            IsDepthConstant = ( attribute & TexFile.Attribute.TextureTypeMask ) is TexFile.Attribute.TextureTypeCube or TexFile.Attribute.TextureType2DArray;
            Width = width;
            Height = height;
            Depth = depth;
            Attribute = attribute;

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
        protected abstract TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer );

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

                return new B8G8R8A8TextureBuffer( z == null ? Attribute : TexFile.Attribute.TextureType2D, newWidth, newHeight, newDepth, newMipmapAllocations, buffer );
            }
            else
            {
                foreach( var (srcOffset, dstOffset, dstSize, _, _, _) in copyList )
                    Buffer.BlockCopy( RawData, srcOffset, buffer, dstOffset, dstSize );

                return CreateNew( z == null ? Attribute : TexFile.Attribute.TextureType2D, newWidth, newHeight, newDepth, newMipmapAllocations, buffer );
            }
        }

        private static int GetEncodedPS3TextureOffset( int x, int y, int z, int log2width, int log2height, int log2depth )
        {
            var loopCount = log2width + log2height + log2depth;
            int offset = 0;

            for( int i = 0; i < loopCount; )
            {
                if( log2width > 0 )
                {
                    offset |= ( x & 1 ) << i++;

                    x >>= 1;
                    log2width--;
                }
                if( log2height > 0 )
                {
                    offset |= ( y & 1 ) << i++;

                    y >>= 1;
                    log2height--;
                }
                if( log2depth > 0 )
                {
                    offset |= ( z & 1 ) << i++;

                    z >>= 1;
                    log2depth--;
                }
            }

            return offset;
        }

        private static byte[] DecodePS3Texture( byte[] src, int width, int height, int depth, int pixelSize, int[] mipmapAllocations, bool isCube )
        {
            var buffer = new byte[ src.Length ];
            var srcBaseOffset = 0;
            var dstBaseOffset = 0;
            var faces = isCube ? 6 : 1;

            for( int i = 0; i < mipmapAllocations.Length; i++ )
            {
                var log2width = Math.ILogB( width );
                var log2height = Math.ILogB( height );
                var log2depth = Math.ILogB( depth );

                var srcOffset = 0;
                var dstOffset = dstBaseOffset;

                for( var j = 0; j < faces; j++ )
                {
                    for( var k = 0; k < depth; k++ )
                    {
                        for( var l = 0; l < height; l++ )
                        {
                            for( var m = 0; m < width; m++ )
                            {
                                srcOffset = srcBaseOffset + GetEncodedPS3TextureOffset( m, l, k, log2width, log2height, log2depth ) * pixelSize;

                                Array.Copy( src, srcOffset, buffer, dstOffset, pixelSize );

                                dstOffset += pixelSize;
                            }
                        }
                    }

                    srcBaseOffset = srcOffset;
                }

                depth = Math.Max( depth >> 2, 1 );
                height = Math.Max( height >> 1, 1 );
                width = Math.Max( width >> 1, 1 );

                dstBaseOffset += mipmapAllocations[ i ];
            }

            return buffer;
        }

        private static byte[] DecodePS3Texture3D_DXT( byte[] src, int width, int height, int depth, int pixelSize, int[] mipmapAllocations )
        {
            var buffer = new byte[ src.Length ];
            var srcPosition = 0;
            var dstBaseOffset = 0;

            for( var i = 0; i < mipmapAllocations.Length; i++ )
            {
                var dxtWidth = Math.Max( width / 4, 1 );
                var dxtHeight = Math.Max( height / 4, 1 );
                var dxtDepth = Math.Max( depth / 4, 1 );

                var size = pixelSize * dxtWidth * dxtHeight;
                var depth4Size = Math.Min( depth, 4 ) * size;

                for( var j = 0; j < dxtDepth; j++ )
                {
                    var dstOffset = dstBaseOffset + size * j * 4;

                    for( var k = 0; k < dxtHeight; k++ )
                    {
                        for( var l = 0; l < dxtWidth; l++ )
                        {
                            for( var m = 0; m < depth4Size; m += size )
                            {
                                Array.Copy( src, srcPosition, buffer, dstOffset + m, pixelSize );

                                srcPosition += pixelSize;
                            }

                            dstOffset += pixelSize;
                        }
                    }
                }

                depth = Math.Max( depth >> 2, 1 );
                height = Math.Max( height >> 1, 1 );
                width = Math.Max( width >> 1, 1 );

                dstBaseOffset += mipmapAllocations[ i ];
            }

            return buffer;
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
            byte[] buffer,
            PlatformId platformId )
        {
            if( platformId == PlatformId.PS3 )
            {
                switch( format )
                {
                    case TexFile.TextureFormat.B4G4R4A4:
                    case TexFile.TextureFormat.B5G5R5A1:
                    case TexFile.TextureFormat.R16G16B16A16F:
                        for( var i = 0; i < buffer.Length; i += 2 )
                        {
                            Array.Reverse( buffer, i, 2 );
                        }
                        break;

                    case TexFile.TextureFormat.B8G8R8A8:
                    case TexFile.TextureFormat.B8G8R8X8:
                    case TexFile.TextureFormat.R32G32B32A32F:
                        for( var i = 0; i < buffer.Length; i += 4 )
                        {
                            Array.Reverse( buffer, i, 4 );
                        }
                        break;
                }

                if( ( width & ( width - 1 ) ) == 0 && ( height & ( height - 1 ) ) == 0 )
                {
                    if( attribute.HasFlag( TexFile.Attribute.TextureType3D ) &&
                        (int)( format & TexFile.TextureFormat.TypeMask ) >> (int)TexFile.TextureFormat.TypeShift == (int)TexFile.TextureFormat.TypeDxt )
                    {
                        buffer = DecodePS3Texture3D_DXT( buffer, width, height, depth, format == TexFile.TextureFormat.DXT1 ? 8 : 16, mipmapAllocations );
                    }
                    else
                    {
                        switch( format )
                        {
                            case TexFile.TextureFormat.L8:
                            case TexFile.TextureFormat.A8:
                                buffer = DecodePS3Texture( buffer, width, height, depth, 1, mipmapAllocations, attribute.HasFlag( TexFile.Attribute.TextureTypeCube ) );
                                break;

                            case TexFile.TextureFormat.B4G4R4A4:
                            case TexFile.TextureFormat.B5G5R5A1:
                                buffer = DecodePS3Texture( buffer, width, height, depth, 2, mipmapAllocations, attribute.HasFlag( TexFile.Attribute.TextureTypeCube ) );
                                break;

                            case TexFile.TextureFormat.B8G8R8A8:
                            case TexFile.TextureFormat.B8G8R8X8:
                                buffer = DecodePS3Texture( buffer, width, height, depth, 4, mipmapAllocations, attribute.HasFlag( TexFile.Attribute.TextureTypeCube ) );
                                break;

                            case TexFile.TextureFormat.R16G16B16A16F:
                                buffer = DecodePS3Texture( buffer, width * 2, height, depth, 4, mipmapAllocations, attribute.HasFlag( TexFile.Attribute.TextureTypeCube ) );
                                break;

                            case TexFile.TextureFormat.R32G32B32A32F:
                                buffer = DecodePS3Texture( buffer, width * 4, height, depth, 4, mipmapAllocations, attribute.HasFlag( TexFile.Attribute.TextureTypeCube ) );
                                break;
                        }
                    }
                }
            }

            if( ( attribute & TexFile.Attribute.TextureTypeCube ) != 0 )
            {
                depth = 6;
            }

            switch( format )
            {
                // Integer types
                case TexFile.TextureFormat.L8:
                    return new L8TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.A8:
                    return new A8TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B4G4R4A4:
                    return new B4G4R4A4TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B5G5R5A1:
                    return new B5G5R5A1TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B8G8R8A8:
                    return new B8G8R8A8TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.B8G8R8X8:
                    return new B8G8R8X8TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );

                // Floating point types
                case TexFile.TextureFormat.R16G16B16A16F:
                    return new R16G16B16A16FTextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
                case TexFile.TextureFormat.R32G32B32A32F:
                    return new R32G32B32A32FTextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );

                // Block compression types
                case TexFile.TextureFormat.BC1:
                case TexFile.TextureFormat.BC2:
                case TexFile.TextureFormat.BC3:
                case TexFile.TextureFormat.BC5:
                case TexFile.TextureFormat.BC7:
                    return new BlockCompressionTextureBuffer( format, attribute, width, height, depth, mipmapAllocations, buffer );

                default:
                    var numBitsPerPixel = 1 << ( (int)( format & TexFile.TextureFormat.BppMask ) >> (int)TexFile.TextureFormat.BppShift );
                    var numBytesPerPixel = numBitsPerPixel >> 3;
                    if( numBytesPerPixel == 0 )
                        throw new NotImplementedException( $"TextureFormat 0x{(int)format:X04} is not supported for image conversion." );
                    return new UnsupportedTextureBuffer( numBytesPerPixel, attribute, width, height, depth, mipmapAllocations, buffer );
            }
        }

        /// <summary>
        /// Create a new instance of <see cref="TextureBuffer"/> from a BinaryReader that supports seeking.
        /// </summary>
        public static unsafe TextureBuffer FromStream( TexFile.TexHeader header, LuminaBinaryReader reader )
        {
            var mipmapAllocations = new int[Math.Min( 13, (int)header.MipLevels2 )];
            for( var i = 0; i < mipmapAllocations.Length - 1; i++ )
                mipmapAllocations[ i ] = (int)( header.OffsetToSurface[ i + 1 ] - header.OffsetToSurface[ i ] );
            mipmapAllocations[ ^1 ] = (int)( reader.BaseStream.Length - header.OffsetToSurface[ mipmapAllocations.Length - 1 ] );

            var buffer = new byte[mipmapAllocations.Sum()];
            reader.BaseStream.Position = header.OffsetToSurface[ 0 ];
            // ReSharper disable once MustUseReturnValue
            reader.BaseStream.Read( buffer );

            var nd = ( header.Type & TexFile.Attribute.TextureTypeMask ) switch
            {
                TexFile.Attribute.TextureType3D => header.Depth,
                TexFile.Attribute.TextureTypeCube => 6,
                TexFile.Attribute.TextureType2DArray => header.ArraySize,
                _ => 1,
            };
            return FromTextureFormat( header.Type, header.Format, header.Width, header.Height, nd, mipmapAllocations, buffer, reader.PlatformId );
        }
    }
}