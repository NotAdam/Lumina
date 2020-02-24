using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimeline", columnHash: 0xd5952f72 )]
    public class MotionTimeline : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Filename;

        // col: 01 offset: 0004
        public byte BlendGroup;

        // col: 02 offset: 0005
        private byte packed5;
        public bool IsLoop => ( packed5 & 0x1 ) == 0x1;
        public bool IsBlinkEnable => ( packed5 & 0x2 ) == 0x2;
        public bool IsLipEnable => ( packed5 & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Filename = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            BlendGroup = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5, ExcelColumnDataType.UInt8 );


        }
    }
}