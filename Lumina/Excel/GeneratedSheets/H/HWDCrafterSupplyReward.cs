namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupplyReward", columnHash: 0x829e9d8e )]
    public class HWDCrafterSupplyReward : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  name: ScriptReward{Amount}
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: ExpReward
         *  type: 
         */

        /* offset: 0006 col: 2
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public uint ExpReward;

        // col: 00 offset: 0004
        public ushort ScriptRewardAmount;

        // col: 02 offset: 0006
        public ushort unknown6;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

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