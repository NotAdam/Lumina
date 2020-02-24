using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemUICategory", columnHash: 0xdc1f7844 )]
    public class ItemUICategory : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public int Icon;

        // col: 02 offset: 0008
        public byte OrderMinor;

        // col: 03 offset: 0009
        public byte OrderMajor;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            OrderMinor = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            OrderMajor = parser.ReadOffset< byte >( 0x9 );


        }
    }
}