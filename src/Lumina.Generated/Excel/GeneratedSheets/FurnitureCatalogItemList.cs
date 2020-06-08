using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FurnitureCatalogItemList", columnHash: 0x24e9963a )]
    public class FurnitureCatalogItemList : IExcelRow
    {
        
        public LazyRow< FurnitureCatalogCategory > Category;
        public LazyRow< Item > Item;
        public ushort Patch;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = new LazyRow< FurnitureCatalogCategory >( lumina, parser.ReadColumn< ushort >( 0 ) );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 1 ) );
            Patch = parser.ReadColumn< ushort >( 2 );
        }
    }
}