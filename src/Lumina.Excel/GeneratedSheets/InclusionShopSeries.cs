// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShopSeries", columnHash: 0xdbf43666 )]
    public class InclusionShopSeries : IExcelRow
    {
        
        public LazyRow< SpecialShop > SpecialShop;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            SpecialShop = new LazyRow< SpecialShop >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}