// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleType", columnHash: 0xdebb20e3 )]
    public class HWDInfoBoardArticleType : ExcelRow
    {
        
        public SeString Type;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< SeString >( 0 );
        }
    }
}