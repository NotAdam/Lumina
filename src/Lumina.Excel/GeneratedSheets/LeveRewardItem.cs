// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItem", columnHash: 0x00035bbe )]
    public class LeveRewardItem : ExcelRow
    {
        public class LeveReward
        {
            public ushort LeveRewardItemGroup { get; set; }
            public byte ProbabilityPct { get; set; }
        }
        
        public LeveReward[] LeveRewards { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LeveRewards = new LeveReward[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                LeveRewards[ i ] = new LeveReward();
                LeveRewards[ i ].LeveRewardItemGroup = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                LeveRewards[ i ].ProbabilityPct = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}