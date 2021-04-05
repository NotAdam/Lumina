using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class Category
    {
        private readonly GameData _gameData;
        public DirectoryInfo RootDir { get; }

        public byte CategoryId { get; }

        public int Expansion { get; }

        public int Chunk { get; }

        public PlatformId Platform { get; }

        public SqPackIndex Index { get; }

        public Dictionary< UInt64, IndexHashTableEntry > IndexHashTableEntries { get; set; }
        public Dictionary< uint, Index2HashTableEntry > Index2HashTableEntries { get; set; }

        public Dictionary< byte, SqPack > DatFiles { get; }

        internal Category(
            byte category,
            int expansion,
            int chunk,
            PlatformId platform,
            SqPackIndex index,
            DirectoryInfo rootDir,
            GameData gameData )
        {
            _gameData = gameData;
            CategoryId = category;
            Expansion = expansion;
            Chunk = chunk;
            Platform = platform;
            Index = index;
            RootDir = rootDir;

            DatFiles = new Dictionary< byte, SqPack >();

            // init dats
            for( byte id = 0; id < index.IndexHeader.number_of_data_file; id++ )
            {
                var datName = Repository.BuildDatStr( CategoryId, Expansion, Chunk, Platform, $"dat{id}" );

                var path = Path.Combine( RootDir.FullName, datName );

                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    DatFiles[ id ] = new SqPack( fileInfo, _gameData );
                }
            }

            // postprocess indexes into one hashlist
            IndexHashTableEntries = new Dictionary< ulong, IndexHashTableEntry >();

            if( index.IsIndex2 )
            {
                Index2HashTableEntries = index.HashTableEntries2;
            }
            else
            {
                IndexHashTableEntries = index.HashTableEntries;
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

        public bool TryGetFileDatOffset( ulong hash, out byte dataFileId, out long offset )
        {
            if( IndexHashTableEntries.TryGetValue( hash, out var hashTableEntry ) )
            {
                dataFileId = hashTableEntry.DataFileId;
                offset = hashTableEntry.Offset;
                return true;
            }

            dataFileId = 0;
            offset = 0;

            return false;
        }

        public bool TryGetFileDatOffset( uint hash, out byte dataFileId, out long offset )
        {
            if( Index2HashTableEntries.TryGetValue( hash, out var hashTableEntry ) )
            {
                dataFileId = hashTableEntry.DataFileId;
                offset = hashTableEntry.Offset;
                return true;
            }

            dataFileId = 0;
            offset = 0;

            return false;
        }

        public bool TryGetFileDatOffset( ParsedFilePath path, out byte dataFileId, out long offset )
        {
            if( !Index.IsIndex2 )
            {
                return TryGetFileDatOffset( path.IndexHash, out dataFileId, out offset );
            }

            return TryGetFileDatOffset( path.Index2Hash, out dataFileId, out offset );
        }

        public T GetFile< T >( ulong hash ) where T : FileResource
        {
            var status = TryGetFileDatOffset( hash, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            return GetFile< T >( dataFileId, offset );
        }

        public T GetFile< T >( uint hash ) where T : FileResource
        {
            var status = TryGetFileDatOffset( hash, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            return GetFile< T >( dataFileId, offset );
        }

        public T GetFile< T >( ParsedFilePath path ) where T : FileResource
        {
            var status = TryGetFileDatOffset( path, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            var file = GetFile< T >( dataFileId, offset );

            file.FilePath = path;

            return file;
        }

        public T GetFile< T >( byte dataFileId, long offset ) where T : FileResource
        {
            var dat = DatFiles[ dataFileId ];
            var file = dat.ReadFile< T >( offset );

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