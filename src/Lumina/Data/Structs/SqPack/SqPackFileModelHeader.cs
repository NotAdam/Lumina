using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SqPackFileModelHeader
{
    public const int LOD_COUNT = 3;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Section<T> where T : unmanaged
    {
        public T Stack;
        public T Runtime;
        public LodBuffer<T> VertexBuffer;
        public LodBuffer<T> EdgeGeometryVertexBuffer;
        public LodBuffer<T> IndexBuffer;
    }

    [InlineArray(LOD_COUNT)]
    public struct LodBuffer<T> where T : unmanaged
    {
        public T _element;
    }
    
    public SqPackFileHeader Base;
    public uint BlockCount;
    public uint UsedBlockCount;
    public uint Version;

    public Section<uint> Sizes;
    public Section<uint> CompressedSizes;
    public Section<uint> Offsets;
    public Section<ushort> BlockIndices;
    public Section<ushort> BlockCounts;

    public ushort VertexDeclarationCount;
    public ushort MaterialCount;
    public byte LodCount;
    public bool IndexBufferStreamingEnabled;
    public bool EdgeGeometryEnabled;
    private byte _padding;
}
