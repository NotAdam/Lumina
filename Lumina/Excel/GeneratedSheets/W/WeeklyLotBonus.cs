using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyLotBonus", columnHash: 0x7a4c70a0 )]
    public class WeeklyLotBonus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 32 offset: 0000
        public ushort unknown0;

        // col: 00 offset: 0002
        public byte[] WeeklyLotBonusThreshold;

        // col: 64 offset: 0003
        public byte unknown3;

        // col: 33 offset: 0004
        public ushort unknown4;

        // col: 65 offset: 0007
        public byte unknown7;

        // col: 34 offset: 0008
        public ushort unknown8;

        // col: 66 offset: 000b
        public byte unknownb;

        // col: 35 offset: 000c
        public ushort unknownc;

        // col: 67 offset: 000f
        public byte unknownf;

        // col: 36 offset: 0010
        public ushort unknown10;

        // col: 68 offset: 0013
        public byte unknown13;

        // col: 37 offset: 0014
        public ushort unknown14;

        // col: 69 offset: 0017
        public byte unknown17;

        // col: 38 offset: 0018
        public ushort unknown18;

        // col: 70 offset: 001b
        public byte unknown1b;

        // col: 39 offset: 001c
        public ushort unknown1c;

        // col: 71 offset: 001f
        public byte unknown1f;

        // col: 40 offset: 0020
        public ushort unknown20;

        // col: 72 offset: 0023
        public byte unknown23;

        // col: 41 offset: 0024
        public ushort unknown24;

        // col: 73 offset: 0027
        public byte unknown27;

        // col: 42 offset: 0028
        public ushort unknown28;

        // col: 74 offset: 002b
        public byte unknown2b;

        // col: 43 offset: 002c
        public ushort unknown2c;

        // col: 75 offset: 002f
        public byte unknown2f;

        // col: 44 offset: 0030
        public ushort unknown30;

        // col: 76 offset: 0033
        public byte unknown33;

        // col: 45 offset: 0034
        public ushort unknown34;

        // col: 77 offset: 0037
        public byte unknown37;

        // col: 46 offset: 0038
        public ushort unknown38;

        // col: 78 offset: 003b
        public byte unknown3b;

        // col: 47 offset: 003c
        public ushort unknown3c;

        // col: 79 offset: 003f
        public byte unknown3f;

        // col: 48 offset: 0040
        public ushort unknown40;

        // col: 80 offset: 0043
        public byte unknown43;

        // col: 49 offset: 0044
        public ushort unknown44;

        // col: 81 offset: 0047
        public byte unknown47;

        // col: 50 offset: 0048
        public ushort unknown48;

        // col: 82 offset: 004b
        public byte unknown4b;

        // col: 51 offset: 004c
        public ushort unknown4c;

        // col: 83 offset: 004f
        public byte unknown4f;

        // col: 52 offset: 0050
        public ushort unknown50;

        // col: 84 offset: 0053
        public byte unknown53;

        // col: 53 offset: 0054
        public ushort unknown54;

        // col: 85 offset: 0057
        public byte unknown57;

        // col: 54 offset: 0058
        public ushort unknown58;

        // col: 86 offset: 005b
        public byte unknown5b;

        // col: 55 offset: 005c
        public ushort unknown5c;

        // col: 87 offset: 005f
        public byte unknown5f;

        // col: 56 offset: 0060
        public ushort unknown60;

        // col: 88 offset: 0063
        public byte unknown63;

        // col: 57 offset: 0064
        public ushort unknown64;

        // col: 89 offset: 0067
        public byte unknown67;

        // col: 58 offset: 0068
        public ushort unknown68;

        // col: 90 offset: 006b
        public byte unknown6b;

        // col: 59 offset: 006c
        public ushort unknown6c;

        // col: 91 offset: 006f
        public byte unknown6f;

        // col: 60 offset: 0070
        public ushort unknown70;

        // col: 92 offset: 0073
        public byte unknown73;

        // col: 61 offset: 0074
        public ushort unknown74;

        // col: 93 offset: 0077
        public byte unknown77;

        // col: 62 offset: 0078
        public ushort unknown78;

        // col: 94 offset: 007b
        public byte unknown7b;

        // col: 63 offset: 007c
        public ushort unknown7c;

        // col: 31 offset: 007e
        public byte unknown7e;

        // col: 95 offset: 007f
        public byte unknown7f;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 32 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 0 offset: 0002
            WeeklyLotBonusThreshold = new byte[31];
            WeeklyLotBonusThreshold[0] = parser.ReadOffset< byte >( 0x2 );
            WeeklyLotBonusThreshold[1] = parser.ReadOffset< byte >( 0x6 );
            WeeklyLotBonusThreshold[2] = parser.ReadOffset< byte >( 0xa );
            WeeklyLotBonusThreshold[3] = parser.ReadOffset< byte >( 0xe );
            WeeklyLotBonusThreshold[4] = parser.ReadOffset< byte >( 0x12 );
            WeeklyLotBonusThreshold[5] = parser.ReadOffset< byte >( 0x16 );
            WeeklyLotBonusThreshold[6] = parser.ReadOffset< byte >( 0x1a );
            WeeklyLotBonusThreshold[7] = parser.ReadOffset< byte >( 0x1e );
            WeeklyLotBonusThreshold[8] = parser.ReadOffset< byte >( 0x22 );
            WeeklyLotBonusThreshold[9] = parser.ReadOffset< byte >( 0x26 );
            WeeklyLotBonusThreshold[10] = parser.ReadOffset< byte >( 0x2a );
            WeeklyLotBonusThreshold[11] = parser.ReadOffset< byte >( 0x2e );
            WeeklyLotBonusThreshold[12] = parser.ReadOffset< byte >( 0x32 );
            WeeklyLotBonusThreshold[13] = parser.ReadOffset< byte >( 0x36 );
            WeeklyLotBonusThreshold[14] = parser.ReadOffset< byte >( 0x3a );
            WeeklyLotBonusThreshold[15] = parser.ReadOffset< byte >( 0x3e );
            WeeklyLotBonusThreshold[16] = parser.ReadOffset< byte >( 0x42 );
            WeeklyLotBonusThreshold[17] = parser.ReadOffset< byte >( 0x46 );
            WeeklyLotBonusThreshold[18] = parser.ReadOffset< byte >( 0x4a );
            WeeklyLotBonusThreshold[19] = parser.ReadOffset< byte >( 0x4e );
            WeeklyLotBonusThreshold[20] = parser.ReadOffset< byte >( 0x52 );
            WeeklyLotBonusThreshold[21] = parser.ReadOffset< byte >( 0x56 );
            WeeklyLotBonusThreshold[22] = parser.ReadOffset< byte >( 0x5a );
            WeeklyLotBonusThreshold[23] = parser.ReadOffset< byte >( 0x5e );
            WeeklyLotBonusThreshold[24] = parser.ReadOffset< byte >( 0x62 );
            WeeklyLotBonusThreshold[25] = parser.ReadOffset< byte >( 0x66 );
            WeeklyLotBonusThreshold[26] = parser.ReadOffset< byte >( 0x6a );
            WeeklyLotBonusThreshold[27] = parser.ReadOffset< byte >( 0x6e );
            WeeklyLotBonusThreshold[28] = parser.ReadOffset< byte >( 0x72 );
            WeeklyLotBonusThreshold[29] = parser.ReadOffset< byte >( 0x76 );
            WeeklyLotBonusThreshold[30] = parser.ReadOffset< byte >( 0x7a );

            // col: 64 offset: 0003
            unknown3 = parser.ReadOffset< byte >( 0x3 );

            // col: 33 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 65 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 34 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 66 offset: 000b
            unknownb = parser.ReadOffset< byte >( 0xb );

            // col: 35 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 67 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 36 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 68 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 37 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 69 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 38 offset: 0018
            unknown18 = parser.ReadOffset< ushort >( 0x18 );

            // col: 70 offset: 001b
            unknown1b = parser.ReadOffset< byte >( 0x1b );

            // col: 39 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 71 offset: 001f
            unknown1f = parser.ReadOffset< byte >( 0x1f );

            // col: 40 offset: 0020
            unknown20 = parser.ReadOffset< ushort >( 0x20 );

            // col: 72 offset: 0023
            unknown23 = parser.ReadOffset< byte >( 0x23 );

            // col: 41 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 73 offset: 0027
            unknown27 = parser.ReadOffset< byte >( 0x27 );

            // col: 42 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 74 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 43 offset: 002c
            unknown2c = parser.ReadOffset< ushort >( 0x2c );

            // col: 75 offset: 002f
            unknown2f = parser.ReadOffset< byte >( 0x2f );

            // col: 44 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 76 offset: 0033
            unknown33 = parser.ReadOffset< byte >( 0x33 );

            // col: 45 offset: 0034
            unknown34 = parser.ReadOffset< ushort >( 0x34 );

            // col: 77 offset: 0037
            unknown37 = parser.ReadOffset< byte >( 0x37 );

            // col: 46 offset: 0038
            unknown38 = parser.ReadOffset< ushort >( 0x38 );

            // col: 78 offset: 003b
            unknown3b = parser.ReadOffset< byte >( 0x3b );

            // col: 47 offset: 003c
            unknown3c = parser.ReadOffset< ushort >( 0x3c );

            // col: 79 offset: 003f
            unknown3f = parser.ReadOffset< byte >( 0x3f );

            // col: 48 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 80 offset: 0043
            unknown43 = parser.ReadOffset< byte >( 0x43 );

            // col: 49 offset: 0044
            unknown44 = parser.ReadOffset< ushort >( 0x44 );

            // col: 81 offset: 0047
            unknown47 = parser.ReadOffset< byte >( 0x47 );

            // col: 50 offset: 0048
            unknown48 = parser.ReadOffset< ushort >( 0x48 );

            // col: 82 offset: 004b
            unknown4b = parser.ReadOffset< byte >( 0x4b );

            // col: 51 offset: 004c
            unknown4c = parser.ReadOffset< ushort >( 0x4c );

            // col: 83 offset: 004f
            unknown4f = parser.ReadOffset< byte >( 0x4f );

            // col: 52 offset: 0050
            unknown50 = parser.ReadOffset< ushort >( 0x50 );

            // col: 84 offset: 0053
            unknown53 = parser.ReadOffset< byte >( 0x53 );

            // col: 53 offset: 0054
            unknown54 = parser.ReadOffset< ushort >( 0x54 );

            // col: 85 offset: 0057
            unknown57 = parser.ReadOffset< byte >( 0x57 );

            // col: 54 offset: 0058
            unknown58 = parser.ReadOffset< ushort >( 0x58 );

            // col: 86 offset: 005b
            unknown5b = parser.ReadOffset< byte >( 0x5b );

            // col: 55 offset: 005c
            unknown5c = parser.ReadOffset< ushort >( 0x5c );

            // col: 87 offset: 005f
            unknown5f = parser.ReadOffset< byte >( 0x5f );

            // col: 56 offset: 0060
            unknown60 = parser.ReadOffset< ushort >( 0x60 );

            // col: 88 offset: 0063
            unknown63 = parser.ReadOffset< byte >( 0x63 );

            // col: 57 offset: 0064
            unknown64 = parser.ReadOffset< ushort >( 0x64 );

            // col: 89 offset: 0067
            unknown67 = parser.ReadOffset< byte >( 0x67 );

            // col: 58 offset: 0068
            unknown68 = parser.ReadOffset< ushort >( 0x68 );

            // col: 90 offset: 006b
            unknown6b = parser.ReadOffset< byte >( 0x6b );

            // col: 59 offset: 006c
            unknown6c = parser.ReadOffset< ushort >( 0x6c );

            // col: 91 offset: 006f
            unknown6f = parser.ReadOffset< byte >( 0x6f );

            // col: 60 offset: 0070
            unknown70 = parser.ReadOffset< ushort >( 0x70 );

            // col: 92 offset: 0073
            unknown73 = parser.ReadOffset< byte >( 0x73 );

            // col: 61 offset: 0074
            unknown74 = parser.ReadOffset< ushort >( 0x74 );

            // col: 93 offset: 0077
            unknown77 = parser.ReadOffset< byte >( 0x77 );

            // col: 62 offset: 0078
            unknown78 = parser.ReadOffset< ushort >( 0x78 );

            // col: 94 offset: 007b
            unknown7b = parser.ReadOffset< byte >( 0x7b );

            // col: 63 offset: 007c
            unknown7c = parser.ReadOffset< ushort >( 0x7c );

            // col: 31 offset: 007e
            unknown7e = parser.ReadOffset< byte >( 0x7e );

            // col: 95 offset: 007f
            unknown7f = parser.ReadOffset< byte >( 0x7f );


        }
    }
}