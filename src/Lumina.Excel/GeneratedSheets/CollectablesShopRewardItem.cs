// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRewardItem", columnHash: 0xf7e08b71 )]
    public partial class CollectablesShopRewardItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public bool Unknown1 { get; set; }
        public byte RewardLow { get; set; }
        public byte RewardMid { get; set; }
        public byte RewardHigh { get; set; }
        public uint Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            RewardLow = parser.ReadColumn< byte >( 2 );
            RewardMid = parser.ReadColumn< byte >( 3 );
            RewardHigh = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
        }
    }
}