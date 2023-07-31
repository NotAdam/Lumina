using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Lumina.Data.Attributes;
using Lumina.Data.Parsing.Tex.Buffers;
using Lumina.Data.Parsing.Tex.DirectDrawSurface;

// ReSharper disable InconsistentNaming

namespace Lumina.Data.Files
{
    [FileExtension( ".tex" )]
    public class TexFile : FileResource
    {
        [Flags]
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
            TextureType2DArray = 0x10000000,
            TextureTypeCube = 0x2000000,
            TextureTypeMask = 0x13C00000,
            TextureSwizzle = 0x4000000,
            TextureNoTiled = 0x8000000,
            TextureNoSwizzle = 0x80000000,
        }

        /// <summary>
        /// Texture formats. Channel ordering in name follows the enumeration in DXGI_FORMAT.
        ///
        /// Excerpt from: https://docs.microsoft.com/en-us/windows/win32/api/dxgiformat/ne-dxgiformat-dxgi_format
        /// > Most formats have byte-aligned components, and the components are in C-array order (the least address comes first).
        /// > For those formats that don't have power-of-2-aligned components, the first named component is in the least-significant bits.  
        /// </summary>
        [Flags]
        public enum TextureFormat
        {
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
            TypeBc123 = 0x3,
            TypeDepthStencil = 0x4,
            TypeSpecial = 0x5,
            TypeBc57 = 0x6,

            Unknown = 0x0,

            // Integer types
            L8 = 0x1130,
            A8 = 0x1131,
            B4G4R4A4 = 0x1440,
            B5G5R5A1 = 0x1441,
            B8G8R8A8 = 0x1450,
            B8G8R8X8 = 0x1451,

            [Obsolete( "Use B4G4R4A4 instead." )] R4G4B4A4 = 0x1440,
            [Obsolete( "Use B5G5R5A1 instead." )] R5G5B5A1 = 0x1441,
            [Obsolete( "Use B8G8R8A8 instead." )] A8R8G8B8 = 0x1450,
            [Obsolete( "Use B8G8R8X8 instead." )] R8G8B8X8 = 0x1451,

            [Obsolete( "Not supported by Windows DirectX 11 version of the game, nor have any mention of the value, as of 6.15." )]
            A8R8G8B82 = 0x1452,

            // Floating point types
            R32F = 0x2150,
            R16G16F = 0x2250,
            R32G32F = 0x2260,
            R16G16B16A16F = 0x2460,
            R32G32B32A32F = 0x2470,

            // Block compression types (DX9 names)
            DXT1 = 0x3420,
            DXT3 = 0x3430,
            DXT5 = 0x3431,
            ATI2 = 0x6230,

            // Block compression types (DX11 names)
            BC1 = 0x3420,
            BC2 = 0x3430,
            BC3 = 0x3431,
            BC5 = 0x6230,
            BC7 = 0x6432,

            // Depth stencil types
            // Does not exist in ffxiv_dx11.exe: RGBA8 0x4401
            D16 = 0x4140,
            D24S8 = 0x4250,

            // Special types
            Null = 0x5100,
            Shadow16 = 0x5140,
            Shadow24 = 0x5150,
        }

        /// <summary>
        /// Header of a .tex file.
        /// </summary>
        [StructLayout( LayoutKind.Explicit, Size = 80 )]
        public unsafe struct TexHeader
        {
            /// <summary>
            /// Various flags of the texture file.
            /// </summary>
            [FieldOffset( 0 )] public Attribute Type;

            /// <summary>
            /// Format of the texture.
            /// </summary>
            [FieldOffset( 4 )] public TextureFormat Format;

            /// <summary>
            /// Width of the texture.
            /// </summary>
            [FieldOffset( 8 )] public ushort Width;

            /// <summary>
            /// Height of the texture.
            /// </summary>
            /// <remarks>
            /// Relevant only if <see cref="Type"/> specifies <see cref="Attribute.TextureType2D"/>; otherwise it should be set to 1.
            /// </remarks>
            [FieldOffset( 10 )] public ushort Height;

            /// <summary>
            /// Depth of the texture.
            /// </summary>
            /// <remarks>
            /// Relevant only if <see cref="Type"/> specifies <see cref="Attribute.TextureType3D"/>; otherwise it should be set to 1.
            /// </remarks>
            [FieldOffset( 12 )] public ushort Depth;

