namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
    public class AnimaWeaponItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  repeat count: 14
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



        // col: 00 offset: 0000
        public uint[] Item;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = new uint[14];
            Item[0] = parser.ReadOffset< uint >( 0x0 );
            Item[1] = parser.ReadOffset< uint >( 0x4 );
            Item[2] = parser.ReadOffset< uint >( 0x8 );
            Item[3] = parser.ReadOffset< uint >( 0xc );
            Item[4] = parser.ReadOffset< uint >( 0x10 );
            Item[5] = parser.ReadOffset< uint >( 0x14 );
            Item[6] = parser.ReadOffset< uint >( 0x18 );
            Item[7] = parser.ReadOffset< uint >( 0x1c );
            Item[8] = parser.ReadOffset< uint >( 0x20 );
            Item[9] = parser.ReadOffset< uint >( 0x24 );
            Item[10] = parser.ReadOffset< uint >( 0x28 );
            Item[11] = parser.ReadOffset< uint >( 0x2c );
            Item[12] = parser.ReadOffset< uint >( 0x30 );
            Item[13] = parser.ReadOffset< uint >( 0x34 );


        }
    }
}