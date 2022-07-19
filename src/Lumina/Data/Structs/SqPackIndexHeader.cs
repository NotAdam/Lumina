using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct SqPackIndexHeader : IConvertEndianness
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

        public void ConvertEndianness()
        {
            size = BinaryPrimitives.ReverseEndianness( size );
            version = BinaryPrimitives.ReverseEndianness( version );
            index_data_offset = BinaryPrimitives.ReverseEndianness( index_data_offset );
            index_data_size = BinaryPrimitives.ReverseEndianness( index_data_size );
            number_of_data_file = BinaryPrimitives.ReverseEndianness( number_of_data_file );
            synonym_data_offset = BinaryPrimitives.ReverseEndianness( synonym_data_offset );
            synonym_data_size = BinaryPrimitives.ReverseEndianness( synonym_data_size );
            empty_block_data_offset = BinaryPrimitives.ReverseEndianness( empty_block_data_offset );
            empty_block_data_size = BinaryPrimitives.ReverseEndianness( empty_block_data_size );
            dir_index_data_offset = BinaryPrimitives.ReverseEndianness( dir_index_data_offset );
            dir_index_data_size = BinaryPrimitives.ReverseEndianness( dir_index_data_size );
            index_type = BinaryPrimitives.ReverseEndianness( index_type );
        }
    }

    [StructLayout( LayoutKind.Sequential )]
    public struct IndexHashTableEntry : IConvertEndianness
    {
        public UInt64 hash;
        public UInt32 data;
        private UInt32 _padding;

        public bool IsSynonym => ( data & 0b1 ) == 0b1;

        public byte DataFileId => (byte) ( ( data & 0b1110 ) >> 1 );

        public long Offset => ( (uint)data & ~0xF ) * 0x08;

        public void ConvertEndianness()
        {
            hash = BinaryPrimitives.ReverseEndianness( hash );
            data = BinaryPrimitives.ReverseEndianness( data );
            _padding = BinaryPrimitives.ReverseEndianness( _padding );
        }
    }
    
    [StructLayout( LayoutKind.Sequential )]
    public struct Index2HashTableEntry : IConvertEndianness
    {
        public UInt32 hash;
        public UInt32 data;

        public bool IsSynonym => ( data & 0b1 ) == 0b1;

        public byte DataFileId => (byte) ( ( data & 0b1110 ) >> 1 );

        public long Offset => ( (uint)data & ~0xF ) * 0x08;

        public void ConvertEndianness()
        {
            hash = BinaryPrimitives.ReverseEndianness( hash );
            data = BinaryPrimitives.ReverseEndianness( data );
        }
    }
}