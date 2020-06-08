using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAethernet", columnHash: 0x751baa92 )]
    public class HousingAethernet : IExcelRow
    {
        
        public LazyRow< Level > Level;
        public LazyRow< TerritoryType > TerritoryType;
        public LazyRow< PlaceName > PlaceName;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Level = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 0 ) );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 1 ) );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 2 ) );
            Order = parser.ReadColumn< byte >( 3 );
        }
    }
}