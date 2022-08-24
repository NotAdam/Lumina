// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRewardScrip", columnHash: 0x0c33ce97 )]
    public partial class CollectablesShopRewardScrip : ExcelRow
    {
        
        public ushort Currency { get; set; }
        public ushort LowReward { get; set; }
        public ushort MidReward { get; set; }
        public ushort HighReward { get; set; }
        public ushort ExpRatioLow { get; set; }
        public ushort ExpRatioMid { get; set; }
        public ushort ExpRatioHigh { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Currency = parser.ReadColumn< ushort >( 0 );
            LowReward = parser.ReadColumn< ushort >( 1 );
            MidReward = parser.ReadColumn< ushort >( 2 );
            HighReward = parser.ReadColumn< ushort >( 3 );
            ExpRatioLow = parser.ReadColumn< ushort >( 4 );
            ExpRatioMid = parser.ReadColumn< ushort >( 5 );
            ExpRatioHigh = parser.ReadColumn< ushort >( 6 );
        }
    }
}