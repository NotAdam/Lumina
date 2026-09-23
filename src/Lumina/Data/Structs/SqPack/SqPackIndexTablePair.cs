using System.Numerics;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct SqPackIndexTablePair<T> where T : IUnsignedNumber<T>
{
    public T Hash;
    public SqPackIndexTableEntry Data;
}
