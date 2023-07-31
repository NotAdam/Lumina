using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Surface pixel format, stored in <see cref="DdsHeader" />.
/// </summary>
[StructLayout( LayoutKind.Sequential, Size = 32 )]
public struct DdsPixelFormat
{
    /// <summary>
    /// Size of this structure. Must be 32;
    /// </summary>
    public int Size;

    /// <summary>
    /// Values which indicate what type of data is in the surface.
    /// </summary>
    public DdsPixelFormatFlags Flags;

    /// <summary>
    /// Four-character codes for specifying compressed or custom formats.
    /// 
    /// Possible values include: DXT1, DXT2, DXT3, DXT4, or DXT5.
    /// A FourCC of DX10 indicates the prescense of the <see cref="DdsHeaderDxt10"/> extended header,
    /// and the <see cref="DdsHeaderDxt10.DxgiFormat" /> member of that structure indicates the true format.
    /// When using a four-character code, <see cref="Flags"/> must include <see cref="DdsPixelFormatFlags.FourCc"/>.
    /// </summary>
    public DdsFourCc FourCc;

    /// <summary>
    /// Number of bits in an RGB (possibly including alpha) format.
    ///
    /// Valid when <see cref="Flags"/> includes <see cref="DdsPixelFormatFlags.Rgb"/>, <see cref="DdsPixelFormatFlags.Luminance"/>, or <see cref="DdsPixelFormatFlags.Yuv"/>.
    /// </summary>
    public int RgbBitCount;

    /// <summary>
    /// Red (or luminance or Y) mask for reading color data.
    ///
    /// For instance, given the A8R8G8B8 format, the red mask would be 0x00ff0000.
    /// </summary>
    public uint RBitMask;

    /// <summary>
    /// Green (or U) mask for reading color data.
    ///
    /// For instance, given the A8R8G8B8 format, the green mask would be 0x0000ff00.
    /// </summary>
    public uint GBitMask;

    /// <summary>
    /// Blue (or V) mask for reading color data.
    ///
    /// For instance, given the A8R8G8B8 format, the blue mask would be 0x000000ff.
    /// </summary>
    public uint BBitMask;

    /// <summary>
    /// Alpha mask for reading alpha data.
    ///
    /// <see cref="Flags"/> must include <see cref="DdsPixelFormatFlags.AlphaPixels"/> or <see cref="DdsPixelFormatFlags.Alpha"/>.
    /// For instance, given the A8R8G8B8 format, the alpha mask would be 0xff000000.
    /// </summary>
    public uint ABitMask;

    /// <summary>
    /// Read the struct from the given BinaryReader.
    /// </summary>
    /// <param name="reader">Little-endian BinaryReader to read from.</param>
    public void ReadFrom( BinaryReader reader )
    {
        Size = reader.ReadInt32();
        Flags = (DdsPixelFormatFlags) reader.ReadInt32();
        FourCc = (DdsFourCc) reader.ReadInt32();
        RgbBitCount = reader.ReadInt32();
        RBitMask = reader.ReadUInt32();
        GBitMask = reader.ReadUInt32();
        BBitMask = reader.ReadUInt32();
        ABitMask = reader.ReadUInt32();
    }

    /// <summary>
    /// Write the struct to the given BinaryWriter.
    /// </summary>
    /// <param name="writer">Little-endian BinaryWriter to write to.</param>
    public readonly void WriteTo( BinaryWriter writer )
    {
        writer.Write( Size );
        writer.Write( (int) Flags );
        writer.Write( (int) FourCc );
        writer.Write( RgbBitCount );
        writer.Write( RBitMask );
        writer.Write( GBitMask );
        writer.Write( BBitMask );
        writer.Write( ABitMask );
    }

    /// <summary>
    /// Set this object to indicate a FourCC.
    /// </summary>
    public void SetFourCc( DdsFourCc fourCc )
    {
        this = default;
        Size = Unsafe.SizeOf< DdsPixelFormat >();
        Flags = DdsPixelFormatFlags.FourCc;
        FourCc = fourCc;
    }

    /// <summary>
    /// Set this object to indicate a luminance channel, and optionally with an alpha channel.
    /// </summary>
    public void SetLuminance( int nbits, uint lmask, uint amask )
    {
        this = default;
        Size = Unsafe.SizeOf< DdsPixelFormat >();
        RgbBitCount = nbits;
        Flags = DdsPixelFormatFlags.Luminance | ( amask == 0 ? 0 : DdsPixelFormatFlags.AlphaPixels );
        RBitMask = lmask;
        ABitMask = amask;
    }

    /// <summary>
    /// Set this object to indicate an alpha channel.
    /// </summary>
    public void SetAlpha( int nbits, uint amask )
    {
        this = default;
        Size = Unsafe.SizeOf< DdsPixelFormat >();
        RgbBitCount = nbits;
        Flags = DdsPixelFormatFlags.Alpha | DdsPixelFormatFlags.AlphaPixels;
        ABitMask = amask;
    }

    /// <summary>
    /// Set this object to indicate BGRA channels.
    /// </summary>
    public void SetBgra( int nbits, uint bmask, uint gmask, uint rmask, uint amask )
    {
        this = default;
        Size = Unsafe.SizeOf< DdsPixelFormat >();
        RgbBitCount = nbits;
        Flags = DdsPixelFormatFlags.Rgb | ( amask == 0 ? 0 : DdsPixelFormatFlags.AlphaPixels );
        BBitMask = bmask;
        GBitMask = gmask;
        RBitMask = rmask;
        ABitMask = amask;
    }
}