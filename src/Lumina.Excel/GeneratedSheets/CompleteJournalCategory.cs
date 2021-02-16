// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompleteJournalCategory", columnHash: 0x976040dd )]
    public class CompleteJournalCategory : ExcelRow
    {
        
        public LazyRow< CompleteJournal > FirstQuest;
        public LazyRow< CompleteJournal > LastQuest;
        public int Unknown2;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FirstQuest = new LazyRow< CompleteJournal >( gameData, parser.ReadColumn< uint >( 0 ), language );
            LastQuest = new LazyRow< CompleteJournal >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< int >( 2 );
        }
    }
}