using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct SqPackHeader
    {
        public fixed byte magic[8];
        public PlatformId platformId;
        public fixed byte __unknown[3];
        public UInt32 size;
        public UInt32 version;
        public UInt32 type;
    }
}