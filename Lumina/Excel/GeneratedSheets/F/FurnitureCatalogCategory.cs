namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FurnitureCatalogCategory", columnHash: 0xc8b7ab9b )]
    public class FurnitureCatalogCategory : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT

        /* offset: 0000 col: 0
         *  name: Category
         *  type: 
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 2
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Category;

        // col: 01 offset: 0004
        public ushort unknown4;

        // col: 02 offset: 0006
        public byte unknown6;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Category = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );


        }
    }
}