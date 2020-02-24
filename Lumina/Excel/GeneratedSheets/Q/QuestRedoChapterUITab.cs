using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUITab", columnHash: 0x198356e8 )]
    public class QuestRedoChapterUITab : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 03 offset: 0000
        public string Text;

        // col: 01 offset: 0004
        public uint Icon1;

        // col: 02 offset: 0008
        public uint Icon2;

        // col: 00 offset: 000c
        public byte unknownc;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon1 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Icon2 = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );


        }
    }
}