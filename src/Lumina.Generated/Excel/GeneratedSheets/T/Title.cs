using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Title", columnHash: 0x83e3f9ba )]
    public class Title : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Masculine;

        // col: 01 offset: 0004
        public string Feminine;

        // col: 02 offset: 0008
        public bool IsPrefix;
        public byte packed8;

        // col: 03 offset: 000c
        public ushort Order;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Masculine = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Feminine = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8, ExcelColumnDataType.UInt8 );

            IsPrefix = ( packed8 & 0x1 ) == 0x1;

            // col: 3 offset: 000c
            Order = parser.ReadOffset< ushort >( 0xc );


        }
    }
}