// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCShop", columnHash: 0xdd3ff48d )]
    public class GCShop : IExcelRow
    {
        
        public LazyRow< GrandCompany > GrandCompany;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GrandCompany = new LazyRow< GrandCompany >( lumina, parser.ReadColumn< sbyte >( 0 ), language );
        }
    }
}