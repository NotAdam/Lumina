// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRewardScrip", columnHash: 0x0c33ce97 )]
    public class CollectablesShopRewardScrip : IExcelRow
    {
        
        public LazyRow< Currency > Currency;
        public ushort LowReward;
        public ushort MidReward;
        public ushort HighReward;
        public ushort ExpRatioLow;
        public ushort ExpRatioMid;
        public ushort ExpRatioHigh;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Currency = new LazyRow< Currency >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            LowReward = parser.ReadColumn< ushort >( 1 );
            MidReward = parser.ReadColumn< ushort >( 2 );
            HighReward = parser.ReadColumn< ushort >( 3 );
            ExpRatioLow = parser.ReadColumn< ushort >( 4 );
            ExpRatioMid = parser.ReadColumn< ushort >( 5 );
            ExpRatioHigh = parser.ReadColumn< ushort >( 6 );
        }
    }
}