using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct SqPackIndexHeader
    {
        public UInt32 size;
        public UInt32 version;
        public UInt32 index_data_offset;
        public UInt32 index_data_size;
        public fixed byte index_data_hash[64];
        public UInt32 number_of_data_file;
        public UInt32 synonym_data_offset;
        public UInt32 synonym_data_size;
        public fixed byte synonym_data_hash[64];
        public UInt32 empty_block_data_offset;
        public UInt32 empty_block_data_size;
        public fixed byte empty_block_data_hash[64];
        public UInt32 dir_index_data_offset;
        public UInt32 dir_index_data_size;
        public fixed byte dir_index_data_hash[64];
        public UInt32 index_type;
        public fixed byte _reserved[656];
        public fixed byte self_hash[64];
    }

    [StructLayout( LayoutKind.Sequential )]
    public struct IndexHashTableEntry
    {
        public UInt64 hash;
        public UInt32 data;
        private UInt32 _padding;

        public bool IsSynonym => ( data & 0b1 ) == 0b1;

        public byte DataFileId => (byte) ( ( data & 0b1110 ) >> 1 );

        public long Offset => ( (uint)data & ~0xF ) * 0x08;
    }
    
    [StructLayout( LayoutKind.Sequential )]
    public struct Index2HashTableEntry
    {
        public UInt32 hash;
        public UInt32 data;

        public bool IsSynonym => ( data & 0b1 ) == 0b1;

        public byte DataFileId => (byte) ( ( data & 0b1110 ) >> 1 );

        public long Offset => ( (uint)data & ~0xF ) * 0x08;
    }
}