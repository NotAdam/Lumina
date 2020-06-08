using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDSpot", columnHash: 0x96a22aea )]
    public class IKDSpot : IExcelRow
    {
        
        public LazyRow< FishingSpot > SpotMain;
        public LazyRow< FishingSpot > SpotSub;
        public LazyRow< PlaceName > PlaceName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            SpotMain = new LazyRow< FishingSpot >( lumina, parser.ReadColumn< uint >( 0 ) );
            SpotSub = new LazyRow< FishingSpot >( lumina, parser.ReadColumn< uint >( 1 ) );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< uint >( 2 ) );
        }
    }
}