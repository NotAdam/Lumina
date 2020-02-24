namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraft", columnHash: 0xdf938294 )]
    public class CompanyCraftDraft : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0014 col: 1
         *  name: CompanyCraftDraftCategory
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: 
         *  repeat count: 3
         */

        /* offset: 0015 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 8
         *  name: Order
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 08 offset: 0004
        public uint Order;

        // col: 02 offset: 0008
        public int[] unknown8;

        // col: 06 offset: 0010
        public int unknown10;

        // col: 01 offset: 0014
        public byte CompanyCraftDraftCategory;

        // col: 05 offset: 0016
        public byte unknown16;

        // col: 07 offset: 0017
        public byte unknown17;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 8 offset: 0004
            Order = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = new int[3];
            unknown8[0] = parser.ReadOffset< int >( 0x8 );
            unknown8[1] = parser.ReadOffset< int >( 0x15 );
            unknown8[2] = parser.ReadOffset< int >( 0xc );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 1 offset: 0014
            CompanyCraftDraftCategory = parser.ReadOffset< byte >( 0x14 );

            // col: 5 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 7 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );


        }
    }
}