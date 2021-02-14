// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShopFilterType", columnHash: 0xdebb20e3 )]
    public class DisposalShopFilterType : ExcelRow
    {
        
        public SeString Category;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Category = parser.ReadColumn< SeString >( 0 );
        }
    }
}