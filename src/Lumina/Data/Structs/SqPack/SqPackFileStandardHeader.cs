using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public struct SqPackFileStandardHeader
{
    public SqPackFileHeader Base;
    public uint Unused1;
    public uint Unused2;
    public uint BlockCount;

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackFileStandardHeader ReverseEndianness() =>
        this with
        {
            Base = Base.ReverseEndianness(),
            BlockCount = BinaryPrimitives.ReverseEndianness( BlockCount ),
        };
}
