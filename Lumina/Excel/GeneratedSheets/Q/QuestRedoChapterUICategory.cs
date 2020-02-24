namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUICategory", columnHash: 0x5eb59ccb )]
    public class QuestRedoChapterUICategory : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Expac
         *  type: 
         */



        // col: 01 offset: 0000
        public string Expac;

        // col: 00 offset: 0004
        public byte unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Expac = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}