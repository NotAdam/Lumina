using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogMessage", columnHash: 0xf3a6d024 )]
    public class LogMessage : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 04 offset: 0000
        public string Text;

        // col: 00 offset: 0004
        public ushort LogKind;

        // col: 01 offset: 0006
        public ushort unknown6;

        // col: 02 offset: 0008
        public byte unknown8;

        // col: 03 offset: 0009
        private byte packed9;
        public bool packed9_1 => ( packed9 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            LogKind = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            packed9 = parser.ReadOffset< byte >( 0x9, ExcelColumnDataType.UInt8 );


        }
    }
}