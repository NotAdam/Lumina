namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskNormal", columnHash: 0x81338da6 )]
    public class RetainerTaskNormal : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Quantity[0]
         *  type: 
         */

        /* offset: 0009 col: 2
         *  name: Quantity[1]
         *  type: 
         */

        /* offset: 000a col: 3
         *  name: Quantity[2]
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: GatheringLog
         *  type: 
         */

        /* offset: 0006 col: 5
         *  name: FishingLog
         *  type: 
         */



        // col: 00 offset: 0000
        public int Item;

        // col: 04 offset: 0004
        public short GatheringLog;

        // col: 05 offset: 0006
        public short FishingLog;

        // col: 01 offset: 0008
        public byte Quantity0;

        // col: 02 offset: 0009
        public byte Quantity1;

        // col: 03 offset: 000a
        public byte Quantity2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 4 offset: 0004
            GatheringLog = parser.ReadOffset< short >( 0x4 );

            // col: 5 offset: 0006
            FishingLog = parser.ReadOffset< short >( 0x6 );

            // col: 1 offset: 0008
            Quantity0 = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            Quantity1 = parser.ReadOffset< byte >( 0x9 );

            // col: 3 offset: 000a
            Quantity2 = parser.ReadOffset< byte >( 0xa );


        }
    }
}