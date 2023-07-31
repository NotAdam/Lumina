using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Describes a DDS file header.
/// </summary>
[StructLayout( LayoutKind.Sequential, Size = 124 )]
public struct DdsHeader
{
    /// <summary>Size of structure. This member must be set to 124.</summary>
    public int Size;

    /// <summary>Flags to indicate which members contain valid data.</summary>
    public DdsHeaderFlags Flags;

    /// <summary>Surface height (in pixels).</summary>
    public int Height;

    /// <summary>Surface Width (in pixels).</summary>
    public int Width;

    /// <summary>
    /// The pitch or number of bytes per scan line in an uncompressed texture; the total number of bytes in the top
    /// level texture for a compressed texture. For information about how to compute the pitch, see the DDS File
    /// Layout section of the Programming Guide for DDS.</summary>
    public int PitchOrLinearSize;

    /// <summary>Depth of a volume texture (in pixels), otherwise unused.</summary>
    public int Depth;

    /// <summary>Number of mipmap levels, otherwise unused.</summary>
    public int MipMapCount;

    /// <summary>Unused.</summary>
    public Reserved1Struct Reserved1;

    /// <summary>The pixel format.</summary>
    public DdsPixelFormat PixelFormat;

    /// <summary>Specifies the complexity of the surfaces stored.</summary>
    public DdsCaps1 Caps;

    /// <summary>Additional detail about the surfaces stored.</summary>
    public DdsCaps2 Caps2;

    /// <summary>Unused.</summary>
    public int Caps3;

    /// <summary>Unused.</summary>
    public int Caps4;

    /// <summary>Unused.</summary>
    public int Reserved2;

    /// <summary>
    /// Interprets PitchOrLinearSize as Pitch value, depending on Flags.
    /// On setting this value, it will also change Flags accordingly.
    /// </summary>
    public int Pitch {
        get => Flags.HasFlag( DdsHeaderFlags.LinearSize )
            ? PitchOrLinearSize / Height
            : PitchOrLinearSize;
        set {
            Flags &= ~DdsHeaderFlags.LinearSize;
            PitchOrLinearSize = value;
        }
    }

    /// <summary>
    /// Interprets PitchOrLinearSize as LinearSize value, depending on Flags.
    /// On setting this value, it will also change Flags accordingly.
    /// </summary>
    public int LinearSize {
        get => Flags.HasFlag( DdsHeaderFlags.LinearSize )
            ? PitchOrLinearSize
            : PitchOrLinearSize * Height;
        set {
            Flags |= DdsHeaderFlags.LinearSize;
            PitchOrLinearSize = value;
        }
    }

    /// <summary>
    /// Read the struct from the given BinaryReader.
    /// </summary>
    /// <param name="reader">Little-endian BinaryReader to read from.</param>
    public void ReadFrom( BinaryReader reader )
    {
        Size = reader.ReadInt32();
        Flags = (DdsHeaderFlags) reader.ReadInt32();
        Height = reader.ReadInt32();
        Width = reader.ReadInt32();
        PitchOrLinearSize = reader.ReadInt32();
        Depth = reader.ReadInt32();
        MipMapCount = reader.ReadInt32();
        Reserved1.ReadFrom( reader );
        PixelFormat.ReadFrom( reader );
        Caps = (DdsCaps1) reader.ReadInt32();
        Caps2 = (DdsCaps2) reader.ReadInt32();
        Caps3 = reader.ReadInt32();
        Caps4 = reader.ReadInt32();
        Reserved2 = reader.ReadInt32();
    }

    /// <summary>
    /// Write the struct to the given BinaryWriter.
    /// </summary>
    /// <param name="writer">Little-endian BinaryWriter to write to.</param>
    public readonly void WriteTo( BinaryWriter writer )
    {
        writer.Write( Size );
        writer.Write( (int) Flags );
        writer.Write( Height );
        writer.Write( Width );
        writer.Write( PitchOrLinearSize );
        writer.Write( Depth );
        writer.Write( MipMapCount );
        Reserved1.WriteTo( writer );
        PixelFormat.WriteTo( writer );
        writer.Write( (int) Caps );
        writer.Write( (int) Caps2 );
        writer.Write( Caps3 );
        writer.Write( Caps4 );
        writer.Write( Reserved2 );
    }

    /// <summary>
    /// Represents the fixed size array <see cref="DdsHeader.Reserved1"/> in <see cref="DdsHeader"/>.
    /// </summary>
    public struct Reserved1Struct : IReadOnlyList< int >
    {
        /// <summary>
        /// Length of Reserved1 field.
        /// </summary>
        private const int CountConst = 11;

        /// <summary>
        /// Fixed values.
        /// </summary>
        [SuppressMessage( "ReSharper", "UnassignedField.Global" )]
        public unsafe fixed int FixedArray[CountConst];

        /// <summary>
        /// Get or set the value in Reserved1.
        /// </summary>
        /// <param name="index"></param>
        public unsafe int this[ int index ] {
            get => FixedArray[ index ];
            set => FixedArray[ index ] = value;
        }

        /// <summary>
        /// Read the struct from the given BinaryReader.
        /// </summary>
        /// <param name="reader">Little-endian BinaryReader to read from.</param>
        public unsafe void ReadFrom( BinaryReader reader )
        {
            for( var i = 0; i < CountConst; i++ )
                FixedArray[ i ] = reader.ReadInt32();
        }

        /// <summary>
        /// Write the struct to the given BinaryWriter.
        /// </summary>
        /// <param name="writer">Little-endian BinaryWriter to write to.</param>
        public readonly unsafe void WriteTo( BinaryWriter writer )
        {
            for( var i = 0; i < CountConst; i++ )
                writer.Write( FixedArray[ i ] );
        }

        /// <inheritdoc/>
        public IEnumerator< int > GetEnumerator()
        {
            for( var i = 0; i < CountConst; i++ )
                yield return this[ i ];
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        public int Count => CountConst;
    }
}