// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopItem", columnHash: 0x6c3dae69 )]
    public class GCScripShopItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public LazyRow< GrandCompanyRank > RequiredGrandCompanyRank;
        public uint CostGCSeals;
        public byte SortKey;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            RequiredGrandCompanyRank = new LazyRow< GrandCompanyRank >( lumina, parser.ReadColumn< int >( 1 ), language );
            CostGCSeals = parser.ReadColumn< uint >( 2 );
            SortKey = parser.ReadColumn< byte >( 3 );
        }
    }
}