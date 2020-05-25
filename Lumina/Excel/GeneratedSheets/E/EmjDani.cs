using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmjDani", columnHash: 0xf3fb0152 )]
    public class EmjDani : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Icon;

        // col: 01 offset: 0004
        public ushort unknown4;

        // col: 02 offset: 0006
        public ushort unknown6;

        // col: 04 offset: 0008
        public short unknown8;

        // col: 05 offset: 000a
        public short unknowna;

        // col: 06 offset: 000c
        public short unknownc;

        // col: 07 offset: 000e
        public short unknowne;

        // col: 08 offset: 0010
        public short unknown10;

        // col: 09 offset: 0012
        public short unknown12;

        // col: 10 offset: 0014
        public short unknown14;

        // col: 11 offset: 0016
        public short unknown16;

        // col: 03 offset: 0018
        public bool packed18_1;
        public byte packed18;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Icon = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            unknown8 = parser.ReadOffset< short >( 0x8 );

            // col: 5 offset: 000a
            unknowna = parser.ReadOffset< short >( 0xa );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< short >( 0xc );

            // col: 7 offset: 000e
            unknowne = parser.ReadOffset< short >( 0xe );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< short >( 0x10 );

            // col: 9 offset: 0012
            unknown12 = parser.ReadOffset< short >( 0x12 );

            // col: 10 offset: 0014
            unknown14 = parser.ReadOffset< short >( 0x14 );

            // col: 11 offset: 0016
            unknown16 = parser.ReadOffset< short >( 0x16 );

            // col: 3 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            packed18_1 = ( packed18 & 0x1 ) == 0x1;


        }
    }
}