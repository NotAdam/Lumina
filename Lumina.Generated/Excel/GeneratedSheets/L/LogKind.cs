using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogKind", columnHash: 0x23b962ed )]
    public class LogKind : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Format;

        // col: 00 offset: 0004
        public byte unknown4;

        // col: 02 offset: 0005
        public bool packed5_1;
        public byte packed5;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Format = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5, ExcelColumnDataType.UInt8 );

            packed5_1 = ( packed5 & 0x1 ) == 0x1;


        }
    }
}