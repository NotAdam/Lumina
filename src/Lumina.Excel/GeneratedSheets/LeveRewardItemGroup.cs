// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItemGroup", columnHash: 0xf065e622 )]
    public class LeveRewardItemGroup : ExcelRow
    {
        public class LeveRewardGroup
        {
            public int Item { get; set; }
            public byte Count { get; set; }
            public bool HQ { get; set; }
        }
        
        public LeveRewardGroup[] RewardGroups { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RewardGroups = new LeveRewardGroup[ 9 ];
            for( var i = 0; i < 9; i++ )
            {
                RewardGroups[ i ] = new LeveRewardGroup();
                RewardGroups[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 3 + 0 ) );
                RewardGroups[ i ].Count = parser.ReadColumn< byte >( 0 + ( i * 3 + 1 ) );
                RewardGroups[ i ].HQ = parser.ReadColumn< bool >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}