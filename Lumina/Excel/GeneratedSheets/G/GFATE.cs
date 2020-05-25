using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFATE", columnHash: 0x87eccd15 )]
    public class GFATE : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 07 offset: 0000
        public uint unknown0;

        // col: 39 offset: 0008
        public bool packed8_1;
        public byte packed8;
        public bool packed8_2;
        public bool packed8_4;

        // col: 08 offset: 000c
        public uint unknownc;

        // col: 40 offset: 0014
        public bool packed14_1;
        public byte packed14;
        public bool packed14_2;
        public bool packed14_4;

        // col: 09 offset: 0018
        public uint unknown18;

        // col: 41 offset: 0020
        public bool packed20_1;
        public byte packed20;
        public bool packed20_2;
        public bool packed20_4;

        // col: 10 offset: 0024
        public uint unknown24;

        // col: 42 offset: 002c
        public bool packed2c_1;
        public byte packed2c;
        public bool packed2c_2;
        public bool packed2c_4;

        // col: 11 offset: 0030
        public uint unknown30;

        // col: 43 offset: 0038
        public bool packed38_1;
        public byte packed38;
        public bool packed38_2;
        public bool packed38_4;

        // col: 12 offset: 003c
        public uint unknown3c;

        // col: 44 offset: 0044
        public bool packed44_1;
        public byte packed44;
        public bool packed44_2;
        public bool packed44_4;

        // col: 13 offset: 0048
        public uint unknown48;

        // col: 45 offset: 0050
        public bool packed50_1;
        public byte packed50;
        public bool packed50_2;
        public bool packed50_4;

        // col: 14 offset: 0054
        public uint unknown54;

        // col: 46 offset: 005c
        public bool packed5c_1;
        public byte packed5c;
        public bool packed5c_2;
        public bool packed5c_4;

        // col: 15 offset: 0060
        public uint unknown60;

        // col: 47 offset: 0068
        public bool packed68_1;
        public byte packed68;
        public bool packed68_2;
        public bool packed68_4;

        // col: 16 offset: 006c
        public uint unknown6c;

        // col: 48 offset: 0074
        public bool packed74_1;
        public byte packed74;
        public bool packed74_2;
        public bool packed74_4;

        // col: 17 offset: 0078
        public uint unknown78;

        // col: 49 offset: 0080
        public bool packed80_1;
        public byte packed80;
        public bool packed80_2;
        public bool packed80_4;

        // col: 18 offset: 0084
        public uint unknown84;

        // col: 50 offset: 008c
        public bool packed8c_1;
        public byte packed8c;
        public bool packed8c_2;
        public bool packed8c_4;

        // col: 19 offset: 0090
        public uint unknown90;

        // col: 51 offset: 0098
        public bool packed98_1;
        public byte packed98;
        public bool packed98_2;
        public bool packed98_4;

        // col: 20 offset: 009c
        public uint unknown9c;

        // col: 52 offset: 00a4
        public bool packeda4_1;
        public byte packeda4;
        public bool packeda4_2;
        public bool packeda4_4;

        // col: 21 offset: 00a8
        public uint unknowna8;

        // col: 53 offset: 00b0
        public bool packedb0_1;
        public byte packedb0;
        public bool packedb0_2;
        public bool packedb0_4;

        // col: 22 offset: 00b4
        public uint[] Icon;

        // col: 38 offset: 00b8
        public uint unknownb8;

        // col: 54 offset: 00bc
        public bool packedbc_1;
        public byte packedbc;
        public bool packedbc_2;
        public bool packedbc_4;

        // col: 02 offset: 00c0
        public uint unknownc0;

        // col: 06 offset: 00c4
        public uint unknownc4;

        // col: 03 offset: 00c8
        public ushort unknownc8;

        // col: 04 offset: 00ca
        public ushort unknownca;

        // col: 05 offset: 00cc
        public ushort unknowncc;

        // col: 00 offset: 00ce
        public byte unknownce;

        // col: 01 offset: 00cf
        public byte unknowncf;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 39 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8, ExcelColumnDataType.UInt8 );

            packed8_1 = ( packed8 & 0x1 ) == 0x1;
            packed8_2 = ( packed8 & 0x2 ) == 0x2;
            packed8_4 = ( packed8 & 0x4 ) == 0x4;

            // col: 8 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 40 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14, ExcelColumnDataType.UInt8 );

            packed14_1 = ( packed14 & 0x1 ) == 0x1;
            packed14_2 = ( packed14 & 0x2 ) == 0x2;
            packed14_4 = ( packed14 & 0x4 ) == 0x4;

            // col: 9 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 41 offset: 0020
            packed20 = parser.ReadOffset< byte >( 0x20, ExcelColumnDataType.UInt8 );

            packed20_1 = ( packed20 & 0x1 ) == 0x1;
            packed20_2 = ( packed20 & 0x2 ) == 0x2;
            packed20_4 = ( packed20 & 0x4 ) == 0x4;

            // col: 10 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 42 offset: 002c
            packed2c = parser.ReadOffset< byte >( 0x2c, ExcelColumnDataType.UInt8 );

            packed2c_1 = ( packed2c & 0x1 ) == 0x1;
            packed2c_2 = ( packed2c & 0x2 ) == 0x2;
            packed2c_4 = ( packed2c & 0x4 ) == 0x4;

            // col: 11 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 43 offset: 0038
            packed38 = parser.ReadOffset< byte >( 0x38, ExcelColumnDataType.UInt8 );

            packed38_1 = ( packed38 & 0x1 ) == 0x1;
            packed38_2 = ( packed38 & 0x2 ) == 0x2;
            packed38_4 = ( packed38 & 0x4 ) == 0x4;

            // col: 12 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 44 offset: 0044
            packed44 = parser.ReadOffset< byte >( 0x44, ExcelColumnDataType.UInt8 );

            packed44_1 = ( packed44 & 0x1 ) == 0x1;
            packed44_2 = ( packed44 & 0x2 ) == 0x2;
            packed44_4 = ( packed44 & 0x4 ) == 0x4;

            // col: 13 offset: 0048
            unknown48 = parser.ReadOffset< uint >( 0x48 );

            // col: 45 offset: 0050
            packed50 = parser.ReadOffset< byte >( 0x50, ExcelColumnDataType.UInt8 );

            packed50_1 = ( packed50 & 0x1 ) == 0x1;
            packed50_2 = ( packed50 & 0x2 ) == 0x2;
            packed50_4 = ( packed50 & 0x4 ) == 0x4;

            // col: 14 offset: 0054
            unknown54 = parser.ReadOffset< uint >( 0x54 );

            // col: 46 offset: 005c
            packed5c = parser.ReadOffset< byte >( 0x5c, ExcelColumnDataType.UInt8 );

            packed5c_1 = ( packed5c & 0x1 ) == 0x1;
            packed5c_2 = ( packed5c & 0x2 ) == 0x2;
            packed5c_4 = ( packed5c & 0x4 ) == 0x4;

            // col: 15 offset: 0060
            unknown60 = parser.ReadOffset< uint >( 0x60 );

            // col: 47 offset: 0068
            packed68 = parser.ReadOffset< byte >( 0x68, ExcelColumnDataType.UInt8 );

            packed68_1 = ( packed68 & 0x1 ) == 0x1;
            packed68_2 = ( packed68 & 0x2 ) == 0x2;
            packed68_4 = ( packed68 & 0x4 ) == 0x4;

            // col: 16 offset: 006c
            unknown6c = parser.ReadOffset< uint >( 0x6c );

            // col: 48 offset: 0074
            packed74 = parser.ReadOffset< byte >( 0x74, ExcelColumnDataType.UInt8 );

            packed74_1 = ( packed74 & 0x1 ) == 0x1;
            packed74_2 = ( packed74 & 0x2 ) == 0x2;
            packed74_4 = ( packed74 & 0x4 ) == 0x4;

            // col: 17 offset: 0078
            unknown78 = parser.ReadOffset< uint >( 0x78 );

            // col: 49 offset: 0080
            packed80 = parser.ReadOffset< byte >( 0x80, ExcelColumnDataType.UInt8 );

            packed80_1 = ( packed80 & 0x1 ) == 0x1;
            packed80_2 = ( packed80 & 0x2 ) == 0x2;
            packed80_4 = ( packed80 & 0x4 ) == 0x4;

            // col: 18 offset: 0084
            unknown84 = parser.ReadOffset< uint >( 0x84 );

            // col: 50 offset: 008c
            packed8c = parser.ReadOffset< byte >( 0x8c, ExcelColumnDataType.UInt8 );

            packed8c_1 = ( packed8c & 0x1 ) == 0x1;
            packed8c_2 = ( packed8c & 0x2 ) == 0x2;
            packed8c_4 = ( packed8c & 0x4 ) == 0x4;

            // col: 19 offset: 0090
            unknown90 = parser.ReadOffset< uint >( 0x90 );

            // col: 51 offset: 0098
            packed98 = parser.ReadOffset< byte >( 0x98, ExcelColumnDataType.UInt8 );

            packed98_1 = ( packed98 & 0x1 ) == 0x1;
            packed98_2 = ( packed98 & 0x2 ) == 0x2;
            packed98_4 = ( packed98 & 0x4 ) == 0x4;

            // col: 20 offset: 009c
            unknown9c = parser.ReadOffset< uint >( 0x9c );

            // col: 52 offset: 00a4
            packeda4 = parser.ReadOffset< byte >( 0xa4, ExcelColumnDataType.UInt8 );

            packeda4_1 = ( packeda4 & 0x1 ) == 0x1;
            packeda4_2 = ( packeda4 & 0x2 ) == 0x2;
            packeda4_4 = ( packeda4 & 0x4 ) == 0x4;

            // col: 21 offset: 00a8
            unknowna8 = parser.ReadOffset< uint >( 0xa8 );

            // col: 53 offset: 00b0
            packedb0 = parser.ReadOffset< byte >( 0xb0, ExcelColumnDataType.UInt8 );

            packedb0_1 = ( packedb0 & 0x1 ) == 0x1;
            packedb0_2 = ( packedb0 & 0x2 ) == 0x2;
            packedb0_4 = ( packedb0 & 0x4 ) == 0x4;

            // col: 22 offset: 00b4
            Icon = new uint[16];
            Icon[0] = parser.ReadOffset< uint >( 0xb4 );
            Icon[1] = parser.ReadOffset< uint >( 0x4 );
            Icon[2] = parser.ReadOffset< uint >( 0x10 );
            Icon[3] = parser.ReadOffset< uint >( 0x1c );
            Icon[4] = parser.ReadOffset< uint >( 0x28 );
            Icon[5] = parser.ReadOffset< uint >( 0x34 );
            Icon[6] = parser.ReadOffset< uint >( 0x40 );
            Icon[7] = parser.ReadOffset< uint >( 0x4c );
            Icon[8] = parser.ReadOffset< uint >( 0x58 );
            Icon[9] = parser.ReadOffset< uint >( 0x64 );
            Icon[10] = parser.ReadOffset< uint >( 0x70 );
            Icon[11] = parser.ReadOffset< uint >( 0x7c );
            Icon[12] = parser.ReadOffset< uint >( 0x88 );
            Icon[13] = parser.ReadOffset< uint >( 0x94 );
            Icon[14] = parser.ReadOffset< uint >( 0xa0 );
            Icon[15] = parser.ReadOffset< uint >( 0xac );

            // col: 38 offset: 00b8
            unknownb8 = parser.ReadOffset< uint >( 0xb8 );

            // col: 54 offset: 00bc
            packedbc = parser.ReadOffset< byte >( 0xbc, ExcelColumnDataType.UInt8 );

            packedbc_1 = ( packedbc & 0x1 ) == 0x1;
            packedbc_2 = ( packedbc & 0x2 ) == 0x2;
            packedbc_4 = ( packedbc & 0x4 ) == 0x4;

            // col: 2 offset: 00c0
            unknownc0 = parser.ReadOffset< uint >( 0xc0 );

            // col: 6 offset: 00c4
            unknownc4 = parser.ReadOffset< uint >( 0xc4 );

            // col: 3 offset: 00c8
            unknownc8 = parser.ReadOffset< ushort >( 0xc8 );

            // col: 4 offset: 00ca
            unknownca = parser.ReadOffset< ushort >( 0xca );

            // col: 5 offset: 00cc
            unknowncc = parser.ReadOffset< ushort >( 0xcc );

            // col: 0 offset: 00ce
            unknownce = parser.ReadOffset< byte >( 0xce );

            // col: 1 offset: 00cf
            unknowncf = parser.ReadOffset< byte >( 0xcf );


        }
    }
}