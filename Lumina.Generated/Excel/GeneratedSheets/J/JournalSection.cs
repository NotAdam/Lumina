using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalSection", columnHash: 0x9530a4f2 )]
    public class JournalSection : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public bool packed4_1;
        public byte packed4;
        public bool packed4_2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4, ExcelColumnDataType.UInt8 );

            packed4_1 = ( packed4 & 0x1 ) == 0x1;
            packed4_2 = ( packed4 & 0x2 ) == 0x2;


        }
    }
}