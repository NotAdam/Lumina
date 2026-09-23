using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public struct SqPackFileHeader
{
    public uint HeaderSize;
    public SqPackFileType Type;
    public uint UncompressedFileSize;

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackFileHeader ReverseEndianness() =>
        this with
        {
            HeaderSize = BinaryPrimitives.ReverseEndianness( HeaderSize ),
            Type = (SqPackFileType)BinaryPrimitives.ReverseEndianness( (uint)Type ),
            UncompressedFileSize = BinaryPrimitives.ReverseEndianness( UncompressedFileSize ),
        };
}
