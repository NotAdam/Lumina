// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
    public class WeeklyBingoRewardData : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public byte RewardType;
            public uint RewardItem;
            public bool RewardHQ;
            public ushort RewardQuantity;
            public byte RewardOption;
        }
        
        public UnkStruct0Struct[] UnkStruct0 { get; set; }
        public uint RewardItem2 { get; set; }
        public bool RewardHQ2 { get; set; }
        public ushort RewardQuantity2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkStruct0 = new UnkStruct0Struct[ 2 ];
            for( var i = 0; i < 2; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].RewardType = parser.ReadColumn< byte >( 0 + ( i * 5 + 0 ) );
                UnkStruct0[ i ].RewardItem = parser.ReadColumn< uint >( 0 + ( i * 5 + 1 ) );
                UnkStruct0[ i ].RewardHQ = parser.ReadColumn< bool >( 0 + ( i * 5 + 2 ) );
                UnkStruct0[ i ].RewardQuantity = parser.ReadColumn< ushort >( 0 + ( i * 5 + 3 ) );
                UnkStruct0[ i ].RewardOption = parser.ReadColumn< byte >( 0 + ( i * 5 + 4 ) );
            }
            RewardItem2 = parser.ReadColumn< uint >( 10 );
            RewardHQ2 = parser.ReadColumn< bool >( 11 );
            RewardQuantity2 = parser.ReadColumn< ushort >( 12 );
        }
    }
}