// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChatTransient", columnHash: 0xdebb20e3 )]
    public class QuickChatTransient : ExcelRow
    {
        
        public SeString TextOutput;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            TextOutput = parser.ReadColumn< SeString >( 0 );
        }
    }
}