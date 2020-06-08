using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMScene", columnHash: 0x2711a5ea )]
    public class BGMScene : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public bool EnableDisableRestart;
        public byte packed0;
        public bool Resume;
        public bool EnablePassEnd;
        public bool ForceAutoReset;
        public bool IgnoreBattle;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0, ExcelColumnDataType.UInt8 );

            EnableDisableRestart = ( packed0 & 0x1 ) == 0x1;
            Resume = ( packed0 & 0x2 ) == 0x2;
            EnablePassEnd = ( packed0 & 0x4 ) == 0x4;
            ForceAutoReset = ( packed0 & 0x8 ) == 0x8;
            IgnoreBattle = ( packed0 & 0x10 ) == 0x10;


        }
    }
}