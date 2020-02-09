using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Lumina.Data.Structs;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Example
{
    class Program
    {
        private class CustomFileType : Data.FileResource
        {
            public Dictionary< string, int > ExdMap;

            public int Version { get; private set; }

            public CustomFileType()
            {
                ExdMap = new Dictionary< string, int >();
            }

            public override void LoadFile()
            {
                Console.WriteLine("loading customfiletype");
                
                // todo: not sure if good idea yet
                using var stream = new MemoryStream( Data, false );
                using var sr = new StreamReader( stream );

                // read version
                var header = sr.ReadLine().Split( ',' );
                if( header[ 0 ] != "EXLT" )
                {
                    throw new Exception( "invalid file format or something :(" );
                }

                Version = int.Parse( header[ 1 ] );

                // read exd mappings
                string row;
                while( ( row = sr.ReadLine() ) != null )
                {
                    var data = row.Split( ',' );
                    var id = int.Parse( data[ 1 ] );

                    ExdMap[ data[ 0 ] ] = id;
                }
            }

            public override void SaveFile( string path )
            {
                Console.WriteLine( $"saving file to path: {path}" );
                base.SaveFile( path );
            }
        }

        static void Main( string[] args )
        {
            var lumina = new Lumina( args[ 0 ] );

            var actionTimeline = lumina.GetExcelSheet< Excel.Generated.ActionTimeline >();

            foreach( var (id, row) in actionTimeline.GetRows() )
            {
                Console.WriteLine( $"timeline name: {row.Name}" );
            }

            // custom data type
            var file = lumina.GetFile< CustomFileType >( "exd/root.exl" );
            file.SaveFile( "root.exl" );
            
            var aetheryte = file.ExdMap.First( m => m.Key == "Aetheryte" );

            Console.WriteLine( $"aetheryte: id: {aetheryte.Value} name: {aetheryte.Key}" );
        }
    }
}