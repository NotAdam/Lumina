using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
    public class BuddyItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Item;

        // col: 04 offset: 0002
        public byte Status;

        // col: 01 offset: 0003
        public bool UseField;
        public byte packed3;
        public bool UseTraining;
        public bool packed3_4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< ushort >( 0x0 );

            // col: 4 offset: 0002
            Status = parser.ReadOffset< byte >( 0x2 );

            // col: 1 offset: 0003
            packed3 = parser.ReadOffset< byte >( 0x3, ExcelColumnDataType.UInt8 );

            UseField = ( packed3 & 0x1 ) == 0x1;
            UseTraining = ( packed3 & 0x2 ) == 0x2;
            packed3_4 = ( packed3 & 0x4 ) == 0x4;


        }
    }
}