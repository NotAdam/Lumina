namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BaseParam", columnHash: 0xedef6dbb )]
    public class BaseParam : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 002b col: 0
         *  name: PacketIndex
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Description
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: OrderPriority
         *  type: 
         */

        /* offset: 0009 col: 4
         *  name: 1HWpn%
         *  type: 
         */

        /* offset: 000a col: 5
         *  name: OH<%>
         *  type: 
         */

        /* offset: 000b col: 6
         *  name: Head<%>
         *  type: 
         */

        /* offset: 000c col: 7
         *  name: Chest<%>
         *  type: 
         */

        /* offset: 000d col: 8
         *  name: Hands<%>
         *  type: 
         */

        /* offset: 000e col: 9
         *  name: Waist<%>
         *  type: 
         */

        /* offset: 000f col: 10
         *  name: Legs<%>
         *  type: 
         */

        /* offset: 0010 col: 11
         *  name: Feet<%>
         *  type: 
         */

        /* offset: 0011 col: 12
         *  name: Earring<%>
         *  type: 
         */

        /* offset: 0012 col: 13
         *  name: Necklace<%>
         *  type: 
         */

        /* offset: 0013 col: 14
         *  name: Bracelet<%>
         *  type: 
         */

        /* offset: 0014 col: 15
         *  name: Ring<%>
         *  type: 
         */

        /* offset: 0015 col: 16
         *  name: 2HWpn<%>
         *  type: 
         */

        /* offset: 0016 col: 17
         *  name: UnderArmor<%>
         *  type: 
         */

        /* offset: 0017 col: 18
         *  name: ChestHead<%>
         *  type: 
         */

        /* offset: 0018 col: 19
         *  name: ChestHeadLegsFeet<%>
         *  type: 
         */

        /* offset: 0019 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 21
         *  name: LegsFeet<%>
         *  type: 
         */

        /* offset: 001b col: 22
         *  name: HeadChestHandsLegsFeet<%>
         *  type: 
         */

        /* offset: 001c col: 23
         *  name: ChestLegsGloves<%>
         *  type: 
         */

        /* offset: 001d col: 24
         *  name: ChestLegsFeet<%>
         *  type: 
         */

        /* offset: 001e col: 25
         *  name: MeldParam
         *  repeat count: 13
         */

        /* offset: 001f col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0021 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0023 col: 30
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 31
         *  no SaintCoinach definition found
         */

        /* offset: 0025 col: 32
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 33
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 34
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 35
         *  no SaintCoinach definition found
         */

        /* offset: 0029 col: 36
         *  no SaintCoinach definition found
         */

        /* offset: 002a col: 37
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 38
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string Description;

        // col: 03 offset: 0008
        public byte OrderPriority;

        // col: 04 offset: 0009
        public byte oneHWpnPct;

        // col: 05 offset: 000a
        public byte OHPct;

        // col: 06 offset: 000b
        public byte HeadPct;

        // col: 07 offset: 000c
        public byte ChestPct;

        // col: 08 offset: 000d
        public byte HandsPct;

        // col: 09 offset: 000e
        public byte WaistPct;

        // col: 10 offset: 000f
        public byte LegsPct;

        // col: 11 offset: 0010
        public byte FeetPct;

        // col: 12 offset: 0011
        public byte EarringPct;

        // col: 13 offset: 0012
        public byte NecklacePct;

        // col: 14 offset: 0013
        public byte BraceletPct;

        // col: 15 offset: 0014
        public byte RingPct;

        // col: 16 offset: 0015
        public byte twoHWpnPct;

        // col: 17 offset: 0016
        public byte UnderArmorPct;

        // col: 18 offset: 0017
        public byte ChestHeadPct;

        // col: 19 offset: 0018
        public byte ChestHeadLegsFeetPct;

        // col: 20 offset: 0019
        public byte unknown19;

        // col: 21 offset: 001a
        public byte LegsFeetPct;

        // col: 22 offset: 001b
        public byte HeadChestHandsLegsFeetPct;

        // col: 23 offset: 001c
        public byte ChestLegsGlovesPct;

        // col: 24 offset: 001d
        public byte ChestLegsFeetPct;

        // col: 25 offset: 001e
        public byte[] MeldParam;

        // col: 00 offset: 002b
        public sbyte PacketIndex;

        // col: 38 offset: 002c
        private byte packed2c;
        public bool packed2c_1 => ( packed2c & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            OrderPriority = parser.ReadOffset< byte >( 0x8 );

            // col: 4 offset: 0009
            oneHWpnPct = parser.ReadOffset< byte >( 0x9 );

            // col: 5 offset: 000a
            OHPct = parser.ReadOffset< byte >( 0xa );

            // col: 6 offset: 000b
            HeadPct = parser.ReadOffset< byte >( 0xb );

            // col: 7 offset: 000c
            ChestPct = parser.ReadOffset< byte >( 0xc );

            // col: 8 offset: 000d
            HandsPct = parser.ReadOffset< byte >( 0xd );

            // col: 9 offset: 000e
            WaistPct = parser.ReadOffset< byte >( 0xe );

            // col: 10 offset: 000f
            LegsPct = parser.ReadOffset< byte >( 0xf );

            // col: 11 offset: 0010
            FeetPct = parser.ReadOffset< byte >( 0x10 );

            // col: 12 offset: 0011
            EarringPct = parser.ReadOffset< byte >( 0x11 );

            // col: 13 offset: 0012
            NecklacePct = parser.ReadOffset< byte >( 0x12 );

            // col: 14 offset: 0013
            BraceletPct = parser.ReadOffset< byte >( 0x13 );

            // col: 15 offset: 0014
            RingPct = parser.ReadOffset< byte >( 0x14 );

            // col: 16 offset: 0015
            twoHWpnPct = parser.ReadOffset< byte >( 0x15 );

            // col: 17 offset: 0016
            UnderArmorPct = parser.ReadOffset< byte >( 0x16 );

            // col: 18 offset: 0017
            ChestHeadPct = parser.ReadOffset< byte >( 0x17 );

            // col: 19 offset: 0018
            ChestHeadLegsFeetPct = parser.ReadOffset< byte >( 0x18 );

            // col: 20 offset: 0019
            unknown19 = parser.ReadOffset< byte >( 0x19 );

            // col: 21 offset: 001a
            LegsFeetPct = parser.ReadOffset< byte >( 0x1a );

            // col: 22 offset: 001b
            HeadChestHandsLegsFeetPct = parser.ReadOffset< byte >( 0x1b );

            // col: 23 offset: 001c
            ChestLegsGlovesPct = parser.ReadOffset< byte >( 0x1c );

            // col: 24 offset: 001d
            ChestLegsFeetPct = parser.ReadOffset< byte >( 0x1d );

            // col: 25 offset: 001e
            MeldParam = new byte[13];
            MeldParam[0] = parser.ReadOffset< byte >( 0x1e );
            MeldParam[1] = parser.ReadOffset< byte >( 0x1f );
            MeldParam[2] = parser.ReadOffset< byte >( 0x20 );
            MeldParam[3] = parser.ReadOffset< byte >( 0x21 );
            MeldParam[4] = parser.ReadOffset< byte >( 0x22 );
            MeldParam[5] = parser.ReadOffset< byte >( 0x23 );
            MeldParam[6] = parser.ReadOffset< byte >( 0x24 );
            MeldParam[7] = parser.ReadOffset< byte >( 0x25 );
            MeldParam[8] = parser.ReadOffset< byte >( 0x26 );
            MeldParam[9] = parser.ReadOffset< byte >( 0x27 );
            MeldParam[10] = parser.ReadOffset< byte >( 0x28 );
            MeldParam[11] = parser.ReadOffset< byte >( 0x29 );
            MeldParam[12] = parser.ReadOffset< byte >( 0x2a );

            // col: 0 offset: 002b
            PacketIndex = parser.ReadOffset< sbyte >( 0x2b );

            // col: 38 offset: 002c
            packed2c = parser.ReadOffset< byte >( 0x2c );


        }
    }
}