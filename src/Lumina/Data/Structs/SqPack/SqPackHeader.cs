using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.SqPack;

[StructLayout( LayoutKind.Sequential, Pack = 4 )]
public struct SqPackHeader
{
    public ulong Magic;
    public PlatformType Platform;
    public uint Size;
    public uint Version;
    public uint Type;

    /// <summary>
    /// Returns a copy of this header with its multi-byte fields byte swapped, as PS3 store them
    /// big endian.
    /// </summary>
    public readonly SqPackHeader ReverseEndianness() =>
        this with
        {
            Size = BinaryPrimitives.ReverseEndianness( Size ),
            Version = BinaryPrimitives.ReverseEndianness( Version ),
            Type = BinaryPrimitives.ReverseEndianness( Type ),
        };
}
