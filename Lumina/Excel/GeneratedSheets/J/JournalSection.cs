namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalSection", columnHash: 0x9530a4f2 )]
    public class JournalSection : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        private byte packed4;
        public bool packed4_1 => ( packed4 & 0x1 ) == 0x1;
        public bool packed4_2 => ( packed4 & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}