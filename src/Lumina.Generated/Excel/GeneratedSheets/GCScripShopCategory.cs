using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopCategory", columnHash: 0x9b330d8a )]
    public class GCScripShopCategory : IExcelRow
    {
        
        public LazyRow< GrandCompany > GrandCompany;
        public sbyte Tier;
        public sbyte SubCategory;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GrandCompany = new LazyRow< GrandCompany >( lumina, parser.ReadColumn< sbyte >( 0 ), language );
            Tier = parser.ReadColumn< sbyte >( 1 );
            SubCategory = parser.ReadColumn< sbyte >( 2 );
        }
    }
}