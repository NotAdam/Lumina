// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShop", columnHash: 0x6a066e9a )]
    public class CollectablesShop : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< CollectablesShopItem >[] ShopItems { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            ShopItems = new LazyRow< CollectablesShopItem >[ 11 ];
            for( var i = 0; i < 11; i++ )
                ShopItems[ i ] = new LazyRow< CollectablesShopItem >( gameData, parser.ReadColumn< ushort >( 3 + i ), language );
        }
    }
}