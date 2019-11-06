using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using ICSharpCode.SharpZipLib.Tar;
using Lumina.Data.Parsing.Tex;
using Lumina.Extensions;

namespace Lumina.Data.Files
{
    public class TexFile : FileResource
    {
        public enum Attribute : uint
        {
            ATTRIBUTE_DISCARD_PER_FRAME = 0x1,
            ATTRIBUTE_DISCARD_PER_MAP = 0x2,
            ATTRIBUTE_MANAGED = 0x4,
            ATTRIBUTE_USER_MANAGED = 0x8,
            ATTRIBUTE_CPU_READ = 0x10,
            ATTRIBUTE_LOCATION_MAIN = 0x20,
            ATTRIBUTE_NO_GPU_READ = 0x40,
            ATTRIBUTE_ALIGNED_SIZE = 0x80,
            ATTRIBUTE_EDGE_CULLING = 0x100,
            ATTRIBUTE_LOCATION_ONION = 0x200,
            ATTRIBUTE_READ_WRITE = 0x400,
            ATTRIBUTE_IMMUTABLE = 0x800,
            ATTRIBUTE_TEXTURE_RENDER_TARGET = 0x100000,
            ATTRIBUTE_TEXTURE_DEPTH_STENCIL = 0x200000,
            ATTRIBUTE_TEXTURE_TYPE_1D = 0x400000,
            ATTRIBUTE_TEXTURE_TYPE_2D = 0x800000,
            ATTRIBUTE_TEXTURE_TYPE_3D = 0x1000000,
            ATTRIBUTE_TEXTURE_TYPE_CUBE = 0x2000000,
            ATTRIBUTE_TEXTURE_TYPE_MASK = 0x3C00000,
            ATTRIBUTE_TEXTURE_SWIZZLE = 0x4000000,
            ATTRIBUTE_TEXTURE_NO_TILED = 0x8000000,
            ATTRIBUTE_TEXTURE_NO_SWIZZLE = 0x80000000,
        }

        public enum TextureFormat
        {
            TEXTURE_FORMAT_UNKNOWN = 0x0,
            TEXTURE_FORMAT_TYPE_SHIFT = 0xC,
            TEXTURE_FORMAT_TYPE_MASK = 0xF000,
            TEXTURE_FORMAT_COMPONENT_SHIFT = 0x8,
            TEXTURE_FORMAT_COMPONENT_MASK = 0xF00,
            TEXTURE_FORMAT_BPP_SHIFT = 0x4,
            TEXTURE_FORMAT_BPP_MASK = 0xF0,
            TEXTURE_FORMAT_ENUM_SHIFT = 0x0,
            TEXTURE_FORMAT_ENUM_MASK = 0xF,
            TEXTURE_FORMAT_TYPE_INTEGER = 0x1,
            TEXTURE_FORMAT_TYPE_FLOAT = 0x2,
            TEXTURE_FORMAT_TYPE_DXT = 0x3,
            TEXTURE_FORMAT_TYPE_DEPTH_STENCIL = 0x4,
            TEXTURE_FORMAT_TYPE_SPECIAL = 0x5,
            TEXTURE_FORMAT_R8G8B8A8 = 0x1450,
            TEXTURE_FORMAT_R8G8B8X8 = 0x1451,
            TEXTURE_FORMAT_A8R8G8B8 = 0x1452,
            TEXTURE_FORMAT_R4G4B4A4 = 0x1440,
            TEXTURE_FORMAT_R5G5B5A1 = 0x1441,
            TEXTURE_FORMAT_L8 = 0x1130,
            TEXTURE_FORMAT_A8 = 0x1131,
            TEXTURE_FORMAT_R32F = 0x2150,
            TEXTURE_FORMAT_R32G32B32A32F = 0x2470,
            TEXTURE_FORMAT_R16G16F = 0x2250,
            TEXTURE_FORMAT_R16G16B16A16F = 0x2460,
            TEXTURE_FORMAT_DXT1 = 0x3420,
            TEXTURE_FORMAT_DXT3 = 0x3430,
            TEXTURE_FORMAT_DXT5 = 0x3431,
            TEXTURE_FORMAT_D16 = 0x4140,
            TEXTURE_FORMAT_D24S8 = 0x4250,
            TEXTURE_FORMAT_NULL = 0x5100,
            TEXTURE_FORMAT_SHADOW16 = 0x5140,
            TEXTURE_FORMAT_SHADOW24 = 0x5150,
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct TexHeader
        {
            public Attribute Type;
            public TextureFormat Format;
            public ushort Width;
            public ushort Height;
            public ushort Depth;
            public ushort MipLevels;
            public fixed uint LodOffset[3];
            public fixed uint OffsetToSurface[13];
        };

        public TexHeader Header { get; private set; }

        public int HeaderLength => Unsafe.SizeOf< TexHeader >();

        /// <summary>
        /// The converted A8R8G8B8 image, in bytes.
        /// </summary>
        public byte[] ImageData { get; private set; }

        public override void LoadFile()
        {
            BinaryReader br = new BinaryReader(new MemoryStream(Data));
            Header = br.ReadStructure< TexHeader >();

            ImageData = Convert( DataSpan.Slice( HeaderLength ), Header.Width, Header.Height );
        }

