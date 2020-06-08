using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Pet", columnHash: 0x9c5824d1 )]
    public class Pet : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public ushort unknown4;

        // col: 02 offset: 0006
        public ushort unknown6;

        // col: 03 offset: 0008
        public ushort unknown8;

        // col: 04 offset: 000a
        public ushort unknowna;

        // col: 05 offset: 000c
        public ushort unknownc;

        // col: 10 offset: 000e
        public byte unknowne;

        // col: 11 offset: 000f
        public byte unknownf;

        // col: 12 offset: 0010
        public byte unknown10;

        // col: 09 offset: 0011
        public sbyte unknown11;

        // col: 06 offset: 0012
        public bool packed12_1;
        public byte packed12;
        public bool packed12_2;
        public bool packed12_4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 4 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 5 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 10 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 11 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 12 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 9 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );

            // col: 6 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            packed12_1 = ( packed12 & 0x1 ) == 0x1;
            packed12_2 = ( packed12 & 0x2 ) == 0x2;
            packed12_4 = ( packed12 & 0x4 ) == 0x4;


        }
    }
}