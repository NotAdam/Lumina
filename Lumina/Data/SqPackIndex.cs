using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Lumina.Data.Structs;
using Lumina.Extensions;

namespace Lumina.Data
{
    public class SqPackIndex : SqPack
    {
        public bool IsIndex2 { get; set; }

        public SqPackIndexHeader IndexHeader { get; private set; }

        public Dictionary< UInt64, IndexHashTableEntry > HashTableEntries { get; set; }

        internal SqPackIndex( FileInfo indexFile, Lumina lumina ) : base( indexFile, lumina )
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
            using var br = new BinaryReader( fs );

            // skip og header
            fs.Position = SqPackHeader.size;

            // read index hdr
            IndexHeader = br.ReadStructure< SqPackIndexHeader >();

            HashTableEntries = new Dictionary< UInt64, IndexHashTableEntry >();

            // read hashtable entries
            fs.Position = IndexHeader.index_data_offset;
            var entryCount = IndexHeader.index_data_size / Marshal.SizeOf( typeof( IndexHashTableEntry ) );

            var entries = br.ReadStructures< IndexHashTableEntry >( (int)entryCount );

            foreach( var entry in entries )
            {
                HashTableEntries[ entry.hash ] = entry;
            }
        }

        private void LoadIndex2()
        {
            using var fs = File.OpenRead();
            using var br = new BinaryReader( fs );

            // skip og header
            fs.Position = SqPackHeader.size;

            // read index hdr
            IndexHeader = br.ReadStructure< SqPackIndexHeader >();
            
            // create u64 type
            HashTableEntries = new Dictionary< UInt64, IndexHashTableEntry >();

            // read hashtable entries
            fs.Position = IndexHeader.index_data_offset;
            var entryCount = IndexHeader.index_data_size / Marshal.SizeOf( typeof( Index2HashTableEntry ) );

            var entries = br.ReadStructures< Index2HashTableEntry >( (int)entryCount );

            foreach( var entry in entries )
            {
                // move index2 data into index so we can read em as is at the cost of slightly more mem usage
                HashTableEntries[ entry.hash ] = new IndexHashTableEntry
                {
                    data = entry.data,
                    hash = entry.hash
                };
            }
        }
    }
}