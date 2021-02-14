// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRewardScrip", columnHash: 0x0c33ce97 )]
    public class CollectablesShopRewardScrip : ExcelRow
    {
        
        public ushort Currency;
        public ushort LowReward;
        public ushort MidReward;
        public ushort HighReward;
        public ushort ExpRatioLow;
        public ushort ExpRatioMid;
        public ushort ExpRatioHigh;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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