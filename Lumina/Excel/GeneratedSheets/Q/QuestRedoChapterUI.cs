using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUI", columnHash: 0x4d7d2656 )]
    public class QuestRedoChapterUI : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 07 offset: 0000
        public string ChapterName;

        // col: 08 offset: 0004
        public string ChapterPart;

        // col: 09 offset: 0008
        public string Transient;

        // col: 00 offset: 000c
        public uint Quest;

        // col: 04 offset: 0010
        public uint QuestRedoUISmall;

        // col: 05 offset: 0014
        public uint QuestRedoUILarge;

        // col: 06 offset: 0018
        public uint QuestRedoUIWide;

        // col: 01 offset: 001c
        public byte unknown1c;

        // col: 02 offset: 001d
        public byte Category;

        // col: 03 offset: 001e
        public byte unknown1e;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            ChapterName = parser.ReadOffset< string >( 0x0 );

            // col: 8 offset: 0004
            ChapterPart = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            Transient = parser.ReadOffset< string >( 0x8 );

            // col: 0 offset: 000c
            Quest = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            QuestRedoUISmall = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            QuestRedoUILarge = parser.ReadOffset< uint >( 0x14 );

            // col: 6 offset: 0018
            QuestRedoUIWide = parser.ReadOffset< uint >( 0x18 );

            // col: 1 offset: 001c
            unknown1c = parser.ReadOffset< byte >( 0x1c );

            // col: 2 offset: 001d
            Category = parser.ReadOffset< byte >( 0x1d );

            // col: 3 offset: 001e
            unknown1e = parser.ReadOffset< byte >( 0x1e );


        }
    }
}