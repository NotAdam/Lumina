// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureSpot", columnHash: 0x4a63eb8e )]
    public partial class TreasureSpot : ExcelRow
    {
        
        public LazyRow< Level > Location { get; set; }
        public float MapOffsetX { get; set; }
        public float MapOffsetY { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Location = new LazyRow< Level >( gameData, parser.ReadColumn< int >( 0 ), language );
            MapOffsetX = parser.ReadColumn< float >( 1 );
            MapOffsetY = parser.ReadColumn< float >( 2 );
        }
    }
}