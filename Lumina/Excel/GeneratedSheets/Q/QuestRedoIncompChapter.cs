namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoIncompChapter", columnHash: 0xd870e208 )]
    public class QuestRedoIncompChapter : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Chapter
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort Chapter;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Chapter = parser.ReadOffset< ushort >( 0x0 );


        }
    }
}