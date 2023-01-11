// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopItem", columnHash: 0x392f49a3 )]
    public partial class CollectablesShopItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public LazyRow< CollectablesShopItemGroup > CollectablesShopItemGroup { get; set; }
        public ushort LevelMin { get; set; }
        public ushort LevelMax { get; set; }
        public byte Stars { get; set; }
        public byte Key { get; set; }
        public LazyRow< CollectablesShopRefine > CollectablesShopRefine { get; set; }
        public LazyRow< CollectablesShopRewardScrip > CollectablesShopRewardScrip { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            CollectablesShopItemGroup = new LazyRow< CollectablesShopItemGroup >( gameData, parser.ReadColumn< byte >( 1 ), language );
            LevelMin = parser.ReadColumn< ushort >( 2 );
            LevelMax = parser.ReadColumn< ushort >( 3 );
            Stars = parser.ReadColumn< byte >( 4 );
            Key = parser.ReadColumn< byte >( 5 );
            CollectablesShopRefine = new LazyRow< CollectablesShopRefine >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            CollectablesShopRewardScrip = new LazyRow< CollectablesShopRewardScrip >( gameData, parser.ReadColumn< ushort >( 7 ), language );
        }
    }
}