// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopItem", columnHash: 0x392f49a3 )]
    public class CollectablesShopItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte CollectablesShopItemGroup;
        public ushort LevelMin;
        public ushort LevelMax;
        public byte Unknown4;
        public byte Unknown5;
        public ushort CollectablesShopRefine;
        public ushort CollectablesShopRewardScrip;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
            CollectablesShopItemGroup = parser.ReadColumn< byte >( 1 );
            LevelMin = parser.ReadColumn< ushort >( 2 );
            LevelMax = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            CollectablesShopRefine = parser.ReadColumn< ushort >( 6 );
            CollectablesShopRewardScrip = parser.ReadColumn< ushort >( 7 );
        }
    }
}