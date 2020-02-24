namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItemGroup", columnHash: 0xf065e622 )]
    public class LeveRewardItemGroup : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: 
         *  repeat count: 9
         */

        /* offset: 0024 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0025 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 002f col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0031 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0029 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0032 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 002a col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0033 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 002b col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0035 col: 26
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int[] unknown0;

        // col: 09 offset: 000c
        public int unknownc;

        // col: 12 offset: 0010
        public int unknown10;

        // col: 15 offset: 0014
        public int unknown14;

        // col: 18 offset: 0018
        public int unknown18;

        // col: 21 offset: 001c
        public int unknown1c;

        // col: 24 offset: 0020
        public int unknown20;

        // col: 10 offset: 0027
        public byte unknown27;

        // col: 13 offset: 0028
        public byte unknown28;

        // col: 16 offset: 0029
        public byte unknown29;

        // col: 19 offset: 002a
        public byte unknown2a;

        // col: 22 offset: 002b
        public byte unknown2b;

        // col: 25 offset: 002c
        public byte unknown2c;

        // col: 11 offset: 0030
        public bool unknown30;

        // col: 14 offset: 0031
        public bool unknown31;

        // col: 17 offset: 0032
        public bool unknown32;

        // col: 20 offset: 0033
        public bool unknown33;

        // col: 23 offset: 0034
        public bool unknown34;

        // col: 26 offset: 0035
        public bool unknown35;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = new int[9];
            unknown0[0] = parser.ReadOffset< int >( 0x0 );
            unknown0[1] = parser.ReadOffset< int >( 0x24 );
            unknown0[2] = parser.ReadOffset< int >( 0x2d );
            unknown0[3] = parser.ReadOffset< int >( 0x4 );
            unknown0[4] = parser.ReadOffset< int >( 0x25 );
            unknown0[5] = parser.ReadOffset< int >( 0x2e );
            unknown0[6] = parser.ReadOffset< int >( 0x8 );
            unknown0[7] = parser.ReadOffset< int >( 0x26 );
            unknown0[8] = parser.ReadOffset< int >( 0x2f );

            // col: 9 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 12 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 15 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 18 offset: 0018
            unknown18 = parser.ReadOffset< int >( 0x18 );

            // col: 21 offset: 001c
            unknown1c = parser.ReadOffset< int >( 0x1c );

            // col: 24 offset: 0020
            unknown20 = parser.ReadOffset< int >( 0x20 );

            // col: 10 offset: 0027
            unknown27 = parser.ReadOffset< byte >( 0x27 );

            // col: 13 offset: 0028
            unknown28 = parser.ReadOffset< byte >( 0x28 );

            // col: 16 offset: 0029
            unknown29 = parser.ReadOffset< byte >( 0x29 );

            // col: 19 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 22 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 25 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 11 offset: 0030
            unknown30 = parser.ReadOffset< bool >( 0x30 );

            // col: 14 offset: 0031
            unknown31 = parser.ReadOffset< bool >( 0x31 );

            // col: 17 offset: 0032
            unknown32 = parser.ReadOffset< bool >( 0x32 );

            // col: 20 offset: 0033
            unknown33 = parser.ReadOffset< bool >( 0x33 );

            // col: 23 offset: 0034
            unknown34 = parser.ReadOffset< bool >( 0x34 );

            // col: 26 offset: 0035
            unknown35 = parser.ReadOffset< bool >( 0x35 );


        }
    }
}