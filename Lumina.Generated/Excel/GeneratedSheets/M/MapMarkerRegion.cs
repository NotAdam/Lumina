using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapMarkerRegion", columnHash: 0xe2747195 )]
    public class MapMarkerRegion : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public ushort unknown0;

        // col: 04 offset: 0002
        public ushort unknown2;

        // col: 07 offset: 0004
        public ushort unknown4;

        // col: 08 offset: 0006
        public ushort unknown6;

        // col: 01 offset: 0008
        public short X;

        // col: 02 offset: 000a
        public short unknowna;

        // col: 05 offset: 000c
        public short unknownc;

        // col: 06 offset: 000e
        public short unknowne;

        // col: 09 offset: 0010
        public short unknown10;

        // col: 10 offset: 0012
        public short unknown12;

        // col: 00 offset: 0014
        public byte unknown14;

        // col: 11 offset: 0015
        public bool packed15_1;
        public byte packed15;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 4 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 7 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 8 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 1 offset: 0008
            X = parser.ReadOffset< short >( 0x8 );

            // col: 2 offset: 000a
            unknowna = parser.ReadOffset< short >( 0xa );

            // col: 5 offset: 000c
            unknownc = parser.ReadOffset< short >( 0xc );

            // col: 6 offset: 000e
            unknowne = parser.ReadOffset< short >( 0xe );

            // col: 9 offset: 0010
            unknown10 = parser.ReadOffset< short >( 0x10 );

            // col: 10 offset: 0012
            unknown12 = parser.ReadOffset< short >( 0x12 );

            // col: 0 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 11 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15, ExcelColumnDataType.UInt8 );

            packed15_1 = ( packed15 & 0x1 ) == 0x1;


        }
    }
}