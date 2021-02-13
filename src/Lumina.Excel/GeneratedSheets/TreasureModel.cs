// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureModel", columnHash: 0xdebb20e3 )]
    public class TreasureModel : ExcelRow
    {
        
        public SeString Path;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Path = parser.ReadColumn< SeString >( 0 );
        }
    }
}