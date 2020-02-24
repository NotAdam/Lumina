namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRoute", columnHash: 0xd979f0ca )]
    public class GatheringLeveRoute : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: 
         *  repeat count: 12
         */

        /* offset: 0030 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0048 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 004c col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0050 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0054 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0058 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 005c col: 23
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int[] unknown0;

        // col: 12 offset: 0018
        public int unknown18;

        // col: 14 offset: 001c
        public int unknown1c;

        // col: 16 offset: 0020
        public int unknown20;

        // col: 18 offset: 0024
        public int unknown24;

        // col: 20 offset: 0028
        public int unknown28;

        // col: 22 offset: 002c
        public int unknown2c;

        // col: 13 offset: 0048
        public int unknown48;

        // col: 15 offset: 004c
        public int unknown4c;

        // col: 17 offset: 0050
        public int unknown50;

        // col: 19 offset: 0054
        public int unknown54;

        // col: 21 offset: 0058
        public int unknown58;

        // col: 23 offset: 005c
        public int unknown5c;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = new int[12];
            unknown0[0] = parser.ReadOffset< int >( 0x0 );
            unknown0[1] = parser.ReadOffset< int >( 0x30 );
            unknown0[2] = parser.ReadOffset< int >( 0x4 );
            unknown0[3] = parser.ReadOffset< int >( 0x34 );
            unknown0[4] = parser.ReadOffset< int >( 0x8 );
            unknown0[5] = parser.ReadOffset< int >( 0x38 );
            unknown0[6] = parser.ReadOffset< int >( 0xc );
            unknown0[7] = parser.ReadOffset< int >( 0x3c );
            unknown0[8] = parser.ReadOffset< int >( 0x10 );
            unknown0[9] = parser.ReadOffset< int >( 0x40 );
            unknown0[10] = parser.ReadOffset< int >( 0x14 );
            unknown0[11] = parser.ReadOffset< int >( 0x44 );

            // col: 12 offset: 0018
            unknown18 = parser.ReadOffset< int >( 0x18 );

            // col: 14 offset: 001c
            unknown1c = parser.ReadOffset< int >( 0x1c );

            // col: 16 offset: 0020
            unknown20 = parser.ReadOffset< int >( 0x20 );

            // col: 18 offset: 0024
            unknown24 = parser.ReadOffset< int >( 0x24 );

            // col: 20 offset: 0028
            unknown28 = parser.ReadOffset< int >( 0x28 );

            // col: 22 offset: 002c
            unknown2c = parser.ReadOffset< int >( 0x2c );

            // col: 13 offset: 0048
            unknown48 = parser.ReadOffset< int >( 0x48 );

            // col: 15 offset: 004c
            unknown4c = parser.ReadOffset< int >( 0x4c );

            // col: 17 offset: 0050
            unknown50 = parser.ReadOffset< int >( 0x50 );

            // col: 19 offset: 0054
            unknown54 = parser.ReadOffset< int >( 0x54 );

            // col: 21 offset: 0058
            unknown58 = parser.ReadOffset< int >( 0x58 );

            // col: 23 offset: 005c
            unknown5c = parser.ReadOffset< int >( 0x5c );


        }
    }
}