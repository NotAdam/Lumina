using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YardCatalogItemList", columnHash: 0x24e9963a )]
    public class YardCatalogItemList : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int Item;

        // col: 00 offset: 0004
        public ushort Category;

        // col: 02 offset: 0006
        public ushort Patch;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            Category = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            Patch = parser.ReadOffset< ushort >( 0x6 );


        }
    }
}