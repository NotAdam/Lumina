using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 1 )]
public unsafe struct SqPackIndexHeader
{
    public uint Size;
    public uint Version;
    public SqPackIndexBufferDescriptor IndexData;
    public uint DataFileCount;
    public SqPackIndexBufferDescriptor SynonymData;
    public SqPackIndexBufferDescriptor EmptyBlockData;
    public SqPackIndexBufferDescriptor DirIndexData;
    public uint IndexType;
    public fixed byte Reserved[0x290];
    public fixed byte SelfHash[0x40];

    /// <inheritdoc cref="SqPackHeader.ReverseEndianness"/>
    public readonly SqPackIndexHeader ReverseEndianness()
    {
        var ret = this;
        ret.Size = BinaryPrimitives.ReverseEndianness( Size );
        ret.Version = BinaryPrimitives.ReverseEndianness( Version );
        ret.IndexData = IndexData.ReverseEndianness();
        ret.DataFileCount = BinaryPrimitives.ReverseEndianness( DataFileCount );
        ret.SynonymData = SynonymData.ReverseEndianness();
        ret.EmptyBlockData = EmptyBlockData.ReverseEndianness();
        ret.DirIndexData = DirIndexData.ReverseEndianness();
        ret.IndexType = BinaryPrimitives.ReverseEndianness( IndexType );
        return ret;
    }
}
