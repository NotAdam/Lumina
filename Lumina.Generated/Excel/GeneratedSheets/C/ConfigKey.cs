using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
    public class ConfigKey : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 07 offset: 0000
        public string Text;

        // col: 00 offset: 0004
        public string Label;

        // col: 05 offset: 0008
        public ushort unknown8;

        // col: 01 offset: 000a
        public byte Param;

        // col: 02 offset: 000b
        public byte Platform;

        // col: 04 offset: 000c
        public byte Category;

        // col: 06 offset: 000d
        public byte unknownd;

        // col: 03 offset: 000e
        public bool Required;
        public byte packede;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Label = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 1 offset: 000a
            Param = parser.ReadOffset< byte >( 0xa );

            // col: 2 offset: 000b
            Platform = parser.ReadOffset< byte >( 0xb );

            // col: 4 offset: 000c
            Category = parser.ReadOffset< byte >( 0xc );

            // col: 6 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 3 offset: 000e
            packede = parser.ReadOffset< byte >( 0xe, ExcelColumnDataType.UInt8 );

            Required = ( packede & 0x1 ) == 0x1;


        }
    }
}