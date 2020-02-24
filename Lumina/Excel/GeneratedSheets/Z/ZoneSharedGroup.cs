namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ZoneSharedGroup", columnHash: 0x7795f6ea )]
    public class ZoneSharedGroup : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  name: Quest{1}
         *  type: 
         */

        /* offset: 0020 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0043 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 003d col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 6
         *  name: Quest{2}
         *  type: 
         */

        /* offset: 0024 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 003e col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 10
         *  name: Quest{3}
         *  type: 
         */

        /* offset: 0028 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0045 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 003f col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 14
         *  name: Quest{4}
         *  type: 
         */

        /* offset: 002c col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0046 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 18
         *  name: Quest{5}
         *  type: 
         */

        /* offset: 0030 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0047 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0041 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 22
         *  name: Quest{6}
         *  type: 
         */

        /* offset: 0034 col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0048 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0042 col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0049 col: 28
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint unknown0;

        // col: 02 offset: 0004
        public uint Quest1;

        // col: 06 offset: 0008
        public uint Quest2;

        // col: 10 offset: 000c
        public uint Quest3;

        // col: 14 offset: 0010
        public uint Quest4;

        // col: 18 offset: 0014
        public uint Quest5;

        // col: 22 offset: 0018
        public uint Quest6;

        // col: 26 offset: 001c
        public uint unknown1c;

        // col: 03 offset: 0020
        public uint unknown20;

        // col: 07 offset: 0024
        public uint unknown24;

        // col: 11 offset: 0028
        public uint unknown28;

        // col: 15 offset: 002c
        public uint unknown2c;

        // col: 19 offset: 0030
        public uint unknown30;

        // col: 23 offset: 0034
        public uint unknown34;

        // col: 27 offset: 0038
        public uint unknown38;

        // col: 01 offset: 003c
        public byte unknown3c;

        // col: 05 offset: 003d
        public byte unknown3d;

        // col: 09 offset: 003e
        public byte unknown3e;

        // col: 13 offset: 003f
        public byte unknown3f;

        // col: 17 offset: 0040
        public byte unknown40;

        // col: 21 offset: 0041
        public byte unknown41;

        // col: 25 offset: 0042
        public byte unknown42;

        // col: 04 offset: 0043
        public bool unknown43;

        // col: 08 offset: 0044
        public bool unknown44;

        // col: 12 offset: 0045
        public bool unknown45;

        // col: 16 offset: 0046
        public bool unknown46;

        // col: 20 offset: 0047
        public bool unknown47;

        // col: 24 offset: 0048
        public bool unknown48;

        // col: 28 offset: 0049
        public bool unknown49;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Quest1 = parser.ReadOffset< uint >( 0x4 );

            // col: 6 offset: 0008
            Quest2 = parser.ReadOffset< uint >( 0x8 );

            // col: 10 offset: 000c
            Quest3 = parser.ReadOffset< uint >( 0xc );

            // col: 14 offset: 0010
            Quest4 = parser.ReadOffset< uint >( 0x10 );

            // col: 18 offset: 0014
            Quest5 = parser.ReadOffset< uint >( 0x14 );

            // col: 22 offset: 0018
            Quest6 = parser.ReadOffset< uint >( 0x18 );

            // col: 26 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 3 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 7 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 11 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 15 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 19 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 23 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 27 offset: 0038
            unknown38 = parser.ReadOffset< uint >( 0x38 );

            // col: 1 offset: 003c
            unknown3c = parser.ReadOffset< byte >( 0x3c );

            // col: 5 offset: 003d
            unknown3d = parser.ReadOffset< byte >( 0x3d );

            // col: 9 offset: 003e
            unknown3e = parser.ReadOffset< byte >( 0x3e );

            // col: 13 offset: 003f
            unknown3f = parser.ReadOffset< byte >( 0x3f );

            // col: 17 offset: 0040
            unknown40 = parser.ReadOffset< byte >( 0x40 );

            // col: 21 offset: 0041
            unknown41 = parser.ReadOffset< byte >( 0x41 );

            // col: 25 offset: 0042
            unknown42 = parser.ReadOffset< byte >( 0x42 );

            // col: 4 offset: 0043
            unknown43 = parser.ReadOffset< bool >( 0x43 );

            // col: 8 offset: 0044
            unknown44 = parser.ReadOffset< bool >( 0x44 );

            // col: 12 offset: 0045
            unknown45 = parser.ReadOffset< bool >( 0x45 );

            // col: 16 offset: 0046
            unknown46 = parser.ReadOffset< bool >( 0x46 );

            // col: 20 offset: 0047
            unknown47 = parser.ReadOffset< bool >( 0x47 );

            // col: 24 offset: 0048
            unknown48 = parser.ReadOffset< bool >( 0x48 );

            // col: 28 offset: 0049
            unknown49 = parser.ReadOffset< bool >( 0x49 );


        }
    }
}