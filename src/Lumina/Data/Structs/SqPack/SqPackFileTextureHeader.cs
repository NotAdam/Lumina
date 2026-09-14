using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SqPackFileTextureHeader
{
    public SqPackFileHeader Base;
    public uint ModelNumBlocks;
    public uint ModelUsedNumBlocks;
    public uint BlockCount;
}
