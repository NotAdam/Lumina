namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
    public class GuildleveAssignmentCategory : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Category
         *  repeat count: 8
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



        // col: 00 offset: 0000
        public int[] Category;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Category = new int[8];
            Category[0] = parser.ReadOffset< int >( 0x0 );
            Category[1] = parser.ReadOffset< int >( 0x4 );
            Category[2] = parser.ReadOffset< int >( 0x8 );
            Category[3] = parser.ReadOffset< int >( 0xc );
            Category[4] = parser.ReadOffset< int >( 0x10 );
            Category[5] = parser.ReadOffset< int >( 0x14 );
            Category[6] = parser.ReadOffset< int >( 0x18 );
            Category[7] = parser.ReadOffset< int >( 0x1c );


        }
    }
}