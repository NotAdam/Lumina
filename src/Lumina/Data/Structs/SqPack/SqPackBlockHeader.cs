using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public struct SqPackBlockHeader
{
    public uint HeaderSize;
    public uint Unknown;
    public uint CompressedSize;
    public uint DataSize;

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackBlockHeader ReverseEndianness() =>
        this with
        {
            HeaderSize = BinaryPrimitives.ReverseEndianness( HeaderSize ),
            Unknown = BinaryPrimitives.ReverseEndianness( Unknown ),
            CompressedSize = BinaryPrimitives.ReverseEndianness( CompressedSize ),
            DataSize = BinaryPrimitives.ReverseEndianness( DataSize ),
        };
}
