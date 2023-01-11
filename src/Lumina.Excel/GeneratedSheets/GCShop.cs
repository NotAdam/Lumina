// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCShop", columnHash: 0xdd3ff48d )]
    public partial class GCShop : ExcelRow
    {
        
        public LazyRow< GrandCompany > GrandCompany { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadColumn< sbyte >( 0 ), language );
        }
    }
}