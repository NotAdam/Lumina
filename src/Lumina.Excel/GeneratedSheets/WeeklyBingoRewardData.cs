// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
    public class WeeklyBingoRewardData : ExcelRow
    {
        public class BingoRewardData
        {
            public byte RewardType { get; set; }
            public uint RewardItem { get; set; }
            public bool RewardHQ { get; set; }
            public ushort RewardQuantity { get; set; }
            public byte RewardOption { get; set; }
        }
        
        public BingoRewardData[] BingoRewards { get; set; }
        public uint RewardItem2 { get; set; }
        public bool RewardHQ2 { get; set; }
        public ushort RewardQuantity2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BingoRewards = new BingoRewardData[ 2 ];
            for( var i = 0; i < 2; i++ )
            {
                BingoRewards[ i ] = new BingoRewardData();
                BingoRewards[ i ].RewardType = parser.ReadColumn< byte >( 0 + ( i * 5 + 0 ) );
                BingoRewards[ i ].RewardItem = parser.ReadColumn< uint >( 0 + ( i * 5 + 1 ) );
                BingoRewards[ i ].RewardHQ = parser.ReadColumn< bool >( 0 + ( i * 5 + 2 ) );
                BingoRewards[ i ].RewardQuantity = parser.ReadColumn< ushort >( 0 + ( i * 5 + 3 ) );
                BingoRewards[ i ].RewardOption = parser.ReadColumn< byte >( 0 + ( i * 5 + 4 ) );
            }
            RewardItem2 = parser.ReadColumn< uint >( 10 );
            RewardHQ2 = parser.ReadColumn< bool >( 11 );
            RewardQuantity2 = parser.ReadColumn< ushort >( 12 );
        }
    }
}