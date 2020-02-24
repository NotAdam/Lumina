namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyMultiplier", columnHash: 0x1b64fcf8 )]
    public class MasterpieceSupplyMultiplier : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: XpMultiplier
         *  repeat count: 2
         */

        /* offset: 0002 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  name: CurrencyMultiplier
         *  repeat count: 2
         */

        /* offset: 000a col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 11
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public ushort[] XpMultiplier;

        // col: 02 offset: 0004
        public ushort unknown4;

        // col: 03 offset: 0006
        public ushort unknown6;

        // col: 04 offset: 0008
        public ushort[] CurrencyMultiplier;

        // col: 06 offset: 000c
        public ushort unknownc;

        // col: 07 offset: 000e
        public ushort unknowne;

        // col: 08 offset: 0010
        public ushort unknown10;

        // col: 09 offset: 0012
        public ushort unknown12;

        // col: 10 offset: 0014
        public ushort unknown14;

        // col: 11 offset: 0016
        public ushort unknown16;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            XpMultiplier = new ushort[2];
            XpMultiplier[0] = parser.ReadOffset< ushort >( 0x0 );
            XpMultiplier[1] = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            CurrencyMultiplier = new ushort[2];
            CurrencyMultiplier[0] = parser.ReadOffset< ushort >( 0x8 );
            CurrencyMultiplier[1] = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 10 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 11 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );


        }
    }
}