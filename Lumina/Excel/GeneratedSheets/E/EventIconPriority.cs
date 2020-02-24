namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0x0bc77e1c )]
    public class EventIconPriority : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Icon
         *  repeat count: 19
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0048 col: 18
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint[] Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Icon = new uint[19];
            Icon[0] = parser.ReadOffset< uint >( 0x0 );
            Icon[1] = parser.ReadOffset< uint >( 0x4 );
            Icon[2] = parser.ReadOffset< uint >( 0x8 );
            Icon[3] = parser.ReadOffset< uint >( 0xc );
            Icon[4] = parser.ReadOffset< uint >( 0x10 );
            Icon[5] = parser.ReadOffset< uint >( 0x14 );
            Icon[6] = parser.ReadOffset< uint >( 0x18 );
            Icon[7] = parser.ReadOffset< uint >( 0x1c );
            Icon[8] = parser.ReadOffset< uint >( 0x20 );
            Icon[9] = parser.ReadOffset< uint >( 0x24 );
            Icon[10] = parser.ReadOffset< uint >( 0x28 );
            Icon[11] = parser.ReadOffset< uint >( 0x2c );
            Icon[12] = parser.ReadOffset< uint >( 0x30 );
            Icon[13] = parser.ReadOffset< uint >( 0x34 );
            Icon[14] = parser.ReadOffset< uint >( 0x38 );
            Icon[15] = parser.ReadOffset< uint >( 0x3c );
            Icon[16] = parser.ReadOffset< uint >( 0x40 );
            Icon[17] = parser.ReadOffset< uint >( 0x44 );
            Icon[18] = parser.ReadOffset< uint >( 0x48 );


        }
    }
}