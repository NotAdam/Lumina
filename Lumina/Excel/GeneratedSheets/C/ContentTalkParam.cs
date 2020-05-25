using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentTalkParam", columnHash: 0xd4cefacf )]
    public class ContentTalkParam : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint TestAction;

        // col: 01 offset: 0004
        public byte unknown4;

        // col: 05 offset: 0005
        public byte unknown5;

        // col: 03 offset: 0006
        public sbyte unknown6;

        // col: 04 offset: 0007
        public sbyte unknown7;

        // col: 00 offset: 0008
        public bool Param;
        public byte packed8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            TestAction = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 5 offset: 0005
            unknown5 = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            unknown6 = parser.ReadOffset< sbyte >( 0x6 );

            // col: 4 offset: 0007
            unknown7 = parser.ReadOffset< sbyte >( 0x7 );

            // col: 0 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8, ExcelColumnDataType.UInt8 );

            Param = ( packed8 & 0x1 ) == 0x1;


        }
    }
}