namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZReport", columnHash: 0x1a97b0af )]
    public class AOZReport : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 1
         *  name: Reward
         *  type: 
         */

        /* offset: 0005 col: 2
         *  name: Order
         *  type: 
         */



        // col: 00 offset: 0000
        public uint unknown0;

        // col: 01 offset: 0004
        public byte Reward;

        // col: 02 offset: 0005
        public sbyte Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Reward = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            Order = parser.ReadOffset< sbyte >( 0x5 );


        }
    }
}