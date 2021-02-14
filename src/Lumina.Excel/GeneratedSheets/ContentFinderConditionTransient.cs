// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderConditionTransient", columnHash: 0xdebb20e3 )]
    public class ContentFinderConditionTransient : ExcelRow
    {
        
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Description = parser.ReadColumn< SeString >( 0 );
        }
    }
}