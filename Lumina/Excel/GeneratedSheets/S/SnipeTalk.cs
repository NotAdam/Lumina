namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SnipeTalk", columnHash: 0xcea69cac )]
    public class SnipeTalk : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT

        /* offset: 000e col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 2
         *  name: Name
         *  type: 
         */

        /* offset: 0000 col: 3
         *  name: Text
         *  type: 
         */

        /* offset: 0004 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 5
         *  no SaintCoinach definition found
         */



        // col: 03 offset: 0000
        public string Text;

        // col: 04 offset: 0004
        public string unknown4;

        // col: 05 offset: 0008
        public string unknown8;

        // col: 02 offset: 000c
        public ushort Name;

        // col: 00 offset: 000e
        public byte unknowne;

        // col: 01 offset: 000f
        public byte unknownf;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 2 offset: 000c
            Name = parser.ReadOffset< ushort >( 0xc );

            // col: 0 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 1 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );


        }
    }
}