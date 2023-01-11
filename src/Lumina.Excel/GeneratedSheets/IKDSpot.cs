// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDSpot", columnHash: 0x96a22aea )]
    public partial class IKDSpot : ExcelRow
    {
        
        public LazyRow< FishingSpot > SpotMain { get; set; }
        public LazyRow< FishingSpot > SpotSub { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SpotMain = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< uint >( 0 ), language );
            SpotSub = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< uint >( 1 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}