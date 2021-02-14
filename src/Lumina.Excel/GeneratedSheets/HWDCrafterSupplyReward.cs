// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupplyReward", columnHash: 0x829e9d8e )]
    public class HWDCrafterSupplyReward : ExcelRow
    {
        
        public ushort ScriptRewardAmount;
        public uint ExpReward;
        public ushort Points;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ScriptRewardAmount = parser.ReadColumn< ushort >( 0 );
            ExpReward = parser.ReadColumn< uint >( 1 );
            Points = parser.ReadColumn< ushort >( 2 );
        }
    }
}