            /// <summary>
            /// The field has been repurposed; use <see cref="MipLevels2"/>.
            /// </summary>
            [FieldOffset( 14 )] [Obsolete( "Use MipLevels6_4 instead; the field has been repurposed." )]
            public ushort MipLevels;

            /// <summary>
            /// Number of mipmaps in the texture.
            /// </summary>
            /// <remarks>There should be at least 1 and at most 13 mipmap entries; refer to the length of <see cref="OffsetToSurface"/>.</remarks>
            [FieldOffset( 14 )] public byte MipLevels2;

            /// <summary>
            /// Number of entries in texture array in the file.
            /// </summary>
            /// <remarks>
            /// Relevant only if <see cref="Type"/> specifies <see cref="Attribute.TextureType2DArray"/>; otherwise it should be set to 0.
            /// </remarks>
            [FieldOffset( 15 )] public byte ArraySize;

            /// <summary>
            /// <b>Index</b> of the mipmap entries corresponding for high, med, and low LoDs.
            /// </summary>
            [FieldOffset( 16 )] public fixed uint LodOffset[3];

            /// <summary>
            /// Byte offset to the mipmap entries, from the beginning of the file. Entry is set to 0 if no corresponding mipmap exists.
            /// </summary>
            [FieldOffset( 28 )] public fixed uint OffsetToSurface[13];
        };

        /// <summary>
        /// Specify preprocessing texture data for consumption in DXGI.
        /// </summary>
        public enum DxgiFormatConversion
        {
            /// <summary>
            /// No conversion is required.
            /// </summary>
            NoConversion,

            /// <summary>
            /// Conversion from L8 (8bpp) to B8G8R8A8 (32bpp) is required.
            /// Each byte indicates color value for each RGB channel. Alpha channel is fixed to 255.
            /// </summary>
            FromL8ToB8G8R8A8,

            /// <summary>
            /// Conversion from B4G4R4A4 (16bpp) to B8G8R8A8 (32bpp) is required.
            /// </summary>
            FromB4G4R4A4ToB8G8R8A8,

            /// <summary>
            /// Conversion from B5G5R5A1 (16bpp) to B8G8R8A8 (32bpp) is required.
            /// </summary>
            FromB5G5R5A1ToB8G8R8A8,
        }

        private byte[]? _imageDataDefault;

        /// <summary>
        /// File header of a .tex file.
        /// </summary>
        public TexHeader Header;

        /// <summary>
        /// Size of the <see cref="TexHeader"/>.
        /// </summary>
        public int HeaderLength => Unsafe.SizeOf< TexHeader >();

        /// <summary>
        /// Parsed texture buffer, in original texture format.
        /// </summary>
        public TextureBuffer TextureBuffer = null!;

        /// <summary>
        /// The converted A8R8G8B8 image, taking the first array item/Z/face/mipmap.
        /// </summary>
        public byte[] ImageData {
            get {
                _imageDataDefault ??= TextureBuffer.Filter( mip: 0, z: 0, format: TextureFormat.B8G8R8A8 ).RawData;
                return _imageDataDefault;
            }
        }

        /// <inheritdoc />
        public override void LoadFile()
        {
            Reader.BaseStream.Position = 0;
            Header = Reader.ReadStructure< TexHeader >();

            if( ( Header.Type & Attribute.TextureTypeCube ) != 0 && Header.Depth != 1 )
                throw new NotSupportedException( "Cube map texture with depth value above 1 is currently not supported." );

            TextureBuffer = TextureBuffer.FromStream( Header, Reader );
        }

