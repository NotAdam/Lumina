namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntReward", columnHash: 0x4ace707c )]
    public class MobHuntReward : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 0000 col: 0
         *  name: ExpReward
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: GilReward
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Expansion
         *  type: 
         */

        /* offset: 0006 col: 3
         *  name: CurrencyReward
         *  type: 
         */



        // col: 00 offset: 0000
        public uint ExpReward;

        // col: 01 offset: 0004
        public ushort GilReward;

        // col: 03 offset: 0006
        public ushort CurrencyReward;

        // col: 02 offset: 0008
        public byte Expansion;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ExpReward = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            GilReward = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            CurrencyReward = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            Expansion = parser.ReadOffset< byte >( 0x8 );


        }
    }
}