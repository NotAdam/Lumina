using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SqPackTextureBlock
{
    public uint Offset;
    public uint CompressedSize;
    public uint UncompressedSize;
    public uint BlockOffset;
    public uint BlockCount;
}
