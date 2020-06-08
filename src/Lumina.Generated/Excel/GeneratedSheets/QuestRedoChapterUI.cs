using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUI", columnHash: 0x4d7d2656 )]
    public class QuestRedoChapterUI : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public byte Unknown1;
        public LazyRow< QuestRedoChapterUICategory > Category;
        public byte Unknown3;
        public uint QuestRedoUISmall;
        public uint QuestRedoUILarge;
        public uint QuestRedoUIWide;
        public string ChapterName;
        public string ChapterPart;
        public string Transient;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ) );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Category = new LazyRow< QuestRedoChapterUICategory >( lumina, parser.ReadColumn< byte >( 2 ) );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            QuestRedoUISmall = parser.ReadColumn< uint >( 4 );
            QuestRedoUILarge = parser.ReadColumn< uint >( 5 );
            QuestRedoUIWide = parser.ReadColumn< uint >( 6 );
            ChapterName = parser.ReadColumn< string >( 7 );
            ChapterPart = parser.ReadColumn< string >( 8 );
            Transient = parser.ReadColumn< string >( 9 );
        }
    }
}