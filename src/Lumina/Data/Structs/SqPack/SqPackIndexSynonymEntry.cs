using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SqPackIndexSynonymEntry<T> where T : IUnsignedNumber<T>
{
    public ulong HashValue;
    public SqPackIndexTableEntry Data;
    public uint Index;
    public fixed byte PathBuffer[240];

    public readonly T Hash => Unsafe.As<ulong, T>(ref Unsafe.AsRef(in HashValue));

    public readonly string? Path =>
        Marshal.PtrToStringAnsi(
            (nint)Unsafe.AsPointer(
                ref Unsafe.AsRef(
                    in PathBuffer[0]
                )
            )
        );
}
