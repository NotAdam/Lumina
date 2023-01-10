// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIDisposalShopUICategory", columnHash: 0xdebb20e3 )]
    public partial class MJIDisposalShopUICategory : ExcelRow
    {
        
        public SeString Category { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< SeString >( 0 );
        }
    }
}