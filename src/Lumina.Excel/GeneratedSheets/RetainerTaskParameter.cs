// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskParameter", columnHash: 0xcbd32284 )]
    public partial class RetainerTaskParameter : ExcelRow
    {
        
        public short[] ItemLevelDoW { get; set; }
        public short[] GatheringDoL { get; set; }
        public short[] GatheringFSH { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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