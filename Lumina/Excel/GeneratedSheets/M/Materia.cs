namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Materia", columnHash: 0xc8626761 )]
    public class Materia : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  repeat count: 10
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
         *  name: BaseParam
         *  type: 
         */

        /* offset: 0029 col: 11
         *  name: Value
         *  repeat count: 10
         */

        /* offset: 002a col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 002b col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 002f col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0031 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0032 col: 20
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int[] Item;

        // col: 10 offset: 0028
        public byte BaseParam;

        // col: 11 offset: 0029
        public byte[] Value;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = new int[10];
            Item[0] = parser.ReadOffset< int >( 0x0 );
            Item[1] = parser.ReadOffset< int >( 0x4 );
            Item[2] = parser.ReadOffset< int >( 0x8 );
            Item[3] = parser.ReadOffset< int >( 0xc );
            Item[4] = parser.ReadOffset< int >( 0x10 );
            Item[5] = parser.ReadOffset< int >( 0x14 );
            Item[6] = parser.ReadOffset< int >( 0x18 );
            Item[7] = parser.ReadOffset< int >( 0x1c );
            Item[8] = parser.ReadOffset< int >( 0x20 );
            Item[9] = parser.ReadOffset< int >( 0x24 );

            // col: 10 offset: 0028
            BaseParam = parser.ReadOffset< byte >( 0x28 );

            // col: 11 offset: 0029
            Value = new byte[10];
            Value[0] = parser.ReadOffset< byte >( 0x29 );
            Value[1] = parser.ReadOffset< byte >( 0x2a );
            Value[2] = parser.ReadOffset< byte >( 0x2b );
            Value[3] = parser.ReadOffset< byte >( 0x2c );
            Value[4] = parser.ReadOffset< byte >( 0x2d );
            Value[5] = parser.ReadOffset< byte >( 0x2e );
            Value[6] = parser.ReadOffset< byte >( 0x2f );
            Value[7] = parser.ReadOffset< byte >( 0x30 );
            Value[8] = parser.ReadOffset< byte >( 0x31 );
            Value[9] = parser.ReadOffset< byte >( 0x32 );


        }
    }
}