        /// <summary>
        /// Calculate the number of bytes occupied by a mipmap slice.
        /// </summary>
        /// <param name="mipmapIndex">Index of mipmap.</param>
        /// <param name="width">Width of mipmap.</param>
        /// <param name="height">Height of mipmap.</param>
        /// <returns>Number of bytes.</returns>
        public int SliceSize( int mipmapIndex, out int width, out int height )
        {
            if( mipmapIndex < 0 || mipmapIndex >= Math.Max( (int) Header.MipLevels2, 1 ) )
                throw new ArgumentOutOfRangeException( nameof( mipmapIndex ), mipmapIndex, null );

            var bpp = 1 << ( (int) ( Header.Format & TextureFormat.BppMask ) >> (int) TextureFormat.BppShift );
            width = Math.Max( 1, Header.Width >> mipmapIndex );
            height = Math.Max( 1, Header.Height >> mipmapIndex );
            switch( (TextureFormat) ( (int) ( Header.Format & TextureFormat.TypeMask ) >> (int) TextureFormat.TypeShift ) )
            {
                case TextureFormat.TypeBc123:
                case TextureFormat.TypeBc57:
                    var nbw = Math.Max( 1, ( width + 3 ) / 4 );
                    var nbh = Math.Max( 1, ( height + 3 ) / 4 );
                    return nbw * nbh * bpp * 2;
                case TextureFormat.TypeInteger:
                case TextureFormat.TypeFloat:
                case TextureFormat.TypeDepthStencil:
                case TextureFormat.TypeSpecial:
                    return width * height * bpp / 8;
                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Get the backing data of a slice in a 3D texture, a face in a cube map, or an image in texture array.
        /// </summary>
        /// <param name="mipmapIndex">Index of mipmap.</param>
        /// <param name="sliceIndex">Index of slice/face/image.</param>
        /// <param name="sliceSize">Number of bytes occupied for the slice.</param>
        /// <param name="width">Width of mipmap.</param>
        /// <param name="height">Height of mipmap.</param>
        /// <returns>The slice data.</returns>
        /// <remarks>Note that the length of span may be less than sliceSize, in which case, the truncated data should be treated as zeroes.</remarks>
        public unsafe Span< byte > SliceSpan( int mipmapIndex, int sliceIndex, out int sliceSize, out int width, out int height )
        {
            sliceSize = SliceSize( mipmapIndex, out width, out height );
            if( mipmapIndex < 0 || mipmapIndex >= Math.Max( (int) Header.MipLevels2, 1 ) )
                throw new ArgumentOutOfRangeException( nameof( mipmapIndex ), mipmapIndex, null );

            switch( Header.Type & Attribute.TextureTypeMask )
            {
                case var _ when sliceIndex < 0:
                case Attribute.TextureType1D when sliceIndex != 0:
                case Attribute.TextureType2D when sliceIndex != 0:
                case Attribute.TextureType3D when sliceIndex >= Header.Depth:
                case Attribute.TextureTypeCube when sliceIndex >= 6:
                case Attribute.TextureType2DArray when sliceIndex >= Header.ArraySize:
                    throw new ArgumentOutOfRangeException( nameof( sliceIndex ), sliceIndex, null );
            }

            var offset = (int) Header.OffsetToSurface[ mipmapIndex ] + sliceIndex * sliceSize;
            return offset >= Data.Length ? new() : Data.AsSpan( offset, Math.Min( Data.Length - offset, sliceSize ) );
        }

        /// <summary>
        /// Create a <see cref="DdsFile"/> from this <see cref="TexFile"/>.
        /// </summary>
        public DdsFile ToDdsFile( bool preferDxt10Header = false )
        {
            var dds = new DdsFile( new()
            {
                Size = Unsafe.SizeOf< DdsHeader >(),
                Flags = DdsHeaderFlags.Caps | DdsHeaderFlags.PixelFormat,
                Caps = DdsCaps1.Texture,
            } );

            if( Header.MipLevels2 > 1 )
            {
                dds.Header.Caps |= DdsCaps1.Complex | DdsCaps1.Mipmap;
                dds.Header.Flags |= DdsHeaderFlags.MipmapCount;
                dds.Header.MipMapCount = Header.MipLevels2;
            }

            var textureType = Header.Type & Attribute.TextureTypeMask;
            switch( textureType )
            {
                case Attribute.TextureType1D:
                    dds.Header.Flags |= DdsHeaderFlags.Width;
                    dds.Header.Width = Header.Width;
                    break;
                case Attribute.TextureType2D:
                    dds.Header.Flags |= DdsHeaderFlags.Width | DdsHeaderFlags.Height;
                    dds.Header.Width = Header.Width;
                    dds.Header.Height = Header.Height;
                    break;
                case Attribute.TextureType3D:
                    dds.Header.Caps |= DdsCaps1.Complex;
                    dds.Header.Flags |= DdsHeaderFlags.Width | DdsHeaderFlags.Height | DdsHeaderFlags.Depth;
                    dds.Header.Width = Header.Width;
                    dds.Header.Height = Header.Height;
                    dds.Header.Depth = Header.Depth;
                    break;
                case Attribute.TextureTypeCube:
                    dds.Header.Caps |= DdsCaps1.Complex;
                    dds.Header.Caps2 |= DdsCaps2.AllFaces;
                    dds.Header.Flags |= DdsHeaderFlags.Width | DdsHeaderFlags.Height;
                    dds.Header.Width = Header.Width;
                    dds.Header.Height = Header.Height;
                    break;
                case Attribute.TextureType2DArray:
                    dds.Header.Flags |= DdsHeaderFlags.Width | DdsHeaderFlags.Height;
                    dds.Header.Width = Header.Width;
                    dds.Header.Height = Header.Height;
                    preferDxt10Header = true;
                    break;
                default:
                    throw new NotSupportedException( "Header.Type has an unsupported value" );
            }

            dds.Header.Pitch = dds.Pitch( 0 );

            switch( Header.Format )
            {
                case TextureFormat.Null:
                    throw new NotSupportedException( "The TexFile has no format set." );
                case TextureFormat.BC1 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetFourCc( DdsFourCc.Bc1 );
                    break;
                case TextureFormat.BC2 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetFourCc( DdsFourCc.Bc2 );
                    break;
                case TextureFormat.BC3 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetFourCc( DdsFourCc.Bc3 );
                    break;
                case TextureFormat.BC5 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetFourCc( DdsFourCc.Bc5 );
                    break;
                case TextureFormat.L8 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetLuminance( 8, 0xFF, 0 );
                    break;
                case TextureFormat.A8 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetAlpha( 8, 0xFF );
                    break;
                case TextureFormat.B4G4R4A4 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetBgra( 16, 0x000F, 0x00F0, 0x0F00, 0xF000 );
                    break;
                case TextureFormat.B5G5R5A1 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetBgra( 16, 0b0000000000011111, 0b0000001111100000, 0b0111110000000000, 0b1000000000000000 );
                    break;
                case TextureFormat.B8G8R8A8 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetBgra( 32, 0x000000FF, 0x0000FF00, 0x00FF0000, 0xFF000000 );
                    break;
                case TextureFormat.B8G8R8X8 when !preferDxt10Header:
                    dds.Header.PixelFormat.SetBgra( 32, 0x000000FF, 0x0000FF00, 0x00FF0000, 0 );
                    break;
                case TextureFormat.BC1:
                    dds.SetDxt10Header( DxgiFormat.Bc1Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.BC2:
                    dds.SetDxt10Header( DxgiFormat.Bc2Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.BC3:
                    dds.SetDxt10Header( DxgiFormat.Bc3Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.BC5:
                    dds.SetDxt10Header( DxgiFormat.Bc5Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.BC7:
                    dds.SetDxt10Header( DxgiFormat.Bc7Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.L8:
                    dds.SetDxt10Header( DxgiFormat.R8Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.A8:
                    dds.SetDxt10Header( DxgiFormat.A8Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.B4G4R4A4:
                    dds.SetDxt10Header( DxgiFormat.B4G4R4A4Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.B5G5R5A1:
                    dds.SetDxt10Header( DxgiFormat.B5G5R5A1Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.B8G8R8A8:
                    dds.SetDxt10Header( DxgiFormat.B8G8R8A8Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.B8G8R8X8:
                    dds.SetDxt10Header( DxgiFormat.B8G8R8X8Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.R32F:
                    dds.SetDxt10Header( DxgiFormat.R32Float, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.R16G16F:
                    dds.SetDxt10Header( DxgiFormat.R16G16Float, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.R32G32F:
                    dds.SetDxt10Header( DxgiFormat.R32G32Float, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.R16G16B16A16F:
                    dds.SetDxt10Header( DxgiFormat.R16G16B16A16Float, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.R32G32B32A32F:
                    dds.SetDxt10Header( DxgiFormat.R32G32B32A32Float, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeStraight );
                    break;
                case TextureFormat.D16:
                    dds.SetDxt10Header( DxgiFormat.D16Unorm, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.D24S8:
                    dds.SetDxt10Header( DxgiFormat.D24UnormS8Uint, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.Shadow16:
                    dds.SetDxt10Header( DxgiFormat.R16Typeless, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                case TextureFormat.Shadow24:
                    dds.SetDxt10Header( DxgiFormat.R24G8Typeless, Header.ArraySize, DdsHeaderDxt10MiscFlags2.AlphaModeOpaque );
                    break;
                default:
                    throw new NotSupportedException();
            }

            dds.Body = new byte[dds.BodySize];
            foreach( var slice in dds.EnumerateSlices() )
            {
                var targetSpan = dds.SliceSpan( slice.Image, slice.Face, slice.Mipmap, slice.Slice );
                var sourceSpan = SliceSpan( slice.Mipmap, textureType switch
                {
                    Attribute.TextureType1D or Attribute.TextureType2D or Attribute.TextureType3D => slice.Slice,
                    Attribute.TextureTypeCube => slice.Face,
                    Attribute.TextureType2DArray => slice.Image,
                    _ => throw new InvalidOperationException(),
                }, out _, out _, out _ );
                sourceSpan.CopyTo( targetSpan );
            }

            return dds;
        }

        /// <summary>
        /// Get DXGI_FORMAT and required preprocessing from TextureFormat.
        /// </summary>
        /// <param name="format">.tex texture format value.</param>
        /// <param name="useGameCompatible">Whether to emulate the game on preprocessing texture data.</param>
        /// <remarks>
        /// Values are taken from v6.15 ffxiv_dx11.exe+0x321f80.
        /// </remarks>
        public static Tuple< int, DxgiFormatConversion > GetDxgiFormatFromTextureFormat( TextureFormat format, bool useGameCompatible = true )
        {
            return format switch
            {
                TextureFormat.Unknown => Tuple.Create( 0x00, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_UNKNOWN
                TextureFormat.Null => Tuple.Create( 0x00, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_UNKNOWN
                TextureFormat.R32G32B32A32F => Tuple.Create( 0x02, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R32G32B32A32_FLOAT
                TextureFormat.R16G16B16A16F => Tuple.Create( 0x0a, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R16G16B16A16_FLOAT
                TextureFormat.R32G32F => Tuple.Create( 0x10, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R32G32_FLOAT
                TextureFormat.R16G16F => Tuple.Create( 0x22, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R16G16_FLOAT 
                TextureFormat.R32F => Tuple.Create( 0x29, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R32_FLOAT
                TextureFormat.D24S8 => Tuple.Create( 0x2c, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R24G8_TYPELESS
                TextureFormat.Shadow24 => Tuple.Create( 0x2c, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R24G8_TYPELESS
                TextureFormat.D16 => Tuple.Create( 0x35, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R16_TYPELESS
                TextureFormat.Shadow16 => Tuple.Create( 0x35, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_R16_TYPELESS
                TextureFormat.A8 => Tuple.Create( 0x41, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_A8_UNORM
                TextureFormat.BC1 => Tuple.Create( 0x47, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_BC1_UNORM
                TextureFormat.BC2 => Tuple.Create( 0x4a, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_BC2_UNORM
                TextureFormat.BC3 => Tuple.Create( 0x4d, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_BC3_UNORM
                TextureFormat.BC5 => Tuple.Create( 0x53, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_BC5_UNORM
                TextureFormat.L8 => Tuple.Create( 0x57, DxgiFormatConversion.FromL8ToB8G8R8A8 ), // each pixel is RGBA(x, x, x, 255)
                TextureFormat.B4G4R4A4 => useGameCompatible
                    ? Tuple.Create( 0x57, DxgiFormatConversion.FromB4G4R4A4ToB8G8R8A8 ) // DXGI_FORMAT_B8G8R8A8_UNORM
                    : Tuple.Create( 0x73, DxgiFormatConversion.NoConversion ) // DXGI_FORMAT_B4G4R4A4_UNORM
                , // DXGI_FORMAT_B4G4R4A4_UNORM(0x73): unsupported in dx10, dx10.1, dx11, and dx11.1 (before windows8)
                TextureFormat.B5G5R5A1 => useGameCompatible
                    ? Tuple.Create( 0x57, DxgiFormatConversion.FromB5G5R5A1ToB8G8R8A8 ) // DXGI_FORMAT_B8G8R8A8_UNORM
                    : Tuple.Create( 0x56, DxgiFormatConversion.NoConversion ) // DXGI_FORMAT_B5G5R5A1_UNORM
                , // DXGI_FORMAT_B5G5R5A1_UNORM(0x56): unsupported in dx10, dx10.1, dx11, and dx11.1 (before windows8)
                TextureFormat.B8G8R8A8 => Tuple.Create( 0x57, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_B8G8R8A8_UNORM
                TextureFormat.B8G8R8X8 => Tuple.Create( 0x58, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_B8G8R8X8_UNORM
                TextureFormat.BC7 => Tuple.Create( 0x62, DxgiFormatConversion.NoConversion ), // DXGI_FORMAT_BC7_UNORM
                _ => throw new NotSupportedException( $"TextureFormat {(int) format:X04} is not supported." ),
            };
        }
    }
}