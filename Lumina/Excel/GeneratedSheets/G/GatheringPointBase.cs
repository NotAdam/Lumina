namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBase", columnHash: 0x73fa0924 )]
    public class GatheringPointBase : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: GatheringType
         *  type: 
         */

        /* offset: 0024 col: 1
         *  name: GatheringLevel
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Item
         *  repeat count: 8
         */

        /* offset: 0008 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0025 col: 10
         *  name: IsLimited
         *  type: 
         */



        // col: 00 offset: 0000
        public int GatheringType;

        // col: 02 offset: 0004
        public int[] Item;

        // col: 01 offset: 0024
        public byte GatheringLevel;

        // col: 10 offset: 0025
        private byte packed25;
        public bool IsLimited => ( packed25 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            GatheringType = parser.ReadOffset< int >( 0x0 );

            // col: 2 offset: 0004
            Item = new int[8];
            Item[0] = parser.ReadOffset< int >( 0x4 );
            Item[1] = parser.ReadOffset< int >( 0x8 );
            Item[2] = parser.ReadOffset< int >( 0xc );
            Item[3] = parser.ReadOffset< int >( 0x10 );
            Item[4] = parser.ReadOffset< int >( 0x14 );
            Item[5] = parser.ReadOffset< int >( 0x18 );
            Item[6] = parser.ReadOffset< int >( 0x1c );
            Item[7] = parser.ReadOffset< int >( 0x20 );

            // col: 1 offset: 0024
            GatheringLevel = parser.ReadOffset< byte >( 0x24 );

            // col: 10 offset: 0025
            packed25 = parser.ReadOffset< byte >( 0x25 );


        }
    }
}