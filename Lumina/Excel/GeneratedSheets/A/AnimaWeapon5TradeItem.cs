namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5TradeItem", columnHash: 0x40f1e693 )]
    public class AnimaWeapon5TradeItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0024 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: CrystalSand
         *  type: 
         */

        /* offset: 0025 col: 2
         *  name: Qty
         *  type: 
         */

        /* offset: 0004 col: 3
         *  name: 
         *  repeat count: 8
         */

        /* offset: 002f col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0031 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0032 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0029 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0033 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 002a col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 002b col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0035 col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 27
         *  name: Category
         *  type: 
         */



        // col: 01 offset: 0000
        public uint CrystalSand;

        // col: 03 offset: 0004
        public uint[] unknown4;

        // col: 12 offset: 0010
        public uint unknown10;

        // col: 15 offset: 0014
        public uint unknown14;

        // col: 18 offset: 0018
        public uint unknown18;

        // col: 21 offset: 001c
        public uint unknown1c;

        // col: 24 offset: 0020
        public uint unknown20;

        // col: 00 offset: 0024
        public byte unknown24;

        // col: 02 offset: 0025
        public byte Qty;

        // col: 11 offset: 0028
        public byte unknown28;

        // col: 14 offset: 0029
        public byte unknown29;

        // col: 17 offset: 002a
        public byte unknown2a;

        // col: 20 offset: 002b
        public byte unknown2b;

        // col: 23 offset: 002c
        public byte unknown2c;

        // col: 26 offset: 002d
        public byte unknown2d;

        // col: 27 offset: 002e
        public byte Category;

        // col: 13 offset: 0032
        public bool unknown32;

        // col: 16 offset: 0033
        public bool unknown33;

        // col: 19 offset: 0034
        public bool unknown34;

        // col: 22 offset: 0035
        public bool unknown35;

        // col: 25 offset: 0036
        public bool unknown36;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            CrystalSand = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            unknown4 = new uint[8];
            unknown4[0] = parser.ReadOffset< uint >( 0x4 );
            unknown4[1] = parser.ReadOffset< uint >( 0x2f );
            unknown4[2] = parser.ReadOffset< uint >( 0x26 );
            unknown4[3] = parser.ReadOffset< uint >( 0x8 );
            unknown4[4] = parser.ReadOffset< uint >( 0x30 );
            unknown4[5] = parser.ReadOffset< uint >( 0x27 );
            unknown4[6] = parser.ReadOffset< uint >( 0xc );
            unknown4[7] = parser.ReadOffset< uint >( 0x31 );

            // col: 12 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 15 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 18 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 21 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 24 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 0 offset: 0024
            unknown24 = parser.ReadOffset< byte >( 0x24 );

            // col: 2 offset: 0025
            Qty = parser.ReadOffset< byte >( 0x25 );

            // col: 11 offset: 0028
            unknown28 = parser.ReadOffset< byte >( 0x28 );

            // col: 14 offset: 0029
            unknown29 = parser.ReadOffset< byte >( 0x29 );

            // col: 17 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 20 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 23 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 26 offset: 002d
            unknown2d = parser.ReadOffset< byte >( 0x2d );

            // col: 27 offset: 002e
            Category = parser.ReadOffset< byte >( 0x2e );

            // col: 13 offset: 0032
            unknown32 = parser.ReadOffset< bool >( 0x32 );

            // col: 16 offset: 0033
            unknown33 = parser.ReadOffset< bool >( 0x33 );

            // col: 19 offset: 0034
            unknown34 = parser.ReadOffset< bool >( 0x34 );

            // col: 22 offset: 0035
            unknown35 = parser.ReadOffset< bool >( 0x35 );

            // col: 25 offset: 0036
            unknown36 = parser.ReadOffset< bool >( 0x36 );


        }
    }
}