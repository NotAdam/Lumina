// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTutorial", columnHash: 0xef6c7b71 )]
    public partial class ChocoboRaceTutorial : ExcelRow
    {
        
        public LazyRow< NpcYell >[] NpcYell { get; set; }
        public ushort Unknown8 { get; set; }
        public ushort Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NpcYell = new LazyRow< NpcYell >[ 8 ];
            for( var i = 0; i < 8; i++ )
                NpcYell[ i ] = new LazyRow< NpcYell >( gameData, parser.ReadColumn< int >( 0 + i ), language );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
        }
    }
}