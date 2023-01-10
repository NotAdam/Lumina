// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FurnitureCatalogCategory", columnHash: 0xc8b7ab9b )]
    public partial class FurnitureCatalogCategory : ExcelRow
    {
        
        public SeString Category { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}