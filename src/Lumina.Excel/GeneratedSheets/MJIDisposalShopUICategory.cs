// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIDisposalShopUICategory", columnHash: 0xd9d6e4fa )]
    public partial class MJIDisposalShopUICategory : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
        }
    }
}