using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalGenre", columnHash: 0x2c6b75bb )]
    public class JournalGenre : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public int Icon;

        // col: 01 offset: 0008
        public byte JournalCategory;

        // col: 02 offset: 0009
        public bool packed9_1;
        public byte packed9;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Icon = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            JournalCategory = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            packed9 = parser.ReadOffset< byte >( 0x9, ExcelColumnDataType.UInt8 );

            packed9_1 = ( packed9 & 0x1 ) == 0x1;


        }
    }
}