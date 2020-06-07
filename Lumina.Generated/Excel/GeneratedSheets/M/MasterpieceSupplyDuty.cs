using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyDuty", columnHash: 0x63eafd84 )]
    public class MasterpieceSupplyDuty : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public uint[] unknown0;

        // col: 14 offset: 0004
        public uint unknown4;

        // col: 25 offset: 0008
        public uint unknown8;

        // col: 36 offset: 000c
        public uint unknownc;

        // col: 47 offset: 0010
        public uint unknown10;

        // col: 58 offset: 0014
        public uint unknown14;

        // col: 69 offset: 0018
        public uint unknown18;

        // col: 80 offset: 001c
        public uint unknown1c;

        // col: 02 offset: 0020
        public ushort RewardCurrency;

        // col: 17 offset: 0024
        public ushort unknown24;

        // col: 28 offset: 0026
        public ushort unknown26;

        // col: 39 offset: 0028
        public ushort unknown28;

        // col: 50 offset: 002a
        public ushort unknown2a;

        // col: 61 offset: 002c
        public ushort unknown2c;

        // col: 72 offset: 002e
        public ushort unknown2e;

        // col: 83 offset: 0030
        public ushort unknown30;

        // col: 18 offset: 0034
        public ushort unknown34;

        // col: 29 offset: 0036
        public ushort unknown36;

        // col: 40 offset: 0038
        public ushort unknown38;

        // col: 51 offset: 003a
        public ushort unknown3a;

        // col: 62 offset: 003c
        public ushort unknown3c;

        // col: 73 offset: 003e
        public ushort unknown3e;

        // col: 84 offset: 0040
        public ushort unknown40;

        // col: 19 offset: 0044
        public ushort unknown44;

        // col: 30 offset: 0046
        public ushort unknown46;

        // col: 41 offset: 0048
        public ushort unknown48;

        // col: 52 offset: 004a
        public ushort unknown4a;

        // col: 63 offset: 004c
        public ushort unknown4c;

        // col: 74 offset: 004e
        public ushort unknown4e;

        // col: 85 offset: 0050
        public ushort unknown50;

        // col: 20 offset: 0054
        public ushort unknown54;

        // col: 31 offset: 0056
        public ushort unknown56;

        // col: 42 offset: 0058
        public ushort unknown58;

        // col: 53 offset: 005a
        public ushort unknown5a;

        // col: 64 offset: 005c
        public ushort unknown5c;

        // col: 75 offset: 005e
        public ushort unknown5e;

        // col: 86 offset: 0060
        public ushort unknown60;

        // col: 21 offset: 0064
        public ushort unknown64;

        // col: 32 offset: 0066
        public ushort unknown66;

        // col: 43 offset: 0068
        public ushort unknown68;

        // col: 54 offset: 006a
        public ushort unknown6a;

        // col: 65 offset: 006c
        public ushort unknown6c;

        // col: 76 offset: 006e
        public ushort unknown6e;

        // col: 87 offset: 0070
        public ushort unknown70;

        // col: 12 offset: 0072
        public ushort unknown72;

        // col: 23 offset: 0074
        public ushort unknown74;

        // col: 34 offset: 0076
        public ushort unknown76;

        // col: 45 offset: 0078
        public ushort unknown78;

        // col: 56 offset: 007a
        public ushort unknown7a;

        // col: 67 offset: 007c
        public ushort unknown7c;

        // col: 78 offset: 007e
        public ushort unknown7e;

        // col: 89 offset: 0080
        public ushort unknown80;

        // col: 00 offset: 0082
        public byte ClassJob;

        // col: 01 offset: 0083
        public byte ClassJobLevel;

        // col: 15 offset: 0085
        public byte unknown85;

        // col: 26 offset: 0086
        public byte unknown86;

        // col: 37 offset: 0087
        public byte unknown87;

        // col: 48 offset: 0088
        public byte unknown88;

        // col: 59 offset: 0089
        public byte unknown89;

        // col: 70 offset: 008a
        public byte unknown8a;

        // col: 81 offset: 008b
        public byte unknown8b;

        // col: 11 offset: 008c
        public byte unknown8c;

        // col: 22 offset: 008d
        public byte unknown8d;

        // col: 33 offset: 008e
        public byte unknown8e;

        // col: 44 offset: 008f
        public byte unknown8f;

        // col: 55 offset: 0090
        public byte unknown90;

        // col: 66 offset: 0091
        public byte unknown91;

        // col: 77 offset: 0092
        public byte unknown92;

        // col: 88 offset: 0093
        public byte unknown93;

        // col: 13 offset: 0094
        public byte unknown94;

        // col: 24 offset: 0095
        public byte unknown95;

        // col: 35 offset: 0096
        public byte unknown96;

        // col: 46 offset: 0097
        public byte unknown97;

        // col: 57 offset: 0098
        public byte unknown98;

        // col: 68 offset: 0099
        public byte unknown99;

        // col: 79 offset: 009a
        public byte unknown9a;

        // col: 90 offset: 009b
        public byte unknown9b;

        // col: 16 offset: 009d
        public bool unknown9d;

        // col: 27 offset: 009e
        public bool unknown9e;

        // col: 38 offset: 009f
        public bool unknown9f;

        // col: 49 offset: 00a0
        public bool unknowna0;

        // col: 60 offset: 00a1
        public bool unknowna1;

        // col: 71 offset: 00a2
        public bool unknowna2;

        // col: 82 offset: 00a3
        public bool unknowna3;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            unknown0 = new uint[8];
            unknown0[0] = parser.ReadOffset< uint >( 0x0 );
            unknown0[1] = parser.ReadOffset< uint >( 0x84 );
            unknown0[2] = parser.ReadOffset< uint >( 0x9c );
            unknown0[3] = parser.ReadOffset< uint >( 0x22 );
            unknown0[4] = parser.ReadOffset< uint >( 0x32 );
            unknown0[5] = parser.ReadOffset< uint >( 0x42 );
            unknown0[6] = parser.ReadOffset< uint >( 0x52 );
            unknown0[7] = parser.ReadOffset< uint >( 0x62 );

            // col: 14 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 25 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 36 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 47 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 58 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 69 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 80 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 2 offset: 0020
            RewardCurrency = parser.ReadOffset< ushort >( 0x20 );

            // col: 17 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 28 offset: 0026
            unknown26 = parser.ReadOffset< ushort >( 0x26 );

            // col: 39 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 50 offset: 002a
            unknown2a = parser.ReadOffset< ushort >( 0x2a );

            // col: 61 offset: 002c
            unknown2c = parser.ReadOffset< ushort >( 0x2c );

            // col: 72 offset: 002e
            unknown2e = parser.ReadOffset< ushort >( 0x2e );

            // col: 83 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 18 offset: 0034
            unknown34 = parser.ReadOffset< ushort >( 0x34 );

            // col: 29 offset: 0036
            unknown36 = parser.ReadOffset< ushort >( 0x36 );

            // col: 40 offset: 0038
            unknown38 = parser.ReadOffset< ushort >( 0x38 );

            // col: 51 offset: 003a
            unknown3a = parser.ReadOffset< ushort >( 0x3a );

            // col: 62 offset: 003c
            unknown3c = parser.ReadOffset< ushort >( 0x3c );

            // col: 73 offset: 003e
            unknown3e = parser.ReadOffset< ushort >( 0x3e );

            // col: 84 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 19 offset: 0044
            unknown44 = parser.ReadOffset< ushort >( 0x44 );

            // col: 30 offset: 0046
            unknown46 = parser.ReadOffset< ushort >( 0x46 );

            // col: 41 offset: 0048
            unknown48 = parser.ReadOffset< ushort >( 0x48 );

            // col: 52 offset: 004a
            unknown4a = parser.ReadOffset< ushort >( 0x4a );

            // col: 63 offset: 004c
            unknown4c = parser.ReadOffset< ushort >( 0x4c );

            // col: 74 offset: 004e
            unknown4e = parser.ReadOffset< ushort >( 0x4e );

            // col: 85 offset: 0050
            unknown50 = parser.ReadOffset< ushort >( 0x50 );

            // col: 20 offset: 0054
            unknown54 = parser.ReadOffset< ushort >( 0x54 );

            // col: 31 offset: 0056
            unknown56 = parser.ReadOffset< ushort >( 0x56 );

            // col: 42 offset: 0058
            unknown58 = parser.ReadOffset< ushort >( 0x58 );

            // col: 53 offset: 005a
            unknown5a = parser.ReadOffset< ushort >( 0x5a );

            // col: 64 offset: 005c
            unknown5c = parser.ReadOffset< ushort >( 0x5c );

            // col: 75 offset: 005e
            unknown5e = parser.ReadOffset< ushort >( 0x5e );

            // col: 86 offset: 0060
            unknown60 = parser.ReadOffset< ushort >( 0x60 );

            // col: 21 offset: 0064
            unknown64 = parser.ReadOffset< ushort >( 0x64 );

            // col: 32 offset: 0066
            unknown66 = parser.ReadOffset< ushort >( 0x66 );

            // col: 43 offset: 0068
            unknown68 = parser.ReadOffset< ushort >( 0x68 );

            // col: 54 offset: 006a
            unknown6a = parser.ReadOffset< ushort >( 0x6a );

            // col: 65 offset: 006c
            unknown6c = parser.ReadOffset< ushort >( 0x6c );

            // col: 76 offset: 006e
            unknown6e = parser.ReadOffset< ushort >( 0x6e );

            // col: 87 offset: 0070
            unknown70 = parser.ReadOffset< ushort >( 0x70 );

            // col: 12 offset: 0072
            unknown72 = parser.ReadOffset< ushort >( 0x72 );

            // col: 23 offset: 0074
            unknown74 = parser.ReadOffset< ushort >( 0x74 );

            // col: 34 offset: 0076
            unknown76 = parser.ReadOffset< ushort >( 0x76 );

            // col: 45 offset: 0078
            unknown78 = parser.ReadOffset< ushort >( 0x78 );

            // col: 56 offset: 007a
            unknown7a = parser.ReadOffset< ushort >( 0x7a );

            // col: 67 offset: 007c
            unknown7c = parser.ReadOffset< ushort >( 0x7c );

            // col: 78 offset: 007e
            unknown7e = parser.ReadOffset< ushort >( 0x7e );

            // col: 89 offset: 0080
            unknown80 = parser.ReadOffset< ushort >( 0x80 );

            // col: 0 offset: 0082
            ClassJob = parser.ReadOffset< byte >( 0x82 );

            // col: 1 offset: 0083
            ClassJobLevel = parser.ReadOffset< byte >( 0x83 );

            // col: 15 offset: 0085
            unknown85 = parser.ReadOffset< byte >( 0x85 );

            // col: 26 offset: 0086
            unknown86 = parser.ReadOffset< byte >( 0x86 );

            // col: 37 offset: 0087
            unknown87 = parser.ReadOffset< byte >( 0x87 );

            // col: 48 offset: 0088
            unknown88 = parser.ReadOffset< byte >( 0x88 );

            // col: 59 offset: 0089
            unknown89 = parser.ReadOffset< byte >( 0x89 );

            // col: 70 offset: 008a
            unknown8a = parser.ReadOffset< byte >( 0x8a );

            // col: 81 offset: 008b
            unknown8b = parser.ReadOffset< byte >( 0x8b );

            // col: 11 offset: 008c
            unknown8c = parser.ReadOffset< byte >( 0x8c );

            // col: 22 offset: 008d
            unknown8d = parser.ReadOffset< byte >( 0x8d );

            // col: 33 offset: 008e
            unknown8e = parser.ReadOffset< byte >( 0x8e );

            // col: 44 offset: 008f
            unknown8f = parser.ReadOffset< byte >( 0x8f );

            // col: 55 offset: 0090
            unknown90 = parser.ReadOffset< byte >( 0x90 );

            // col: 66 offset: 0091
            unknown91 = parser.ReadOffset< byte >( 0x91 );

            // col: 77 offset: 0092
            unknown92 = parser.ReadOffset< byte >( 0x92 );

            // col: 88 offset: 0093
            unknown93 = parser.ReadOffset< byte >( 0x93 );

            // col: 13 offset: 0094
            unknown94 = parser.ReadOffset< byte >( 0x94 );

            // col: 24 offset: 0095
            unknown95 = parser.ReadOffset< byte >( 0x95 );

            // col: 35 offset: 0096
            unknown96 = parser.ReadOffset< byte >( 0x96 );

            // col: 46 offset: 0097
            unknown97 = parser.ReadOffset< byte >( 0x97 );

            // col: 57 offset: 0098
            unknown98 = parser.ReadOffset< byte >( 0x98 );

            // col: 68 offset: 0099
            unknown99 = parser.ReadOffset< byte >( 0x99 );

            // col: 79 offset: 009a
            unknown9a = parser.ReadOffset< byte >( 0x9a );

            // col: 90 offset: 009b
            unknown9b = parser.ReadOffset< byte >( 0x9b );

            // col: 16 offset: 009d
            unknown9d = parser.ReadOffset< bool >( 0x9d );

            // col: 27 offset: 009e
            unknown9e = parser.ReadOffset< bool >( 0x9e );

            // col: 38 offset: 009f
            unknown9f = parser.ReadOffset< bool >( 0x9f );

            // col: 49 offset: 00a0
            unknowna0 = parser.ReadOffset< bool >( 0xa0 );

            // col: 60 offset: 00a1
            unknowna1 = parser.ReadOffset< bool >( 0xa1 );

            // col: 71 offset: 00a2
            unknowna2 = parser.ReadOffset< bool >( 0xa2 );

            // col: 82 offset: 00a3
            unknowna3 = parser.ReadOffset< bool >( 0xa3 );


        }
    }
}