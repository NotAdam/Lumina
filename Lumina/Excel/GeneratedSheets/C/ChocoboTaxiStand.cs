namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxiStand", columnHash: 0x233d23d9 )]
    public class ChocoboTaxiStand : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 8
         *  name: PlaceName
         *  type: 
         */



        // col: 08 offset: 0000
        public string PlaceName;

        // col: 00 offset: 0004
        public ushort unknown4;

        // col: 01 offset: 0006
        public ushort unknown6;

        // col: 02 offset: 0008
        public ushort unknown8;

        // col: 03 offset: 000a
        public ushort unknowna;

        // col: 04 offset: 000c
        public ushort unknownc;

        // col: 05 offset: 000e
        public ushort unknowne;

        // col: 06 offset: 0010
        public ushort unknown10;

        // col: 07 offset: 0012
        public ushort unknown12;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            PlaceName = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 5 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 7 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );


        }
    }
}