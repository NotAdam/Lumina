using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMScene", columnHash: 0x2711a5ea )]
    public class BGMScene : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        private byte packed0;
        public bool EnableDisableRestart => ( packed0 & 0x1 ) == 0x1;
        public bool Resume => ( packed0 & 0x2 ) == 0x2;
        public bool EnablePassEnd => ( packed0 & 0x4 ) == 0x4;
        public bool ForceAutoReset => ( packed0 & 0x8 ) == 0x8;
        public bool IgnoreBattle => ( packed0 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0, ExcelColumnDataType.UInt8 );


        }
    }
}