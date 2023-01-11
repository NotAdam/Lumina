// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChatTransient", columnHash: 0xdebb20e3 )]
    public partial class QuickChatTransient : ExcelRow
    {
        
        public SeString TextOutput { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TextOutput = parser.ReadColumn< SeString >( 0 );
        }
    }
}