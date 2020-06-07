using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevProgress", columnHash: 0xcd4cb81c )]
    public class HWDDevProgress : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public bool CanGoNext;
        public byte packed0;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0, ExcelColumnDataType.UInt8 );

            CanGoNext = ( packed0 & 0x1 ) == 0x1;


        }
    }
}