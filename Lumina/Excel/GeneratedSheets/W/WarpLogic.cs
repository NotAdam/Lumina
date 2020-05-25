using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpLogic", columnHash: 0x4684fa1c )]
    public class WarpLogic : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public string[] Function;

        // col: 13 offset: 0004
        public uint[] unknown4;

        // col: 23 offset: 0050
        public string Question;

        // col: 24 offset: 0054
        public string ResponseYes;

        // col: 25 offset: 0058
        public string ResponseNo;

        // col: 01 offset: 005c
        public string WarpName;

        // col: 00 offset: 0060
        public uint unknown60;

        // col: 02 offset: 0064
        public bool CanSkipCutscene;
        public byte packed64;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Function = new string[10];
            Function[0] = parser.ReadOffset< string >( 0x0 );
            Function[1] = parser.ReadOffset< string >( 0x8 );
            Function[2] = parser.ReadOffset< string >( 0x10 );
            Function[3] = parser.ReadOffset< string >( 0x18 );
            Function[4] = parser.ReadOffset< string >( 0x20 );
            Function[5] = parser.ReadOffset< string >( 0x28 );
            Function[6] = parser.ReadOffset< string >( 0x30 );
            Function[7] = parser.ReadOffset< string >( 0x38 );
            Function[8] = parser.ReadOffset< string >( 0x40 );
            Function[9] = parser.ReadOffset< string >( 0x48 );

            // col: 13 offset: 0004
            unknown4 = new uint[10];
            unknown4[0] = parser.ReadOffset< uint >( 0x4 );
            unknown4[1] = parser.ReadOffset< uint >( 0xc );
            unknown4[2] = parser.ReadOffset< uint >( 0x14 );
            unknown4[3] = parser.ReadOffset< uint >( 0x1c );
            unknown4[4] = parser.ReadOffset< uint >( 0x24 );
            unknown4[5] = parser.ReadOffset< uint >( 0x2c );
            unknown4[6] = parser.ReadOffset< uint >( 0x34 );
            unknown4[7] = parser.ReadOffset< uint >( 0x3c );
            unknown4[8] = parser.ReadOffset< uint >( 0x44 );
            unknown4[9] = parser.ReadOffset< uint >( 0x4c );

            // col: 23 offset: 0050
            Question = parser.ReadOffset< string >( 0x50 );

            // col: 24 offset: 0054
            ResponseYes = parser.ReadOffset< string >( 0x54 );

            // col: 25 offset: 0058
            ResponseNo = parser.ReadOffset< string >( 0x58 );

            // col: 1 offset: 005c
            WarpName = parser.ReadOffset< string >( 0x5c );

            // col: 0 offset: 0060
            unknown60 = parser.ReadOffset< uint >( 0x60 );

            // col: 2 offset: 0064
            packed64 = parser.ReadOffset< byte >( 0x64, ExcelColumnDataType.UInt8 );

            CanSkipCutscene = ( packed64 & 0x1 ) == 0x1;


        }
    }
}