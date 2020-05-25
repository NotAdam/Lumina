using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BaseParam", columnHash: 0xedef6dbb )]
    public class BaseParam : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


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
        public bool packed2c_1;
        public byte packed2c;


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
            packed2c = parser.ReadOffset< byte >( 0x2c, ExcelColumnDataType.UInt8 );

            packed2c_1 = ( packed2c & 0x1 ) == 0x1;


        }
    }
}