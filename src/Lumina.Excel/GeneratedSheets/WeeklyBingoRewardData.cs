// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
    public partial class WeeklyBingoRewardData : ExcelRow
    {
        public class WeeklyBingoRewardDataUnkData0Obj
        {
            public byte RewardType { get; set; }
            public uint RewardItem { get; set; }
            public bool RewardHQ { get; set; }
            public ushort RewardQuantity { get; set; }
            public byte RewardOption { get; set; }
        }
        
        public WeeklyBingoRewardDataUnkData0Obj[] UnkData0 { get; set; }
        public uint RewardItem2 { get; set; }
        public bool RewardHQ2 { get; set; }
        public ushort RewardQuantity2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new WeeklyBingoRewardDataUnkData0Obj[ 2 ];
            for( var i = 0; i < 2; i++ )
            {
                UnkData0[ i ] = new WeeklyBingoRewardDataUnkData0Obj();
                UnkData0[ i ].RewardType = parser.ReadColumn< byte >( 0 + ( i * 5 + 0 ) );
                UnkData0[ i ].RewardItem = parser.ReadColumn< uint >( 0 + ( i * 5 + 1 ) );
                UnkData0[ i ].RewardHQ = parser.ReadColumn< bool >( 0 + ( i * 5 + 2 ) );
                UnkData0[ i ].RewardQuantity = parser.ReadColumn< ushort >( 0 + ( i * 5 + 3 ) );
                UnkData0[ i ].RewardOption = parser.ReadColumn< byte >( 0 + ( i * 5 + 4 ) );
            }
            RewardItem2 = parser.ReadColumn< uint >( 10 );
            RewardHQ2 = parser.ReadColumn< bool >( 11 );
            RewardQuantity2 = parser.ReadColumn< ushort >( 12 );
        }
    }
}