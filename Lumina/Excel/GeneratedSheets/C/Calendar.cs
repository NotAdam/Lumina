namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Calendar", columnHash: 0x005cfabb )]
    public class Calendar : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Month
         *  repeat count: 32
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
         *  no SaintCoinach definition found
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

        /* offset: 0018 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 001e col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 002a col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0032 col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 003a col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 30
         *  no SaintCoinach definition found
         */

        /* offset: 003e col: 31
         *  no SaintCoinach definition found
         */

        /* offset: 0001 col: 32
         *  name: Day
         *  repeat count: 32
         */

        /* offset: 0003 col: 33
         *  no SaintCoinach definition found
         */

        /* offset: 0005 col: 34
         *  no SaintCoinach definition found
         */

        /* offset: 0007 col: 35
         *  no SaintCoinach definition found
         */

        /* offset: 0009 col: 36
         *  no SaintCoinach definition found
         */

        /* offset: 000b col: 37
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 38
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 39
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 40
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 41
         *  no SaintCoinach definition found
         */

        /* offset: 0015 col: 42
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 43
         *  no SaintCoinach definition found
         */

        /* offset: 0019 col: 44
         *  no SaintCoinach definition found
         */

        /* offset: 001b col: 45
         *  no SaintCoinach definition found
         */

        /* offset: 001d col: 46
         *  no SaintCoinach definition found
         */

        /* offset: 001f col: 47
         *  no SaintCoinach definition found
         */

        /* offset: 0021 col: 48
         *  no SaintCoinach definition found
         */

        /* offset: 0023 col: 49
         *  no SaintCoinach definition found
         */

        /* offset: 0025 col: 50
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 51
         *  no SaintCoinach definition found
         */

        /* offset: 0029 col: 52
         *  no SaintCoinach definition found
         */

        /* offset: 002b col: 53
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 54
         *  no SaintCoinach definition found
         */

        /* offset: 002f col: 55
         *  no SaintCoinach definition found
         */

        /* offset: 0031 col: 56
         *  no SaintCoinach definition found
         */

        /* offset: 0033 col: 57
         *  no SaintCoinach definition found
         */

        /* offset: 0035 col: 58
         *  no SaintCoinach definition found
         */

        /* offset: 0037 col: 59
         *  no SaintCoinach definition found
         */

        /* offset: 0039 col: 60
         *  no SaintCoinach definition found
         */

        /* offset: 003b col: 61
         *  no SaintCoinach definition found
         */

        /* offset: 003d col: 62
         *  no SaintCoinach definition found
         */

        /* offset: 003f col: 63
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public byte[] Month;

        // col: 32 offset: 0001
        public byte[] Day;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Month = new byte[32];
            Month[0] = parser.ReadOffset< byte >( 0x0 );
            Month[1] = parser.ReadOffset< byte >( 0x2 );
            Month[2] = parser.ReadOffset< byte >( 0x4 );
            Month[3] = parser.ReadOffset< byte >( 0x6 );
            Month[4] = parser.ReadOffset< byte >( 0x8 );
            Month[5] = parser.ReadOffset< byte >( 0xa );
            Month[6] = parser.ReadOffset< byte >( 0xc );
            Month[7] = parser.ReadOffset< byte >( 0xe );
            Month[8] = parser.ReadOffset< byte >( 0x10 );
            Month[9] = parser.ReadOffset< byte >( 0x12 );
            Month[10] = parser.ReadOffset< byte >( 0x14 );
            Month[11] = parser.ReadOffset< byte >( 0x16 );
            Month[12] = parser.ReadOffset< byte >( 0x18 );
            Month[13] = parser.ReadOffset< byte >( 0x1a );
            Month[14] = parser.ReadOffset< byte >( 0x1c );
            Month[15] = parser.ReadOffset< byte >( 0x1e );
            Month[16] = parser.ReadOffset< byte >( 0x20 );
            Month[17] = parser.ReadOffset< byte >( 0x22 );
            Month[18] = parser.ReadOffset< byte >( 0x24 );
            Month[19] = parser.ReadOffset< byte >( 0x26 );
            Month[20] = parser.ReadOffset< byte >( 0x28 );
            Month[21] = parser.ReadOffset< byte >( 0x2a );
            Month[22] = parser.ReadOffset< byte >( 0x2c );
            Month[23] = parser.ReadOffset< byte >( 0x2e );
            Month[24] = parser.ReadOffset< byte >( 0x30 );
            Month[25] = parser.ReadOffset< byte >( 0x32 );
            Month[26] = parser.ReadOffset< byte >( 0x34 );
            Month[27] = parser.ReadOffset< byte >( 0x36 );
            Month[28] = parser.ReadOffset< byte >( 0x38 );
            Month[29] = parser.ReadOffset< byte >( 0x3a );
            Month[30] = parser.ReadOffset< byte >( 0x3c );
            Month[31] = parser.ReadOffset< byte >( 0x3e );

            // col: 32 offset: 0001
            Day = new byte[32];
            Day[0] = parser.ReadOffset< byte >( 0x1 );
            Day[1] = parser.ReadOffset< byte >( 0x3 );
            Day[2] = parser.ReadOffset< byte >( 0x5 );
            Day[3] = parser.ReadOffset< byte >( 0x7 );
            Day[4] = parser.ReadOffset< byte >( 0x9 );
            Day[5] = parser.ReadOffset< byte >( 0xb );
            Day[6] = parser.ReadOffset< byte >( 0xd );
            Day[7] = parser.ReadOffset< byte >( 0xf );
            Day[8] = parser.ReadOffset< byte >( 0x11 );
            Day[9] = parser.ReadOffset< byte >( 0x13 );
            Day[10] = parser.ReadOffset< byte >( 0x15 );
            Day[11] = parser.ReadOffset< byte >( 0x17 );
            Day[12] = parser.ReadOffset< byte >( 0x19 );
            Day[13] = parser.ReadOffset< byte >( 0x1b );
            Day[14] = parser.ReadOffset< byte >( 0x1d );
            Day[15] = parser.ReadOffset< byte >( 0x1f );
            Day[16] = parser.ReadOffset< byte >( 0x21 );
            Day[17] = parser.ReadOffset< byte >( 0x23 );
            Day[18] = parser.ReadOffset< byte >( 0x25 );
            Day[19] = parser.ReadOffset< byte >( 0x27 );
            Day[20] = parser.ReadOffset< byte >( 0x29 );
            Day[21] = parser.ReadOffset< byte >( 0x2b );
            Day[22] = parser.ReadOffset< byte >( 0x2d );
            Day[23] = parser.ReadOffset< byte >( 0x2f );
            Day[24] = parser.ReadOffset< byte >( 0x31 );
            Day[25] = parser.ReadOffset< byte >( 0x33 );
            Day[26] = parser.ReadOffset< byte >( 0x35 );
            Day[27] = parser.ReadOffset< byte >( 0x37 );
            Day[28] = parser.ReadOffset< byte >( 0x39 );
            Day[29] = parser.ReadOffset< byte >( 0x3b );
            Day[30] = parser.ReadOffset< byte >( 0x3d );
            Day[31] = parser.ReadOffset< byte >( 0x3f );


        }
    }
}