        public unsafe Image GetImage()
        {
            // this is terrible please find something better or get rid of .net imaging altogether
            Image image;
            fixed( byte* p = ImageData )
            {
                var ptr = (IntPtr)p;
                using var tempImage = new Bitmap( Header.Width, Header.Height, Header.Width * 4, PixelFormat.Format32bppArgb, ptr );
                image = new Bitmap( tempImage );
            }

            return image;
        }

        // converts various formats to A8R8G8B8
        private byte[] Convert( Span< byte > src, int width, int height )
        {
            byte[] dst = new byte[ width * height * 4 ];

            switch( Header.Format )
            {
                case TextureFormat.TEXTURE_FORMAT_DXT1:
                    ProcessDxt1( src, dst, width, height );
                    break;
                case TextureFormat.TEXTURE_FORMAT_DXT3:
                    ProcessDxt3( src, dst, width, height );
                    break;
                case TextureFormat.TEXTURE_FORMAT_DXT5:
                    ProcessDxt5( src, dst, width, height );
                    break;
                case TextureFormat.TEXTURE_FORMAT_R16G16B16A16F:
                    ProcessA16R16G16B16_Float( src, dst, width, height);
                    break;
                case TextureFormat.TEXTURE_FORMAT_R5G5B5A1:
                    ProcessA1R5G5B5( src, dst, width, height );
                    break;
                case TextureFormat.TEXTURE_FORMAT_R4G4B4A4:
                    ProcessA4R4G4B4( src, dst, width, height );
                    break;
                case TextureFormat.TEXTURE_FORMAT_L8:
                    ProcessR3G3B2( src, dst, width, height );
                    break;
                default:
                    throw new NotImplementedException( $"TextureFormat {Header.Format.ToString()} is not supported for image conversion." );
            }

            return dst;
        }

        // #region shamelessly copied from coinach
        // might be slowed down by src copying when calling squish
        private static void ProcessA16R16G16B16_Float( Span< byte > src, byte[] dst, int width, int height )
        {
            // Clipping can, and will occur since values go outside 0..1
            for( var i = 0; i < width * height; ++i )
            {
                var srcOff = i * 4 * 2;
                var dstOff = i * 4;

                for( var j = 0; j < 4; ++j )
                    dst[dstOff + j] = (byte)(src.Unpack( srcOff + j * 2 ) * byte.MaxValue );
            }
        }

        private static void ProcessA1R5G5B5( Span<byte> src, byte[] dst, int width, int height )
        {
            for( var i = 0; ( i + 2 ) <= 2 * width * height; i += 2 )
            {
                var v = BitConverter.ToUInt16( src.Slice( i, sizeof( UInt16 ) ) );

                var a = (uint)( v & 0x8000 );
                var r = (uint)( v & 0x7C00 );
                var g = (uint)( v & 0x03E0 );
                var b = (uint)( v & 0x001F );

                var rgb = ( ( r << 9 ) | ( g << 6 ) | ( b << 3 ) );
                var argbValue = ( a * 0x1FE00 | rgb | ( ( rgb >> 5 ) & 0x070707 ) );

                for( var j = 0; j < 4; ++j )
                    dst[i * 2 + j] = (byte)( argbValue >> ( 8 * j ) );
            }
        }

        private static void ProcessA4R4G4B4( Span<byte> src, byte[] dst, int width, int height )
        {
            for( var i = 0; ( i + 2 ) <= 2 * width * height; i += 2 )
            {
                var v = BitConverter.ToUInt16( src.Slice( i, sizeof( UInt16 ) ) );

                for( var j = 0; j < 4; ++j )
                    dst[i * 2 + j] = (byte)( ( ( v >> ( 4 * j ) ) & 0x0F ) << 4 );
            }
        }

        private static void ProcessA8R8G8B8( Span<byte> src, byte[] dst, int width, int height )
        {
            // Some transparent images have larger dst lengths than their src.
            var length = Math.Min( src.Length, dst.Length );
            src.Slice( 0, length ).CopyTo(dst.AsSpan());
        }

        private static void ProcessDxt1( Span<byte> src, byte[] dst, int width, int height )
        {
            var dec = Squish.DecompressImage( src.ToArray(), width, height, SquishOptions.DXT1 );
            Array.Copy( dec, dst, dst.Length );
        }

        private static void ProcessDxt3( Span<byte> src, byte[] dst, int width, int height )
        {
            var dec = Squish.DecompressImage( src.ToArray(), width, height, SquishOptions.DXT3 );
            Array.Copy( dec, dst, dst.Length );
        }

        private static void ProcessDxt5( Span<byte> src, byte[] dst, int width, int height )
        {
            var dec = Squish.DecompressImage( src.ToArray(), width, height, SquishOptions.DXT5 );
            Array.Copy( dec, dst, dst.Length );
        }

        private static void ProcessR3G3B2( Span<byte> src, byte[] dst, int width, int height )
        {
            for( var i = 0; i < width * height; ++i )
            {
                var r = (uint)( src[i] & 0xE0 );
                var g = (uint)( src[i] & 0x1C );
                var b = (uint)( src[i] & 0x03 );

                dst[i * 4 + 0] = (byte)( b | ( b << 2 ) | ( b << 4 ) | ( b << 6 ) );
                dst[i * 4 + 1] = (byte)( g | ( g << 3 ) | ( g << 6 ) );
                dst[i * 4 + 2] = (byte)( r | ( r << 3 ) | ( r << 6 ) );
                dst[i * 4 + 3] = 0xFF;
            }
        }
    }
}
