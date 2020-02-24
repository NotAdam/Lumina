namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntOrderType", columnHash: 0x795a75a0 )]
    public class MobHuntOrderType : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 000a col: 0
         *  name: Type
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Quest
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: EventItem
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: Order{Start}
         *  type: 
         */

        /* offset: 000b col: 4
         *  name: Order{Amount}
         *  type: 
         */



        // col: 01 offset: 0000
        public uint Quest;

        // col: 02 offset: 0004
        public uint EventItem;

        // col: 03 offset: 0008
        public ushort OrderStart;

        // col: 00 offset: 000a
        public byte Type;

        // col: 04 offset: 000b
        public byte OrderAmount;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            EventItem = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            OrderStart = parser.ReadOffset< ushort >( 0x8 );

            // col: 0 offset: 000a
            Type = parser.ReadOffset< byte >( 0xa );

            // col: 4 offset: 000b
            OrderAmount = parser.ReadOffset< byte >( 0xb );


        }
    }
}