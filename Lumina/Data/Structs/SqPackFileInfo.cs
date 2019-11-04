using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs
{
    public enum FileType : UInt32
    {
        Empty = 1, 
        Standard = 2, 
        Model = 3, 
        Texture = 4,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SqPackFileInfo
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public fixed UInt32 __unknown[2];
        public UInt32 number_of_blocks;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DatStdFileBlockInfos
    {
        public UInt32 offset;
        public UInt16 size;
        public UInt16 uncompressed_size;
    };
    
    [StructLayout(LayoutKind.Sequential)]
    struct DatBlockHeader
    {
        public UInt32 size;
        public UInt32 unknown1;
        public UInt32 compressed_size;
        public UInt32 uncompressed_size;
    };

    [StructLayout(LayoutKind.Sequential)]
    struct LodBlock
    {
        public UInt32 comp_offset;
        public UInt32 comp_size;
        public UInt32 decomp_size;
        public UInt32 block_offset;
        public UInt32 block_count;
    }
}