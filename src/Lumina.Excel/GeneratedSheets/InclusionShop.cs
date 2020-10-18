// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShop", columnHash: 0x0ebdee42 )]
    public class InclusionShop : IExcelRow
    {
        
        public uint Unknown0;
        public SeString Unknown1;
        public LazyRow< InclusionShopCategory >[] Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Category = new LazyRow< InclusionShopCategory >[ 30 ];
            for( var i = 0; i < 30; i++ )
                Category[ i ] = new LazyRow< InclusionShopCategory >( lumina, parser.ReadColumn< ushort >( 2 + i ), language );
        }
    }
}