using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public struct SqPackStandardBlockDescriptor
{
    public uint Offset;
    public ushort CompressedSize;
    public ushort UncompressedSize;

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackStandardBlockDescriptor ReverseEndianness() =>
        this with
        {
            Offset = BinaryPrimitives.ReverseEndianness( Offset ),
            CompressedSize = BinaryPrimitives.ReverseEndianness( CompressedSize ),
            UncompressedSize = BinaryPrimitives.ReverseEndianness( UncompressedSize ),
        };
}
