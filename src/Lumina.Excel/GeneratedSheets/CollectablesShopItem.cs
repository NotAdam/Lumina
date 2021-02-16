// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopItem", columnHash: 0x392f49a3 )]
    public class CollectablesShopItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public LazyRow< CollectablesShopItemGroup > CollectablesShopItemGroup;
        public ushort LevelMin;
        public ushort LevelMax;
        public byte Unknown4;
        public byte Unknown5;
        public LazyRow< CollectablesShopRefine > CollectablesShopRefine;
        public LazyRow< CollectablesShopRewardScrip > CollectablesShopRewardScrip;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            CollectablesShopItemGroup = new LazyRow< CollectablesShopItemGroup >( gameData, parser.ReadColumn< byte >( 1 ), language );
            LevelMin = parser.ReadColumn< ushort >( 2 );
            LevelMax = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            CollectablesShopRefine = new LazyRow< CollectablesShopRefine >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            CollectablesShopRewardScrip = new LazyRow< CollectablesShopRewardScrip >( gameData, parser.ReadColumn< ushort >( 7 ), language );
        }
    }
}