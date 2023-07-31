using System.IO;
using System.Runtime.InteropServices;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Represents a DDS header, with the magic value.
/// </summary>
[StructLayout( LayoutKind.Sequential, Size = 128 )]
public struct DdsHeaderWithMagic
{
    /// <summary>
    /// Magic constant for a DDS file.
    /// </summary>
    public const uint MagicValue = 0x20534444;

    /// <summary>
    /// Magic value.
    /// </summary>
    public uint Magic;

    /// <summary>
    /// The DDS header.
    /// </summary>
    public DdsHeader Header;

    /// <summary>
    /// Read the struct from the given BinaryReader.
    /// </summary>
    /// <param name="reader">Little-endian BinaryReader to read from.</param>
    public void ReadFrom( BinaryReader reader )
    {
        Magic = reader.ReadUInt32();
        Header.ReadFrom( reader );
    }

    /// <summary>
    /// Write the struct to the given BinaryWriter.
    /// </summary>
    /// <param name="writer">Little-endian BinaryWriter to write to.</param>
    public readonly void WriteTo( BinaryWriter writer )
    {
        writer.Write( Magic );
        Header.WriteTo( writer );
    }
}