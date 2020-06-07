using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCCrestSymbol", columnHash: 0x43bdd5b1 )]
    public class FCCrestSymbol : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public ushort unknown0;

        // col: 00 offset: 0002
        public byte ColorNum;

        // col: 01 offset: 0003
        public byte FCRight;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 0 offset: 0002
            ColorNum = parser.ReadOffset< byte >( 0x2 );

            // col: 1 offset: 0003
            FCRight = parser.ReadOffset< byte >( 0x3 );


        }
    }
}