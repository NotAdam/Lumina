// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDSpot", columnHash: 0x96a22aea )]
    public class IKDSpot : ExcelRow
    {
        
        public LazyRow< FishingSpot > SpotMain;
        public LazyRow< FishingSpot > SpotSub;
        public LazyRow< PlaceName > PlaceName;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            SpotMain = new LazyRow< FishingSpot >( lumina, parser.ReadColumn< uint >( 0 ), language );
            SpotSub = new LazyRow< FishingSpot >( lumina, parser.ReadColumn< uint >( 1 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}