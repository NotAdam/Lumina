using Lumina.Excel.CustomSheets;

namespace Lumina.Excel.GeneratedSheets
{
    public partial class Quest
    {
        public ExcelSheet< QuestDialogueText > GetDialogueText()
        {
            var path = $"quest/{(RowId & 0xFFFF) / 100:000}/{Id}";

            return _gameData?.Excel.GetSheet< QuestDialogueText >( SheetLanguage, path );
        }
    }
}