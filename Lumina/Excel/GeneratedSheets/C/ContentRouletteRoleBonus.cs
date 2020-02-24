namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteRoleBonus", columnHash: 0x8c1eab22 )]
    public class ContentRouletteRoleBonus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0008 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 6
         *  name: ItemRewardType
         *  type: 
         */

        /* offset: 0014 col: 7
         *  name: RewardAmount
         *  type: 
         */

        /* offset: 0016 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0015 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 11
         *  no SaintCoinach definition found
         */



        // col: 06 offset: 0000
        public uint ItemRewardType;

        // col: 09 offset: 0004
        public uint unknown4;

        // col: 00 offset: 0008
        public ushort unknown8;

        // col: 01 offset: 000a
        public ushort unknowna;

        // col: 02 offset: 000c
        public ushort unknownc;

        // col: 03 offset: 000e
        public ushort unknowne;

        // col: 04 offset: 0010
        public ushort unknown10;

        // col: 05 offset: 0012
        public ushort unknown12;

        // col: 07 offset: 0014
        public byte RewardAmount;

        // col: 10 offset: 0015
        public byte unknown15;

        // col: 08 offset: 0016
        public byte unknown16;

        // col: 11 offset: 0017
        public byte unknown17;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            ItemRewardType = parser.ReadOffset< uint >( 0x0 );

            // col: 9 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 1 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 3 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 4 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 5 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 7 offset: 0014
            RewardAmount = parser.ReadOffset< byte >( 0x14 );

            // col: 10 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 8 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 11 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );


        }
    }
}