using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupplyReward", columnHash: 0x829e9d8e )]
    public class HWDCrafterSupplyReward : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint ExpReward;

        // col: 00 offset: 0004
        public ushort ScriptRewardAmount;

        // col: 02 offset: 0006
        public ushort unknown6;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ExpReward = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            ScriptRewardAmount = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );


        }
    }
}