namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherRate", columnHash: 0x474abce2 )]
    public class WeatherRate : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: 
         *  repeat count: 8
         */

        /* offset: 0020 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0021 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0023 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0025 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 15
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int[] unknown0;

        // col: 08 offset: 0010
        public int unknown10;

        // col: 10 offset: 0014
        public int unknown14;

        // col: 12 offset: 0018
        public int unknown18;

        // col: 14 offset: 001c
        public int unknown1c;

        // col: 09 offset: 0024
        public byte unknown24;

        // col: 11 offset: 0025
        public byte unknown25;

        // col: 13 offset: 0026
        public byte unknown26;

        // col: 15 offset: 0027
        public byte unknown27;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = new int[8];
            unknown0[0] = parser.ReadOffset< int >( 0x0 );
            unknown0[1] = parser.ReadOffset< int >( 0x20 );
            unknown0[2] = parser.ReadOffset< int >( 0x4 );
            unknown0[3] = parser.ReadOffset< int >( 0x21 );
            unknown0[4] = parser.ReadOffset< int >( 0x8 );
            unknown0[5] = parser.ReadOffset< int >( 0x22 );
            unknown0[6] = parser.ReadOffset< int >( 0xc );
            unknown0[7] = parser.ReadOffset< int >( 0x23 );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 10 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 12 offset: 0018
            unknown18 = parser.ReadOffset< int >( 0x18 );

            // col: 14 offset: 001c
            unknown1c = parser.ReadOffset< int >( 0x1c );

            // col: 9 offset: 0024
            unknown24 = parser.ReadOffset< byte >( 0x24 );

            // col: 11 offset: 0025
            unknown25 = parser.ReadOffset< byte >( 0x25 );

            // col: 13 offset: 0026
            unknown26 = parser.ReadOffset< byte >( 0x26 );

            // col: 15 offset: 0027
            unknown27 = parser.ReadOffset< byte >( 0x27 );


        }
    }
}