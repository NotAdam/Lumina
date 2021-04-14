using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Lumina.Excel.GeneratedSheets;
using Lumina.Extensions;

namespace Lumina.Example
{
    class Program
    {
        private class CustomFileType : Data.FileResource
        {
            public Dictionary< string, int > ExdMap;

            // ReSharper disable once UnusedAutoPropertyAccessor.Local
            public int Version { get; private set; }

            public CustomFileType()
            {
                ExdMap = new Dictionary< string, int >();
            }

            public override void LoadFile()
            {
                Console.WriteLine( "loading customfiletype" );

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
            var gameData = new GameData( args[ 0 ] );

            typeof( ActionTimeline ).Assembly.RegisterRsvFiles( gameData );

            var logMessage = gameData.GetExcelSheet< LogMessage >();
            var fuckedRow = logMessage.GetRow( 2853 );
            Console.WriteLine(fuckedRow.Text);
            
            // excel reading
            var actionTimeline = gameData.GetExcelSheet< ActionTimeline >();
            var atRows = actionTimeline.Take( 5 );
            
            foreach( var row in atRows )
            {
                Console.WriteLine( $"name: {row.Key}" );
            }
            
            var zoneSharedGroup = gameData.GetExcelSheet< ZoneSharedGroup >();
            var zsgRows = zoneSharedGroup.Take( 5 );
            
            foreach( var row in zsgRows )
            {
                Console.WriteLine( $"ZoneSharedGroup({row.RowId}.{row.SubRowId}) quest1: {row.Quest1}" );
            }
            
            // dump conditions
            foreach( var condition in gameData.GetExcelSheet< Condition >() )
            {
                Console.WriteLine( $"condition {condition.RowId:000}: {condition.LogMessage.Value?.Text}" );
            }
            
            
            // custom data type
            var file = gameData.GetFile< CustomFileType >( "exd/root.exl" );
            file.SaveFile( "root.exl" );

            var aetheryte = file.ExdMap.First( m => m.Key == "Aetheryte" );

            Console.WriteLine( $"aetheryte: id: {aetheryte.Value} name: {aetheryte.Key}" );
        }
    }
}