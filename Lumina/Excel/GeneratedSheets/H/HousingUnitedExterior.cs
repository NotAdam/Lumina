namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingUnitedExterior", columnHash: 0x88a791a7 )]
    public class HousingUnitedExterior : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0020 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Item
         *  repeat count: 8
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
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



        // col: 01 offset: 0000
        public uint[] Item;

        // col: 00 offset: 0020
        public byte unknown20;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Item = new uint[8];
            Item[0] = parser.ReadOffset< uint >( 0x0 );
            Item[1] = parser.ReadOffset< uint >( 0x4 );
            Item[2] = parser.ReadOffset< uint >( 0x8 );
            Item[3] = parser.ReadOffset< uint >( 0xc );
            Item[4] = parser.ReadOffset< uint >( 0x10 );
            Item[5] = parser.ReadOffset< uint >( 0x14 );
            Item[6] = parser.ReadOffset< uint >( 0x18 );
            Item[7] = parser.ReadOffset< uint >( 0x1c );

            // col: 0 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );


        }
    }
}