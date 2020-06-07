using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
    public class Balloon : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Dialogue;

        // col: 00 offset: 0004
        public bool Slowly;
        public byte packed4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Dialogue = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4, ExcelColumnDataType.UInt8 );

            Slowly = ( packed4 & 0x1 ) == 0x1;


        }
    }
}