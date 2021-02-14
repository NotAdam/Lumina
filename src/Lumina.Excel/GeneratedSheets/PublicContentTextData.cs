// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentTextData", columnHash: 0xdebb20e3 )]
    public class PublicContentTextData : ExcelRow
    {
        
        public SeString TextData;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            TextData = parser.ReadColumn< SeString >( 0 );
        }
    }
}