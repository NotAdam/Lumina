using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Opening", columnHash: 0xdd0fcc95 )]
    public class Opening : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public string unknown0;

        // col: 42 offset: 0004
        public uint unknown4;

        // col: 03 offset: 0008
        public string unknown8;

        // col: 43 offset: 000c
        public uint unknownc;

        // col: 04 offset: 0010
        public string unknown10;

        // col: 44 offset: 0014
        public uint unknown14;

        // col: 05 offset: 0018
        public string unknown18;

        // col: 45 offset: 001c
        public uint unknown1c;

        // col: 06 offset: 0020
        public string unknown20;

        // col: 46 offset: 0024
        public uint unknown24;

        // col: 07 offset: 0028
        public string unknown28;

        // col: 47 offset: 002c
        public uint unknown2c;

        // col: 08 offset: 0030
        public string unknown30;

        // col: 48 offset: 0034
        public uint unknown34;

        // col: 09 offset: 0038
        public string unknown38;

        // col: 49 offset: 003c
        public uint unknown3c;

        // col: 10 offset: 0040
        public string unknown40;

        // col: 50 offset: 0044
        public uint unknown44;

        // col: 11 offset: 0048
        public string unknown48;

        // col: 51 offset: 004c
        public uint unknown4c;

        // col: 12 offset: 0050
        public string unknown50;

        // col: 52 offset: 0054
        public uint unknown54;

        // col: 13 offset: 0058
        public string unknown58;

        // col: 53 offset: 005c
        public uint unknown5c;

        // col: 14 offset: 0060
        public string unknown60;

        // col: 54 offset: 0064
        public uint unknown64;

        // col: 15 offset: 0068
        public string unknown68;

        // col: 55 offset: 006c
        public uint unknown6c;

        // col: 16 offset: 0070
        public string unknown70;

        // col: 56 offset: 0074
        public uint unknown74;

        // col: 17 offset: 0078
        public string unknown78;

        // col: 57 offset: 007c
        public uint unknown7c;

        // col: 18 offset: 0080
        public string unknown80;

        // col: 58 offset: 0084
        public uint unknown84;

        // col: 19 offset: 0088
        public string unknown88;

        // col: 59 offset: 008c
        public uint unknown8c;

        // col: 20 offset: 0090
        public string unknown90;

        // col: 60 offset: 0094
        public uint unknown94;

        // col: 21 offset: 0098
        public string unknown98;

        // col: 61 offset: 009c
        public uint unknown9c;

        // col: 22 offset: 00a0
        public string unknowna0;

        // col: 62 offset: 00a4
        public uint unknowna4;

        // col: 23 offset: 00a8
        public string unknowna8;

        // col: 63 offset: 00ac
        public uint unknownac;

        // col: 24 offset: 00b0
        public string unknownb0;

        // col: 64 offset: 00b4
        public uint unknownb4;

        // col: 25 offset: 00b8
        public string unknownb8;

        // col: 65 offset: 00bc
        public uint unknownbc;

        // col: 26 offset: 00c0
        public string unknownc0;

        // col: 66 offset: 00c4
        public uint unknownc4;

        // col: 27 offset: 00c8
        public string unknownc8;

        // col: 67 offset: 00cc
        public uint unknowncc;

        // col: 28 offset: 00d0
        public string unknownd0;

        // col: 68 offset: 00d4
        public uint unknownd4;

        // col: 29 offset: 00d8
        public string unknownd8;

        // col: 69 offset: 00dc
        public uint unknowndc;

        // col: 30 offset: 00e0
        public string unknowne0;

        // col: 70 offset: 00e4
        public uint unknowne4;

        // col: 31 offset: 00e8
        public string unknowne8;

        // col: 71 offset: 00ec
        public uint unknownec;

        // col: 32 offset: 00f0
        public string unknownf0;

        // col: 72 offset: 00f4
        public uint unknownf4;

        // col: 33 offset: 00f8
        public string unknownf8;

        // col: 73 offset: 00fc
        public uint unknownfc;

        // col: 34 offset: 0100
        public string unknown100;

        // col: 74 offset: 0104
        public uint unknown104;

        // col: 35 offset: 0108
        public string unknown108;

        // col: 75 offset: 010c
        public uint unknown10c;

        // col: 36 offset: 0110
        public string unknown110;

        // col: 76 offset: 0114
        public uint unknown114;

        // col: 37 offset: 0118
        public string unknown118;

        // col: 77 offset: 011c
        public uint unknown11c;

        // col: 38 offset: 0120
        public string unknown120;

        // col: 78 offset: 0124
        public uint unknown124;

        // col: 39 offset: 0128
        public string unknown128;

        // col: 79 offset: 012c
        public uint unknown12c;

        // col: 40 offset: 0130
        public string unknown130;

        // col: 80 offset: 0134
        public uint unknown134;

        // col: 41 offset: 0138
        public string unknown138;

        // col: 81 offset: 013c
        public uint unknown13c;

        // col: 00 offset: 0140
        public string Name;

        // col: 01 offset: 0144
        public uint Quest;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 42 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 43 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            unknown10 = parser.ReadOffset< string >( 0x10 );

            // col: 44 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 5 offset: 0018
            unknown18 = parser.ReadOffset< string >( 0x18 );

            // col: 45 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 6 offset: 0020
            unknown20 = parser.ReadOffset< string >( 0x20 );

            // col: 46 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 7 offset: 0028
            unknown28 = parser.ReadOffset< string >( 0x28 );

            // col: 47 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 8 offset: 0030
            unknown30 = parser.ReadOffset< string >( 0x30 );

            // col: 48 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 9 offset: 0038
            unknown38 = parser.ReadOffset< string >( 0x38 );

            // col: 49 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 10 offset: 0040
            unknown40 = parser.ReadOffset< string >( 0x40 );

            // col: 50 offset: 0044
            unknown44 = parser.ReadOffset< uint >( 0x44 );

            // col: 11 offset: 0048
            unknown48 = parser.ReadOffset< string >( 0x48 );

            // col: 51 offset: 004c
            unknown4c = parser.ReadOffset< uint >( 0x4c );

            // col: 12 offset: 0050
            unknown50 = parser.ReadOffset< string >( 0x50 );

            // col: 52 offset: 0054
            unknown54 = parser.ReadOffset< uint >( 0x54 );

            // col: 13 offset: 0058
            unknown58 = parser.ReadOffset< string >( 0x58 );

            // col: 53 offset: 005c
            unknown5c = parser.ReadOffset< uint >( 0x5c );

            // col: 14 offset: 0060
            unknown60 = parser.ReadOffset< string >( 0x60 );

            // col: 54 offset: 0064
            unknown64 = parser.ReadOffset< uint >( 0x64 );

            // col: 15 offset: 0068
            unknown68 = parser.ReadOffset< string >( 0x68 );

            // col: 55 offset: 006c
            unknown6c = parser.ReadOffset< uint >( 0x6c );

            // col: 16 offset: 0070
            unknown70 = parser.ReadOffset< string >( 0x70 );

            // col: 56 offset: 0074
            unknown74 = parser.ReadOffset< uint >( 0x74 );

            // col: 17 offset: 0078
            unknown78 = parser.ReadOffset< string >( 0x78 );

            // col: 57 offset: 007c
            unknown7c = parser.ReadOffset< uint >( 0x7c );

            // col: 18 offset: 0080
            unknown80 = parser.ReadOffset< string >( 0x80 );

            // col: 58 offset: 0084
            unknown84 = parser.ReadOffset< uint >( 0x84 );

            // col: 19 offset: 0088
            unknown88 = parser.ReadOffset< string >( 0x88 );

            // col: 59 offset: 008c
            unknown8c = parser.ReadOffset< uint >( 0x8c );

            // col: 20 offset: 0090
            unknown90 = parser.ReadOffset< string >( 0x90 );

            // col: 60 offset: 0094
            unknown94 = parser.ReadOffset< uint >( 0x94 );

            // col: 21 offset: 0098
            unknown98 = parser.ReadOffset< string >( 0x98 );

            // col: 61 offset: 009c
            unknown9c = parser.ReadOffset< uint >( 0x9c );

            // col: 22 offset: 00a0
            unknowna0 = parser.ReadOffset< string >( 0xa0 );

            // col: 62 offset: 00a4
            unknowna4 = parser.ReadOffset< uint >( 0xa4 );

            // col: 23 offset: 00a8
            unknowna8 = parser.ReadOffset< string >( 0xa8 );

            // col: 63 offset: 00ac
            unknownac = parser.ReadOffset< uint >( 0xac );

            // col: 24 offset: 00b0
            unknownb0 = parser.ReadOffset< string >( 0xb0 );

            // col: 64 offset: 00b4
            unknownb4 = parser.ReadOffset< uint >( 0xb4 );

            // col: 25 offset: 00b8
            unknownb8 = parser.ReadOffset< string >( 0xb8 );

            // col: 65 offset: 00bc
            unknownbc = parser.ReadOffset< uint >( 0xbc );

            // col: 26 offset: 00c0
            unknownc0 = parser.ReadOffset< string >( 0xc0 );

            // col: 66 offset: 00c4
            unknownc4 = parser.ReadOffset< uint >( 0xc4 );

            // col: 27 offset: 00c8
            unknownc8 = parser.ReadOffset< string >( 0xc8 );

            // col: 67 offset: 00cc
            unknowncc = parser.ReadOffset< uint >( 0xcc );

            // col: 28 offset: 00d0
            unknownd0 = parser.ReadOffset< string >( 0xd0 );

            // col: 68 offset: 00d4
            unknownd4 = parser.ReadOffset< uint >( 0xd4 );

            // col: 29 offset: 00d8
            unknownd8 = parser.ReadOffset< string >( 0xd8 );

            // col: 69 offset: 00dc
            unknowndc = parser.ReadOffset< uint >( 0xdc );

            // col: 30 offset: 00e0
            unknowne0 = parser.ReadOffset< string >( 0xe0 );

            // col: 70 offset: 00e4
            unknowne4 = parser.ReadOffset< uint >( 0xe4 );

            // col: 31 offset: 00e8
            unknowne8 = parser.ReadOffset< string >( 0xe8 );

            // col: 71 offset: 00ec
            unknownec = parser.ReadOffset< uint >( 0xec );

            // col: 32 offset: 00f0
            unknownf0 = parser.ReadOffset< string >( 0xf0 );

            // col: 72 offset: 00f4
            unknownf4 = parser.ReadOffset< uint >( 0xf4 );

            // col: 33 offset: 00f8
            unknownf8 = parser.ReadOffset< string >( 0xf8 );

            // col: 73 offset: 00fc
            unknownfc = parser.ReadOffset< uint >( 0xfc );

            // col: 34 offset: 0100
            unknown100 = parser.ReadOffset< string >( 0x100 );

            // col: 74 offset: 0104
            unknown104 = parser.ReadOffset< uint >( 0x104 );

            // col: 35 offset: 0108
            unknown108 = parser.ReadOffset< string >( 0x108 );

            // col: 75 offset: 010c
            unknown10c = parser.ReadOffset< uint >( 0x10c );

            // col: 36 offset: 0110
            unknown110 = parser.ReadOffset< string >( 0x110 );

            // col: 76 offset: 0114
            unknown114 = parser.ReadOffset< uint >( 0x114 );

            // col: 37 offset: 0118
            unknown118 = parser.ReadOffset< string >( 0x118 );

            // col: 77 offset: 011c
            unknown11c = parser.ReadOffset< uint >( 0x11c );

            // col: 38 offset: 0120
            unknown120 = parser.ReadOffset< string >( 0x120 );

            // col: 78 offset: 0124
            unknown124 = parser.ReadOffset< uint >( 0x124 );

            // col: 39 offset: 0128
            unknown128 = parser.ReadOffset< string >( 0x128 );

            // col: 79 offset: 012c
            unknown12c = parser.ReadOffset< uint >( 0x12c );

            // col: 40 offset: 0130
            unknown130 = parser.ReadOffset< string >( 0x130 );

            // col: 80 offset: 0134
            unknown134 = parser.ReadOffset< uint >( 0x134 );

            // col: 41 offset: 0138
            unknown138 = parser.ReadOffset< string >( 0x138 );

            // col: 81 offset: 013c
            unknown13c = parser.ReadOffset< uint >( 0x13c );

            // col: 0 offset: 0140
            Name = parser.ReadOffset< string >( 0x140 );

            // col: 1 offset: 0144
            Quest = parser.ReadOffset< uint >( 0x144 );


        }
    }
}