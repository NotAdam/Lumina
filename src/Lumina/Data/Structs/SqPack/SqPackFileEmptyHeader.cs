using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SqPackFileEmptyHeader
{
    public SqPackFileHeader Base;
    public uint Unused1;
    public uint Unused2;
    public uint CompressedFileSize;
}
