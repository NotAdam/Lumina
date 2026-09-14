using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public unsafe struct SqPackIndexBufferDescriptor
{
    public uint Offset;
    public uint Size;
    public fixed byte Hash[0x40];

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackIndexBufferDescriptor ReverseEndianness()
    {
        var ret = this;
        ret.Offset = BinaryPrimitives.ReverseEndianness( Offset );
        ret.Size = BinaryPrimitives.ReverseEndianness( Size );
        return ret;
    }
}
