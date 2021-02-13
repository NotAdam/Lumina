// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRule", columnHash: 0xdebb20e3 )]
    public class GatheringLeveRule : ExcelRow
    {
        
        public SeString Rule;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Rule = parser.ReadColumn< SeString >( 0 );
        }
    }
}