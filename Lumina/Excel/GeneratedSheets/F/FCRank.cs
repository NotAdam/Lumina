namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCRank", columnHash: 0x0105b558 )]
    public class FCRank : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: NextPoint
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: CurrentPoint
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Rights
         *  type: 
         */

        /* offset: 000a col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 5
         *  name: FCActionActiveNum
         *  type: 
         */

        /* offset: 000f col: 6
         *  name: FCActionStockNum
         *  type: 
         */

        /* offset: 0010 col: 7
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint NextPoint;

        // col: 01 offset: 0004
        public uint CurrentPoint;

        // col: 02 offset: 0008
        public ushort Rights;

        // col: 03 offset: 000a
        public ushort unknowna;

        // col: 04 offset: 000c
        public ushort unknownc;

        // col: 05 offset: 000e
        public byte FCActionActiveNum;

        // col: 06 offset: 000f
        public byte FCActionStockNum;

        // col: 07 offset: 0010
        public byte unknown10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NextPoint = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            CurrentPoint = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Rights = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 5 offset: 000e
            FCActionActiveNum = parser.ReadOffset< byte >( 0xe );

            // col: 6 offset: 000f
            FCActionStockNum = parser.ReadOffset< byte >( 0xf );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );


        }
    }
}