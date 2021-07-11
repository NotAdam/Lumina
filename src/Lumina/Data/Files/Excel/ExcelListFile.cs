using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Data.Attributes;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina.Data.Files.Excel
{
    [FileExtension( ".exl" )]
    public class ExcelListFile : FileResource
    {
        public readonly Dictionary< string, int > ExdMap;

        public int Version { get; private set; }

        public const string FileMagic = "EXLT";

        public ExcelListFile()
        {
            ExdMap = new Dictionary< string, int >();
        }

        public override void LoadFile()
        {
            using var sr = new StreamReader( FileStream );

            // read version
            var headerStr = sr.ReadLine();

            if( headerStr == null )
            {
                throw new InvalidOperationException( "EXL file header missing/invalid file contents." );
            }

            var headerData = headerStr.Split( ',' );

            var header = headerData[ 0 ];
            if( header != FileMagic )
            {
                throw new InvalidOperationException( $"Invalid file header, got {header}, expected {FileMagic}!" );
            }

            Version = int.Parse( headerData[ 1 ] );

            // read exd mappings
            string? row;
            while( ( row = sr.ReadLine() ) != null )
            {
                if( row.Length == 0 )
                {
                    continue;
                }
                
                // ignore commented rows - thanks SE
                if( row[ 0 ] == '#' )
                {
                    continue;
                }
                
                var data = row.Split( ',' );
                var id = int.Parse( data[ 1 ] );

                ExdMap[ data[ 0 ] ] = id;
            }

            FileStream.Position = 0;
        }
    }
}