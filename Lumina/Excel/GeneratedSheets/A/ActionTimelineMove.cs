using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimelineMove", columnHash: 0x4a51230b )]
    public class ActionTimelineMove : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public byte unknown0;

        // col: 01 offset: 0001
        public byte unknown1;

        // col: 02 offset: 0002
        public byte unknown2;

        // col: 03 offset: 0003
        public byte unknown3;

        // col: 04 offset: 0004
        private byte packed4;
        public bool packed4_1 => ( packed4 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            unknown1 = parser.ReadOffset< byte >( 0x1 );

            // col: 2 offset: 0002
            unknown2 = parser.ReadOffset< byte >( 0x2 );

            // col: 3 offset: 0003
            unknown3 = parser.ReadOffset< byte >( 0x3 );

            // col: 4 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4, ExcelColumnDataType.UInt8 );


        }
    }
}