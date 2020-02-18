using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data.Structs;
using Microsoft.VisualBasic;

namespace Lumina.Data
{
    public class Category
    {
        private readonly Lumina _Lumina;
        public DirectoryInfo RootDir { get; }

        public byte CategoryId { get; }

        public int Expansion { get; }

        public int Chunk { get; }

        public PlatformId Platform { get; }

        public List< SqPackIndex > SqPackIndexes { get; }
        
        public Dictionary< UInt64, IndexHashTableEntry > IndexHashTableEntries { get; set; }
        public Dictionary< uint, Index2HashTableEntry > Index2HashTableEntries { get; set; }

        public Dictionary< byte, SqPack > DatFiles { get; }

        internal Category(
            byte category,
            int expansion,
            int chunk,
            PlatformId platform,
            List< SqPackIndex > sqPackIndexes,
            DirectoryInfo rootDir,
            Lumina lumina )
        {
            _Lumina = lumina;
            CategoryId = category;
            Expansion = expansion;
            Chunk = chunk;
            Platform = platform;
            SqPackIndexes = sqPackIndexes;
            RootDir = rootDir;

            DatFiles = new Dictionary< byte, SqPack >();

            var rootIndex = sqPackIndexes.First();

            // init dats
            for( byte id = 0; id < rootIndex.IndexHeader.number_of_data_file; id++ )
            {
                var datName = Repository.BuildDatStr( CategoryId, Expansion, Chunk, Platform, $"dat{id}" );

                var path = Path.Combine( RootDir.FullName, datName );

                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    DatFiles[ id ] = new SqPack( fileInfo, _Lumina );
                }
            }
            
            // postprocess indexes into one hashlist
            IndexHashTableEntries = new Dictionary< ulong, IndexHashTableEntry >();

            foreach( var index in sqPackIndexes )
            {
                if( index.IsIndex2 )
                {
                    Index2HashTableEntries = index.HashTableEntries2;
                }
                else
                {
                    IndexHashTableEntries = index.HashTableEntries;
                }
            }
        }

        public bool FileExists( UInt64 hash )
        {
            return IndexHashTableEntries.ContainsKey( hash );
        }

        public bool FileExists( uint hash )
        {
            return Index2HashTableEntries.ContainsKey( hash );
        }

        private bool TryGetFileDatOffset( ParsedFilePath path, out byte dataFileId, out long offset )
        {
            if( IndexHashTableEntries.TryGetValue( path.IndexHash, out var hashTableEntry ) )
            {
                dataFileId = hashTableEntry.DataFileId;
                offset = hashTableEntry.Offset;
                return true;
            }
            
            if( Index2HashTableEntries.TryGetValue( path.Index2Hash, out var hashTableEntry2 ) )
            {
                dataFileId = hashTableEntry2.DataFileId;
                offset = hashTableEntry2.Offset;
                return true;
            }

            dataFileId = 0;
            offset = 0;

            return false;
        }

        public T GetFile< T >( ParsedFilePath path ) where T : FileResource
        {
            var status = TryGetFileDatOffset( path, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            // get dat
            var dat = DatFiles[ dataFileId ];
            var file = dat.ReadFile< T >( offset );

            file.FilePath = path;

            return file;
        }

        public SqPackFileInfo? GetFileMetadata( ParsedFilePath path )
        {
            var status = TryGetFileDatOffset( path, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            // get dat
            var dat = DatFiles[ dataFileId ];

            return dat.GetFileMetadata( offset );
        }

        public SqPack GetDat( byte datId )
        {
            return DatFiles.TryGetValue( datId, out var dat ) ? dat : null;
        }
    }
}