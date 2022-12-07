using Lumina.Data;
using Lumina.Text;

namespace Lumina.Excel.CustomSheets
{
    public class QuestDialogueText : ExcelRow
    {
        public string Key { get; set; }
        public SeString Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );
            
            Key = parser.ReadColumn< string >( 0 );
            Value = parser.ReadColumn< SeString >( 1 );
        }
    }
}