// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WebURL", columnHash: 0xdebb20e3 )]
    public class WebURL : ExcelRow
    {
        
        public SeString URL;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            URL = parser.ReadColumn< SeString >( 0 );
        }
    }
}