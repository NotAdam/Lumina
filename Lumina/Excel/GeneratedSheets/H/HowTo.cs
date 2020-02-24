namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowTo", columnHash: 0xe4488448 )]
    public class HowTo : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  name: Images
         *  repeat count: 10
         */

        /* offset: 0006 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0019 col: 12
         *  name: Category
         *  type: 
         */

        /* offset: 0018 col: 13
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string unknown0;

        // col: 02 offset: 0004
        public short[] Images;

        // col: 13 offset: 0018
        public byte unknown18;

        // col: 12 offset: 0019
        public sbyte Category;

        // col: 01 offset: 001a
        private byte packed1a;
        public bool packed1a_1 => ( packed1a & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Images = new short[10];
            Images[0] = parser.ReadOffset< short >( 0x4 );
            Images[1] = parser.ReadOffset< short >( 0x6 );
            Images[2] = parser.ReadOffset< short >( 0x8 );
            Images[3] = parser.ReadOffset< short >( 0xa );
            Images[4] = parser.ReadOffset< short >( 0xc );
            Images[5] = parser.ReadOffset< short >( 0xe );
            Images[6] = parser.ReadOffset< short >( 0x10 );
            Images[7] = parser.ReadOffset< short >( 0x12 );
            Images[8] = parser.ReadOffset< short >( 0x14 );
            Images[9] = parser.ReadOffset< short >( 0x16 );

            // col: 13 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 12 offset: 0019
            Category = parser.ReadOffset< sbyte >( 0x19 );

            // col: 1 offset: 001a
            packed1a = parser.ReadOffset< byte >( 0x1a );


        }
    }
}