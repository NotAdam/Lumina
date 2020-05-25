using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cabinet", columnHash: 0x200261d8 )]
    public class Cabinet : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Item;

        // col: 01 offset: 0004
        public ushort Order;

        // col: 02 offset: 0006
        public byte Category;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Order = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            Category = parser.ReadOffset< byte >( 0x6 );


        }
    }
}