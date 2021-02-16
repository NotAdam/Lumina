// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUICategory", columnHash: 0x5eb59ccb )]
    public class QuestRedoChapterUICategory : ExcelRow
    {
        
        public byte Unknown0;
        public SeString Expac;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Expac = parser.ReadColumn< SeString >( 1 );
        }
    }
}