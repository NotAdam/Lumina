using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateProgressUI", columnHash: 0x73e43ab7 )]
    public class FateProgressUI : IExcelRow
    {
        
        public LazyRow< TerritoryType > Location;
        public LazyRow< Achievement > Achievement;
        public byte ReqFatesToRank2;
        public byte ReqFatesToRank3;
        public byte DisplayOrder;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< int >( 0 ), language );
            Achievement = new LazyRow< Achievement >( lumina, parser.ReadColumn< int >( 1 ), language );
            ReqFatesToRank2 = parser.ReadColumn< byte >( 2 );
            ReqFatesToRank3 = parser.ReadColumn< byte >( 3 );
            DisplayOrder = parser.ReadColumn< byte >( 4 );
        }
    }
}