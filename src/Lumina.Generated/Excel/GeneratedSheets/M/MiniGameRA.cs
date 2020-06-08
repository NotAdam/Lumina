using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameRA", columnHash: 0x89c987f3 )]
    public class MiniGameRA : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public uint unknown0;

        // col: 00 offset: 0004
        public int unknown4;

        // col: 01 offset: 0008
        public int Icon;

        // col: 02 offset: 000c
        public int BGM;

        // col: 03 offset: 0010
        public int unknown10;

        // col: 07 offset: 0014
        public ushort unknown14;

        // col: 08 offset: 0016
        public ushort unknown16;

        // col: 09 offset: 0018
        public short unknown18;

        // col: 10 offset: 001a
        public short unknown1a;

        // col: 11 offset: 001c
        public short unknown1c;

        // col: 12 offset: 001e
        public short unknown1e;

        // col: 13 offset: 0020
        public byte unknown20;

        // col: 14 offset: 0021
        public byte unknown21;

        // col: 15 offset: 0022
        public byte unknown22;

        // col: 16 offset: 0023
        public byte unknown23;

        // col: 05 offset: 0024
        public bool packed24_1;
        public byte packed24;
        public bool packed24_2;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 2 offset: 000c
            BGM = parser.ReadOffset< int >( 0xc );

            // col: 3 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 7 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 8 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );

            // col: 9 offset: 0018
            unknown18 = parser.ReadOffset< short >( 0x18 );

            // col: 10 offset: 001a
            unknown1a = parser.ReadOffset< short >( 0x1a );

            // col: 11 offset: 001c
            unknown1c = parser.ReadOffset< short >( 0x1c );

            // col: 12 offset: 001e
            unknown1e = parser.ReadOffset< short >( 0x1e );

            // col: 13 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );

            // col: 14 offset: 0021
            unknown21 = parser.ReadOffset< byte >( 0x21 );

            // col: 15 offset: 0022
            unknown22 = parser.ReadOffset< byte >( 0x22 );

            // col: 16 offset: 0023
            unknown23 = parser.ReadOffset< byte >( 0x23 );

            // col: 5 offset: 0024
            packed24 = parser.ReadOffset< byte >( 0x24, ExcelColumnDataType.UInt8 );

            packed24_1 = ( packed24 & 0x1 ) == 0x1;
            packed24_2 = ( packed24 & 0x2 ) == 0x2;


        }
    }
}