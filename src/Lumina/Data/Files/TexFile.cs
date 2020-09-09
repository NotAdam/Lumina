using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using Lumina.Data.Parsing.Tex;
using Lumina.Extensions;

namespace Lumina.Data.Files
{
    public class TexFile : FileResource
    {
        public enum Attribute : uint
        {
            DiscardPerFrame = 0x1,
            DiscardPerMap = 0x2,
            Managed = 0x4,
            UserManaged = 0x8,
            CpuRead = 0x10,
            LocationMain = 0x20,
            NoGpuRead = 0x40,
            AlignedSize = 0x80,
            EdgeCulling = 0x100,
            LocationOnion = 0x200,
            ReadWrite = 0x400,
            Immutable = 0x800,
            TextureRenderTarget = 0x100000,
            TextureDepthStencil = 0x200000,
            TextureType1D = 0x400000,
            TextureType2D = 0x800000,
            TextureType3D = 0x1000000,
            TextureTypeCube = 0x2000000,
            TextureTypeMask = 0x3C00000,
            TextureSwizzle = 0x4000000,
            TextureNoTiled = 0x8000000,
            TextureNoSwizzle = 0x80000000,
        }

        public enum TextureFormat
        {
            Unknown = 0x0,
            TypeShift = 0xC,
            TypeMask = 0xF000,
            ComponentShift = 0x8,
            ComponentMask = 0xF00,
            BppShift = 0x4,
            BppMask = 0xF0,
            EnumShift = 0x0,
            EnumMask = 0xF,
            TypeInteger = 0x1,
            TypeFloat = 0x2,
            TypeDxt = 0x3,
            TypeDepthStencil = 0x4,
            TypeSpecial = 0x5,
            A8R8G8B8 = 0x1450,
            // todo:
            R8G8B8X8 = 0x1451,
            A8R8G8B82 = 0x1452,
            R4G4B4A4 = 0x1440,
            R5G5B5A1 = 0x1441,
            L8 = 0x1130,
            // todo:
            A8 = 0x1131,
            // todo:
            R32F = 0x2150,
            R32G32B32A32F = 0x2470,
            R16G16F = 0x2250,
            R16G16B16A16F = 0x2460,
            DXT1 = 0x3420,
            DXT3 = 0x3430,
            DXT5 = 0x3431,
            D16 = 0x4140,
            D24S8 = 0x4250,
            //todo: RGBA8 0x4401
            Null = 0x5100,
            Shadow16 = 0x5140,
            Shadow24 = 0x5150,
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

        public TexHeader Header;

        public int HeaderLength => Unsafe.SizeOf< TexHeader >();

        /// <summary>
        /// The converted A8R8G8B8 image, in bytes.
        /// </summary>
        public byte[] ImageData { get; private set; }

        public override void LoadFile()
        {
            Reader.BaseStream.Position = 0;
            Header = Reader.ReadStructure< TexHeader >();

            // todo: this isn't correct and reads out the whole data portion as 1 image instead of accounting for lod levels
            // probably a breaking change to fix this
            ImageData = Convert( DataSpan.Slice( HeaderLength ), Header.Width, Header.Height );
        }

        // converts various formats to A8R8G8B8
        private byte[] Convert( Span< byte > src, int width, int height )
        {
            byte[] dst = new byte[ width * height * 4 ];

            switch( Header.Format )
            {
                case TextureFormat.DXT1:
                    ProcessDxt1( src, dst, width, height );
                    break;
                case TextureFormat.DXT3:
                    ProcessDxt3( src, dst, width, height );
                    break;
                case TextureFormat.DXT5:
                    ProcessDxt5( src, dst, width, height );
                    break;
                case TextureFormat.R16G16B16A16F:
                    ProcessA16R16G16B16_Float( src, dst, width, height);
                    break;
                case TextureFormat.R5G5B5A1:
                    ProcessA1R5G5B5( src, dst, width, height );
                    break;
                case TextureFormat.R4G4B4A4:
                    ProcessA4R4G4B4( src, dst, width, height );
                    break;
                case TextureFormat.L8:
                    ProcessR3G3B2( src, dst, width, height );
                    break;
                case TextureFormat.A8R8G8B8:
                    src.CopyTo( dst );
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
                var v = BitConverter.ToUInt16( src.Slice( i, sizeof( UInt16 ) ).ToArray(), 0 );

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
                var v = BitConverter.ToUInt16( src.Slice( i, sizeof( UInt16 ) ).ToArray(), 0 );

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
