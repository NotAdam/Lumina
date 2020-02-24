namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogKind", columnHash: 0x23b962ed )]
    public class LogKind : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT

        /* offset: 0004 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Format
         *  type: 
         */

        /* offset: 0005 col: 2
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public string Format;

        // col: 00 offset: 0004
        public byte unknown4;

        // col: 02 offset: 0005
        private byte packed5;
        public bool packed5_1 => ( packed5 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Format = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5 );


        }
    }
}