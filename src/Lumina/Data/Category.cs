using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class Category
    {
        private readonly GameData _gameData;
        private Dictionary< ulong, IndexHashTableEntry >? _indexHashTableEntries;
        private Dictionary< uint, Index2HashTableEntry >? _index2HashTableEntries;
        private bool _indexHashTableEntriesSet;
        private bool _index2HashTableEntriesSet;

        public DirectoryInfo RootDir { get; }

        public byte CategoryId { get; }

        public int Expansion { get; }

        public int Chunk { get; }

        public PlatformId Platform { get; }

        public SqPackIndex Index { get; }

        // unless assigned, these forward to the index, which only builds its dictionaries on demand
        public Dictionary< UInt64, IndexHashTableEntry >? IndexHashTableEntries
        {
            get => _indexHashTableEntriesSet ? _indexHashTableEntries
                : Index.IsIndex2 ? _indexHashTableEntries ??= new() : Index.HashTableEntries;
            set
            {
                _indexHashTableEntries = value;
                _indexHashTableEntriesSet = true;
            }
        }

        public Dictionary< uint, Index2HashTableEntry >? Index2HashTableEntries
        {
            get => _index2HashTableEntriesSet ? _index2HashTableEntries
                : Index.IsIndex2 ? Index.HashTableEntries2 : null;
            set
            {
                _index2HashTableEntries = value;
                _index2HashTableEntriesSet = true;
            }
        }

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
        }

        public bool FileExists( UInt64 hash ) => TryGetEntry( hash, out _ );

        public bool FileExists( uint hash ) => TryGetEntry( hash, out _ );

        public bool TryGetFileDatOffset( ulong hash, out byte dataFileId, out long offset )
        {
            if( TryGetEntry( hash, out var hashTableEntry ) )
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
            if( TryGetEntry( hash, out var hashTableEntry ) )
            {
                dataFileId = hashTableEntry.DataFileId;
                offset = hashTableEntry.Offset;
                return true;
            }

            dataFileId = 0;
            offset = 0;

            return false;
        }

        private bool TryGetEntry( ulong hash, out IndexHashTableEntry entry )
        {
            if( _indexHashTableEntriesSet )
            {
                if( _indexHashTableEntries is { } dict )
                {
                    return dict.TryGetValue( hash, out entry );
                }

                entry = default;
                return false;
            }

            // index2 categories expose an empty index1 table, which only has entries if a consumer added them
            if( Index.IsIndex2 )
            {
                if( _indexHashTableEntries is { } emptyByDefault )
                {
                    return emptyByDefault.TryGetValue( hash, out entry );
                }

                entry = default;
                return false;
            }

            return Index.TryGetEntry( hash, out entry );
        }

        private bool TryGetEntry( uint hash, out Index2HashTableEntry entry )
        {
            if( _index2HashTableEntriesSet )
            {
                if( _index2HashTableEntries is { } dict )
                {
                    return dict.TryGetValue( hash, out entry );
                }

                entry = default;
                return false;
            }

            if( !Index.IsIndex2 )
            {
                entry = default;
                return false;
            }

            return Index.TryGetEntry( hash, out entry );
        }

        public bool TryGetFileDatOffset( ParsedFilePath path, out byte dataFileId, out long offset )
        {
            if( !Index.IsIndex2 )
            {
                return TryGetFileDatOffset( path.IndexHash, out dataFileId, out offset );
            }

            return TryGetFileDatOffset( path.Index2Hash, out dataFileId, out offset );
        }

        public T? GetFile< T >( ulong hash ) where T : FileResource
        {
            var status = TryGetFileDatOffset( hash, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            return GetFile< T >( dataFileId, offset );
        }

        public T? GetFile< T >( uint hash ) where T : FileResource
        {
            var status = TryGetFileDatOffset( hash, out var dataFileId, out var offset );
            if( !status )
            {
                return null;
            }

            return GetFile< T >( dataFileId, offset );
        }

        public T? GetFile< T >( ParsedFilePath path ) where T : FileResource
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

        public SqPack? GetDat( byte datId )
        {
            return DatFiles.TryGetValue( datId, out var dat ) ? dat : null;
        }

        internal void CloseHandles()
        {
            Index.CloseHandle();
            foreach( var dat in DatFiles.Values )
            {
                dat.CloseHandle();
            }
        }
    }
}