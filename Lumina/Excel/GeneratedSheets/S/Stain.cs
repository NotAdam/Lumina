using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Stain", columnHash: 0xa2420e68 )]
    public class Stain : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 03 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public uint Color;

        // col: 01 offset: 0008
        public byte Shade;

        // col: 02 offset: 0009
        public byte unknown9;

        // col: 04 offset: 000a
        private byte packeda;
        public bool packeda_1 => ( packeda & 0x1 ) == 0x1;
        public bool packeda_2 => ( packeda & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Color = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            Shade = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 4 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa, ExcelColumnDataType.UInt8 );


        }
    }
}