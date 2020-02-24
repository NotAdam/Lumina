using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Omen", columnHash: 0xd79b6c3f )]
    public class Omen : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Path;

        // col: 01 offset: 0004
        public string PathAlly;

        // col: 02 offset: 0008
        public byte Type;

        // col: 05 offset: 0009
        public sbyte unknown9;

        // col: 03 offset: 000a
        private byte packeda;
        public bool RestrictYScale => ( packeda & 0x1 ) == 0x1;
        public bool LargeScale => ( packeda & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Path = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            PathAlly = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Type = parser.ReadOffset< byte >( 0x8 );

            // col: 5 offset: 0009
            unknown9 = parser.ReadOffset< sbyte >( 0x9 );

            // col: 3 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa, ExcelColumnDataType.UInt8 );


        }
    }
}