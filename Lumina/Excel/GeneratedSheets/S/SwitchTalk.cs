using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SwitchTalk", columnHash: 0xc452c850 )]
    public class SwitchTalk : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public uint unknown0;

        // col: 17 offset: 0004
        public uint[] DefaultTalk;

        // col: 49 offset: 0008
        public uint unknown8;

        // col: 33 offset: 000c
        public byte unknownc;

        // col: 02 offset: 0010
        public uint[] Quest;

        // col: 50 offset: 0018
        public uint unknown18;

        // col: 34 offset: 001c
        public byte unknown1c;

        // col: 51 offset: 0028
        public uint unknown28;

        // col: 35 offset: 002c
        public byte unknown2c;

        // col: 52 offset: 0038
        public uint unknown38;

        // col: 36 offset: 003c
        public byte unknown3c;

        // col: 53 offset: 0048
        public uint unknown48;

        // col: 37 offset: 004c
        public byte unknown4c;

        // col: 54 offset: 0058
        public uint unknown58;

        // col: 38 offset: 005c
        public byte unknown5c;

        // col: 55 offset: 0068
        public uint unknown68;

        // col: 39 offset: 006c
        public byte unknown6c;

        // col: 56 offset: 0078
        public uint unknown78;

        // col: 40 offset: 007c
        public byte unknown7c;

        // col: 57 offset: 0088
        public uint unknown88;

        // col: 41 offset: 008c
        public byte unknown8c;

        // col: 58 offset: 0098
        public uint unknown98;

        // col: 42 offset: 009c
        public byte unknown9c;

        // col: 59 offset: 00a8
        public uint unknowna8;

        // col: 43 offset: 00ac
        public byte unknownac;

        // col: 60 offset: 00b8
        public uint unknownb8;

        // col: 44 offset: 00bc
        public byte unknownbc;

        // col: 61 offset: 00c8
        public uint unknownc8;

        // col: 45 offset: 00cc
        public byte unknowncc;

        // col: 62 offset: 00d8
        public uint unknownd8;

        // col: 46 offset: 00dc
        public byte unknowndc;

        // col: 63 offset: 00e8
        public uint unknowne8;

        // col: 47 offset: 00ec
        public byte unknownec;

        // col: 64 offset: 00f8
        public uint unknownf8;

        // col: 48 offset: 00fc
        public byte unknownfc;

        // col: 00 offset: 0100
        public uint unknown100;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 17 offset: 0004
            DefaultTalk = new uint[16];
            DefaultTalk[0] = parser.ReadOffset< uint >( 0x4 );
            DefaultTalk[1] = parser.ReadOffset< uint >( 0x14 );
            DefaultTalk[2] = parser.ReadOffset< uint >( 0x24 );
            DefaultTalk[3] = parser.ReadOffset< uint >( 0x34 );
            DefaultTalk[4] = parser.ReadOffset< uint >( 0x44 );
            DefaultTalk[5] = parser.ReadOffset< uint >( 0x54 );
            DefaultTalk[6] = parser.ReadOffset< uint >( 0x64 );
            DefaultTalk[7] = parser.ReadOffset< uint >( 0x74 );
            DefaultTalk[8] = parser.ReadOffset< uint >( 0x84 );
            DefaultTalk[9] = parser.ReadOffset< uint >( 0x94 );
            DefaultTalk[10] = parser.ReadOffset< uint >( 0xa4 );
            DefaultTalk[11] = parser.ReadOffset< uint >( 0xb4 );
            DefaultTalk[12] = parser.ReadOffset< uint >( 0xc4 );
            DefaultTalk[13] = parser.ReadOffset< uint >( 0xd4 );
            DefaultTalk[14] = parser.ReadOffset< uint >( 0xe4 );
            DefaultTalk[15] = parser.ReadOffset< uint >( 0xf4 );

            // col: 49 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 33 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 2 offset: 0010
            Quest = new uint[15];
            Quest[0] = parser.ReadOffset< uint >( 0x10 );
            Quest[1] = parser.ReadOffset< uint >( 0x20 );
            Quest[2] = parser.ReadOffset< uint >( 0x30 );
            Quest[3] = parser.ReadOffset< uint >( 0x40 );
            Quest[4] = parser.ReadOffset< uint >( 0x50 );
            Quest[5] = parser.ReadOffset< uint >( 0x60 );
            Quest[6] = parser.ReadOffset< uint >( 0x70 );
            Quest[7] = parser.ReadOffset< uint >( 0x80 );
            Quest[8] = parser.ReadOffset< uint >( 0x90 );
            Quest[9] = parser.ReadOffset< uint >( 0xa0 );
            Quest[10] = parser.ReadOffset< uint >( 0xb0 );
            Quest[11] = parser.ReadOffset< uint >( 0xc0 );
            Quest[12] = parser.ReadOffset< uint >( 0xd0 );
            Quest[13] = parser.ReadOffset< uint >( 0xe0 );
            Quest[14] = parser.ReadOffset< uint >( 0xf0 );

            // col: 50 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 34 offset: 001c
            unknown1c = parser.ReadOffset< byte >( 0x1c );

            // col: 51 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 35 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 52 offset: 0038
            unknown38 = parser.ReadOffset< uint >( 0x38 );

            // col: 36 offset: 003c
            unknown3c = parser.ReadOffset< byte >( 0x3c );

            // col: 53 offset: 0048
            unknown48 = parser.ReadOffset< uint >( 0x48 );

            // col: 37 offset: 004c
            unknown4c = parser.ReadOffset< byte >( 0x4c );

            // col: 54 offset: 0058
            unknown58 = parser.ReadOffset< uint >( 0x58 );

            // col: 38 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 55 offset: 0068
            unknown68 = parser.ReadOffset< uint >( 0x68 );

            // col: 39 offset: 006c
            unknown6c = parser.ReadOffset< byte >( 0x6c );

            // col: 56 offset: 0078
            unknown78 = parser.ReadOffset< uint >( 0x78 );

            // col: 40 offset: 007c
            unknown7c = parser.ReadOffset< byte >( 0x7c );

            // col: 57 offset: 0088
            unknown88 = parser.ReadOffset< uint >( 0x88 );

            // col: 41 offset: 008c
            unknown8c = parser.ReadOffset< byte >( 0x8c );

            // col: 58 offset: 0098
            unknown98 = parser.ReadOffset< uint >( 0x98 );

            // col: 42 offset: 009c
            unknown9c = parser.ReadOffset< byte >( 0x9c );

            // col: 59 offset: 00a8
            unknowna8 = parser.ReadOffset< uint >( 0xa8 );

            // col: 43 offset: 00ac
            unknownac = parser.ReadOffset< byte >( 0xac );

            // col: 60 offset: 00b8
            unknownb8 = parser.ReadOffset< uint >( 0xb8 );

            // col: 44 offset: 00bc
            unknownbc = parser.ReadOffset< byte >( 0xbc );

            // col: 61 offset: 00c8
            unknownc8 = parser.ReadOffset< uint >( 0xc8 );

            // col: 45 offset: 00cc
            unknowncc = parser.ReadOffset< byte >( 0xcc );

            // col: 62 offset: 00d8
            unknownd8 = parser.ReadOffset< uint >( 0xd8 );

            // col: 46 offset: 00dc
            unknowndc = parser.ReadOffset< byte >( 0xdc );

            // col: 63 offset: 00e8
            unknowne8 = parser.ReadOffset< uint >( 0xe8 );

            // col: 47 offset: 00ec
            unknownec = parser.ReadOffset< byte >( 0xec );

            // col: 64 offset: 00f8
            unknownf8 = parser.ReadOffset< uint >( 0xf8 );

            // col: 48 offset: 00fc
            unknownfc = parser.ReadOffset< byte >( 0xfc );

            // col: 0 offset: 0100
            unknown100 = parser.ReadOffset< uint >( 0x100 );


        }
    }
}