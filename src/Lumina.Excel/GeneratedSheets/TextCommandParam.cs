// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TextCommandParam", columnHash: 0xdebb20e3 )]
    public partial class TextCommandParam : ExcelRow
    {
        
        public SeString Param { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Param = parser.ReadColumn< SeString >( 0 );
        }
    }
}