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
        public short[] GatheringDoL { get; set; }
        public short[] GatheringFSH { get; set; }
        public short Unknown6 { get; set; }
        public short Unknown7 { get; set; }
        public short Unknown8 { get; set; }
        public short Unknown9 { get; set; }
        public short Unknown10 { get; set; }
        public short Unknown11 { get; set; }
        
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
            Unknown6 = parser.ReadColumn< short >( 6 );
            Unknown7 = parser.ReadColumn< short >( 7 );
            Unknown8 = parser.ReadColumn< short >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Unknown10 = parser.ReadColumn< short >( 10 );
            Unknown11 = parser.ReadColumn< short >( 11 );
        }
    }
}