using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Treasure", columnHash: 0x030e840a )]
    public class Treasure : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string unknown0;

        // col: 02 offset: 0004
        public string unknown4;

        // col: 01 offset: 0008
        public sbyte unknown8;

        // col: 03 offset: 0009
        public sbyte unknown9;

        // col: 04 offset: 000a
        public sbyte unknowna;

        // col: 05 offset: 000b
        public sbyte unknownb;

        // col: 06 offset: 000c
        public sbyte unknownc;

        // col: 07 offset: 000d
        public sbyte unknownd;

        // col: 08 offset: 0010
        public uint Item;

        // col: 09 offset: 0014
        public bool packed14_1;
        public byte packed14;
        public bool packed14_2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            unknown8 = parser.ReadOffset< sbyte >( 0x8 );

            // col: 3 offset: 0009
            unknown9 = parser.ReadOffset< sbyte >( 0x9 );

            // col: 4 offset: 000a
            unknowna = parser.ReadOffset< sbyte >( 0xa );

            // col: 5 offset: 000b
            unknownb = parser.ReadOffset< sbyte >( 0xb );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< sbyte >( 0xc );

            // col: 7 offset: 000d
            unknownd = parser.ReadOffset< sbyte >( 0xd );

            // col: 8 offset: 0010
            Item = parser.ReadOffset< uint >( 0x10 );

            // col: 9 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14, ExcelColumnDataType.UInt8 );

            packed14_1 = ( packed14 & 0x1 ) == 0x1;
            packed14_2 = ( packed14 & 0x2 ) == 0x2;


        }
    }
}