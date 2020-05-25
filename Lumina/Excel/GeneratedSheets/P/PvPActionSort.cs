using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPActionSort", columnHash: 0xc3af756b )]
    public class PvPActionSort : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public int unknown0;

        // col: 01 offset: 0004
        public ushort Action;

        // col: 00 offset: 0006
        public byte Name;

        // col: 02 offset: 0007
        public bool packed7_1;
        public byte packed7;
        public bool packed7_2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            unknown0 = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Action = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            Name = parser.ReadOffset< byte >( 0x6 );

            // col: 2 offset: 0007
            packed7 = parser.ReadOffset< byte >( 0x7, ExcelColumnDataType.UInt8 );

            packed7_1 = ( packed7 & 0x1 ) == 0x1;
            packed7_2 = ( packed7 & 0x2 ) == 0x2;


        }
    }
}