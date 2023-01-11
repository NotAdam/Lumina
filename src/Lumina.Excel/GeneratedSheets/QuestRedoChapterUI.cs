// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUI", columnHash: 0x15fc8e10 )]
    public partial class QuestRedoChapterUI : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public uint Unknown1 { get; set; }
        public LazyRow< QuestRedoChapterUITab > UITab { get; set; }
        public LazyRow< QuestRedoChapterUICategory > Category { get; set; }
        public byte Unknown4 { get; set; }
        public uint QuestRedoUISmall { get; set; }
        public uint QuestRedoUILarge { get; set; }
        public uint QuestRedoUIWide { get; set; }
        public SeString ChapterName { get; set; }
        public SeString ChapterPart { get; set; }
        public SeString Transient { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            UITab = new LazyRow< QuestRedoChapterUITab >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Category = new LazyRow< QuestRedoChapterUICategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            QuestRedoUISmall = parser.ReadColumn< uint >( 5 );
            QuestRedoUILarge = parser.ReadColumn< uint >( 6 );
            QuestRedoUIWide = parser.ReadColumn< uint >( 7 );
            ChapterName = parser.ReadColumn< SeString >( 8 );
            ChapterPart = parser.ReadColumn< SeString >( 9 );
            Transient = parser.ReadColumn< SeString >( 10 );
        }
    }
}