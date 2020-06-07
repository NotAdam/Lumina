using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGauge", columnHash: 0xf678f7f7 )]
    public class ContentGauge : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 03 offset: 0004
        public string TextString;

        // col: 01 offset: 0008
        public byte Color;

        // col: 06 offset: 0009
        public byte unknown9;

        // col: 09 offset: 000a
        public byte unknowna;

        // col: 04 offset: 000b
        public sbyte unknownb;

        // col: 07 offset: 000c
        public sbyte unknownc;

        // col: 05 offset: 000d
        public sbyte unknownd;

        // col: 08 offset: 000e
        public sbyte unknowne;

        // col: 02 offset: 000f
        public bool packedf_1;
        public byte packedf;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 3 offset: 0004
            TextString = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            Color = parser.ReadOffset< byte >( 0x8 );

            // col: 6 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 9 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 4 offset: 000b
            unknownb = parser.ReadOffset< sbyte >( 0xb );

            // col: 7 offset: 000c
            unknownc = parser.ReadOffset< sbyte >( 0xc );

            // col: 5 offset: 000d
            unknownd = parser.ReadOffset< sbyte >( 0xd );

            // col: 8 offset: 000e
            unknowne = parser.ReadOffset< sbyte >( 0xe );

            // col: 2 offset: 000f
            packedf = parser.ReadOffset< byte >( 0xf, ExcelColumnDataType.UInt8 );

            packedf_1 = ( packedf & 0x1 ) == 0x1;


        }
    }
}