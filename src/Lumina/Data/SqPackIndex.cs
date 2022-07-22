using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class SqPackIndex : SqPack
    {
        public bool IsIndex2 { get; set; }

        public SqPackIndexHeader IndexHeader { get; private set; }

        public Dictionary< ulong, IndexHashTableEntry > HashTableEntries { get; set; } = null!;
        public Dictionary< uint, Index2HashTableEntry > HashTableEntries2 { get; set; } = null!;

        internal SqPackIndex( FileInfo indexFile, GameData gameData ) : base( indexFile, gameData )
        {
            IsIndex2 = indexFile.Extension == ".index2";

            if( IsIndex2 )
            {
                LoadIndex2();
            }
            else
            {
                LoadIndex();
            }
        }

        private void LoadIndex()
        {
            using var fs = File.OpenRead();
            using var br = new LuminaBinaryReader( fs, SqPackHeader.platformId );

            // skip og header
            fs.Position = SqPackHeader.size;

            // read index hdr
            IndexHeader = br.ReadStructure< SqPackIndexHeader >();

            // read hashtable entries
            fs.Position = IndexHeader.index_data_offset;
            var entryCount = IndexHeader.index_data_size / Unsafe.SizeOf< IndexHashTableEntry >();
            var tableEntries = br.ReadStructuresAsSpan< IndexHashTableEntry >( (int)entryCount );

            if( SqPackHeader.platformId == PlatformId.PS3 )
            {
                for( var i = 0; i < entryCount; i++ )
                {
                    var data = tableEntries[ i ].data;
                    tableEntries[ i ].data = ( data << 4 ) | ( ( data & 0x70000000 ) >> 27 ) | ( ( data & 0x80000000 ) >> 31 );
                }
            }

            HashTableEntries = tableEntries.ToArray().ToDictionary( k => k.hash, v => v );
        }

        private void LoadIndex2()
        {
            using var fs = File.OpenRead();
            using var br = new LuminaBinaryReader( fs, SqPackHeader.platformId );

            // skip og header
            fs.Position = SqPackHeader.size;

            // read index hdr
            IndexHeader = br.ReadStructure< SqPackIndexHeader >();

            // read hashtable entries
            fs.Position = IndexHeader.index_data_offset;
            var entryCount = IndexHeader.index_data_size / Unsafe.SizeOf< Index2HashTableEntry >();
            var tableEntries = br.ReadStructuresAsSpan< Index2HashTableEntry >( (int)entryCount );

            if( SqPackHeader.platformId == PlatformId.PS3 )
            {
                for( var i = 0; i < entryCount; i++ )
                {
                    var data = tableEntries[ i ].data;
                    tableEntries[ i ].data = ( data << 4 ) | ( ( data & 0x70000000 ) >> 27 ) | ( ( data & 0x80000000 ) >> 31 );
                }
            }

            HashTableEntries2 = tableEntries.ToArray().ToDictionary( k => k.hash, v => v );
        }
    }
}