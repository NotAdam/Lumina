using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data;
using Lumina.Excel;
using Lumina.Excel.Sheets;

namespace Lumina.Example;

static class Program
{
    private class CustomFileType : FileResource
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

    public static void Main( string[] args )
    {
        var gameData = new GameData( args[ 0 ] );

        // excel reading
        var rawAction = gameData.Excel.GetSheet<RawRow>( Language.English, "Action" );
        foreach( var actionRow in rawAction.Take( 20 ) )
        {
            Console.WriteLine( $"action({actionRow.RowId}) name: {actionRow.ReadStringColumn( 0 )}" );
        }
        
        var zoneSharedGroup = gameData.Excel.GetSubrowSheet< ZoneSharedGroup >();
        var zsgRows = zoneSharedGroup.Take( 5 );

        foreach( var row in zsgRows )
        {
            foreach( var subrow in row )
            {
                Console.WriteLine( $"ZoneSharedGroup({subrow.RowId}.{subrow.SubrowId}) RequirementType[0]: {subrow.RequirementType[0]}, RequirementRow: {subrow.RequirementRow[0].RowId}" );
            }
        }

        // dump conditions
        foreach( var condition in gameData.GetExcelSheet< Condition >() )
        {
            Console.WriteLine( $"condition {condition.RowId:000}: {condition.LogMessage.ValueNullable?.Text}" );
        }
        
        
        // custom data type
        var file = gameData.GetFile< CustomFileType >( "exd/root.exl" );
        file.SaveFile( "root.exl" );

        var aetheryte = file.ExdMap.First( m => m.Key == "Aetheryte" );

        Console.WriteLine( $"aetheryte: id: {aetheryte.Value} name: {aetheryte.Key}" );
    }
}