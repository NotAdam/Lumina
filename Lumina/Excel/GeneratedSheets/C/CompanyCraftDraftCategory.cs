namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public class CompanyCraftDraftCategory : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: 
         *  repeat count: 10
         */

        /* offset: 0006 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 10
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public ushort[] unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = new ushort[10];
            unknown4[0] = parser.ReadOffset< ushort >( 0x4 );
            unknown4[1] = parser.ReadOffset< ushort >( 0x6 );
            unknown4[2] = parser.ReadOffset< ushort >( 0x8 );
            unknown4[3] = parser.ReadOffset< ushort >( 0xa );
            unknown4[4] = parser.ReadOffset< ushort >( 0xc );
            unknown4[5] = parser.ReadOffset< ushort >( 0xe );
            unknown4[6] = parser.ReadOffset< ushort >( 0x10 );
            unknown4[7] = parser.ReadOffset< ushort >( 0x12 );
            unknown4[8] = parser.ReadOffset< ushort >( 0x14 );
            unknown4[9] = parser.ReadOffset< ushort >( 0x16 );


        }
    }
}