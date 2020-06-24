using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FurnitureCatalogCategory", columnHash: 0xc8b7ab9b )]
    public class FurnitureCatalogCategory : IExcelRow
    {
        
        public string Category;
        public ushort Unknown1;
        public byte Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}