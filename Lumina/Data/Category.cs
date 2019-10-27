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
        public DirectoryInfo RootDir { get; private set; }

        public byte CategoryId { get; }

        public int Expansion { get; }

        public int Chunk { get; }

        public Structs.PlatformId Platform { get; }

        public SqPackIndex SqPackIndex { get; }

        public Dictionary< byte, SqPack > DatFiles { get; internal set; }

        public Category(
            byte category,
            int expansion,
            int chunk,
            PlatformId platform,
            SqPackIndex sqPackIndex,
            DirectoryInfo rootDir )
        {
            CategoryId = category;
            Expansion = expansion;
            Chunk = chunk;
            Platform = platform;
            SqPackIndex = sqPackIndex;
            RootDir = rootDir;

            DatFiles = new Dictionary< byte, SqPack >();

            // init dats
            for( byte id = 0; id < SqPackIndex.IndexHeader.number_of_data_file; id++ )
            {
                var datName = Repository.BuildDatStr( CategoryId, Expansion, Chunk, Platform, $"dat{id}" );

                var path = Path.Combine( RootDir.FullName, datName );

                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    DatFiles[ id ] = new SqPack( fileInfo );
                }
            }
        }

        public FileResource GetFile( UInt64 hash, uint sectionId = 0 )
        {
            var status = SqPackIndex.HashTableEntries.TryGetValue( hash, out var hashTableEntry );

            if( !status )
            {
                return null;
            }

            // get dat
            var dat = DatFiles[ hashTableEntry.DataFileId ];
            
            var file = dat.ReadFile( hashTableEntry.Offset, sectionId );

            return file;
        }

        public SqPack GetDat( byte datId )
        {
            return DatFiles.TryGetValue( datId, out var dat ) ? dat : null;
        }
    }
}