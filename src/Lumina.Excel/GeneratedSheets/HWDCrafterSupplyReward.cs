// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupplyReward", columnHash: 0xfc0db6f0 )]
    public partial class HWDCrafterSupplyReward : ExcelRow
    {
        
        public ushort ScriptRewardAmount { get; set; }
        public uint ExpReward { get; set; }
        public ushort Points { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ScriptRewardAmount = parser.ReadColumn< ushort >( 0 );
            ExpReward = parser.ReadColumn< uint >( 1 );
            Points = parser.ReadColumn< ushort >( 2 );
        }
    }
}