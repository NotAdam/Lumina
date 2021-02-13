// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShop", columnHash: 0x0ebdee42 )]
    public class InclusionShop : ExcelRow
    {
        
        public uint Unknown0;
        public SeString Unknown1;
        public LazyRow< InclusionShopCategory >[] Category;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Category = new LazyRow< InclusionShopCategory >[ 30 ];
            for( var i = 0; i < 30; i++ )
                Category[ i ] = new LazyRow< InclusionShopCategory >( lumina, parser.ReadColumn< ushort >( 2 + i ), language );
        }
    }
}