// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
    public class WeeklyBingoRewardData : IExcelRow
    {
        public struct UnkStruct0Struct
        {
            public byte RewardType;
            public uint RewardItem;
            public bool RewardHQ;
            public ushort RewardQuantity;
            public byte RewardOption;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        public uint RewardItem2;
        public bool RewardHQ2;
        public ushort RewardQuantity2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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