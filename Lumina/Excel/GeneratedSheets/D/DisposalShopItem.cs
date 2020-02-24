namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShopItem", columnHash: 0x1990ed53 )]
    public class DisposalShopItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  name: Item{Disposed}
         *  type: 
         */

        /* offset: 000e col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  name: Item{Received}
         *  type: 
         */

        /* offset: 000e col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 4
         *  name: Quantity{Received}
         *  type: 
         */

        /* offset: 000c col: 5
         *  no SaintCoinach definition found
         */



        // col: 04 offset: 0000
        public uint QuantityReceived;

        // col: 00 offset: 0004
        public int ItemDisposed;

        // col: 02 offset: 0008
        public int ItemReceived;

        // col: 05 offset: 000c
        public ushort unknownc;

        // col: 01 offset: 000e
        private byte packede;
        public bool packede_1 => ( packede & 0x1 ) == 0x1;
        public bool packede_2 => ( packede & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            QuantityReceived = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            ItemDisposed = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            ItemReceived = parser.ReadOffset< int >( 0x8 );

            // col: 5 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 1 offset: 000e
            packede = parser.ReadOffset< byte >( 0xe );


        }
    }
}