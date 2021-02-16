// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopItem", columnHash: 0x6c3dae69 )]
    public class GCScripShopItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public LazyRow< GrandCompanyRank > RequiredGrandCompanyRank;
        public uint CostGCSeals;
        public byte SortKey;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            RequiredGrandCompanyRank = new LazyRow< GrandCompanyRank >( gameData, parser.ReadColumn< int >( 1 ), language );
            CostGCSeals = parser.ReadColumn< uint >( 2 );
            SortKey = parser.ReadColumn< byte >( 3 );
        }
    }
}