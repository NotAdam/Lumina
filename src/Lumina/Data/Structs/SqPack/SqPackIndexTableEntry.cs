using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct SqPackIndexTableEntry
{
    public uint Data;

    public readonly bool IsSynonym => (Data & 1) == 0;

    public readonly byte DataFileIdx => (byte)((Data >> 1) & 0x7);

    public readonly long Offset => (Data & ~0xF) << 3;
}
