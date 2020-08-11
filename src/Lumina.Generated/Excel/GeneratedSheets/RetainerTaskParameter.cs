// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskParameter", columnHash: 0xcbd32284 )]
    public class RetainerTaskParameter : IExcelRow
    {
        
        public short[] ItemLevelDoW;
        public short[] GatheringDoL;
        public short[] GatheringFSH;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemLevelDoW = new short[ 2 ];
            for( var i = 0; i < 2; i++ )
                ItemLevelDoW[ i ] = parser.ReadColumn< short >( 0 + i );
            GatheringDoL = new short[ 2 ];
            for( var i = 0; i < 2; i++ )
                GatheringDoL[ i ] = parser.ReadColumn< short >( 2 + i );
            GatheringFSH = new short[ 2 ];
            for( var i = 0; i < 2; i++ )
                GatheringFSH[ i ] = parser.ReadColumn< short >( 4 + i );
        }
    }
}