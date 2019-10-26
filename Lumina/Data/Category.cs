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

        public Dictionary< byte, FileInfo > DatFiles { get; internal set; }

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

            DatFiles = new Dictionary< byte, FileInfo >();
            
            // init dats
            for( byte id = 0; id < SqPackIndex.IndexHeader.number_of_data_file; id++ )
            {
                var datName = Repository.BuildDatStr( CategoryId, Expansion, Chunk, Platform, $"dat{id}" );

                var path = Path.Combine( RootDir.FullName, datName );
            
                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    DatFiles[ id ] = fileInfo;
                }
            }
        }

        public FileResource GetFile( UInt64 hash )
        {
            var status = SqPackIndex.HashTableEntries.TryGetValue( hash, out var hashTableEntry );

            if( !status )
            {
                return null;
            }

            return new FileResource( this, hashTableEntry );
        }

        public FileInfo GetDat( byte datId )
        {
            return DatFiles.TryGetValue( datId, out var dat ) ? dat : null;
        }
    }
}