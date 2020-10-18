// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupplyReward", columnHash: 0x829e9d8e )]
    public class HWDCrafterSupplyReward : IExcelRow
    {
        
        public ushort ScriptRewardAmount;
        public uint ExpReward;
        public ushort Points;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ScriptRewardAmount = parser.ReadColumn< ushort >( 0 );
            ExpReward = parser.ReadColumn< uint >( 1 );
            Points = parser.ReadColumn< ushort >( 2 );
        }
    }
}