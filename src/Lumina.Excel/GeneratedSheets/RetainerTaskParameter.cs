// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskParameter", columnHash: 0x4723e1b0 )]
    public partial class RetainerTaskParameter : ExcelRow
    {
        
        public short[] ItemLevelDoW { get; set; }
        public short[] PerceptionDoL { get; set; }
        public short[] PerceptionFSH { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemLevelDoW = new short[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemLevelDoW[ i ] = parser.ReadColumn< short >( 0 + i );
            PerceptionDoL = new short[ 4 ];
            for( var i = 0; i < 4; i++ )
                PerceptionDoL[ i ] = parser.ReadColumn< short >( 4 + i );
            PerceptionFSH = new short[ 4 ];
            for( var i = 0; i < 4; i++ )
                PerceptionFSH[ i ] = parser.ReadColumn< short >( 8 + i );
        }
    }
}