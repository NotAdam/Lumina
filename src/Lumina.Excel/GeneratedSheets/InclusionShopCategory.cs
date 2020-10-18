// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShopCategory", columnHash: 0x3b24d05f )]
    public class InclusionShopCategory : IExcelRow
    {
        
        public SeString Name;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public LazyRow< InclusionShopSeries > InclusionShopSeries;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            InclusionShopSeries = new LazyRow< InclusionShopSeries >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}