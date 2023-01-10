// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BattleLeveRule", columnHash: 0xdebb20e3 )]
    public partial class BattleLeveRule : ExcelRow
    {
        
        public SeString Rule { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Rule = parser.ReadColumn< SeString >( 0 );
        }
    }
}