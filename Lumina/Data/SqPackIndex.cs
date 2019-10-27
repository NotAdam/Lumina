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

        public SqPackIndex( FileInfo indexFile ) : base( indexFile )
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
            for( var i = 0; i < entryCount; i++ )
            {
                var entry = br.ReadStructure< IndexHashTableEntry >();
                
                HashTableEntries[ entry.hash ] = entry;
            }
        }

        private void LoadIndex2()
        {
            // todo: index2 loading
        }
    }
}