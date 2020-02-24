namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoRewardData", columnHash: 0x02b099a0 )]
    public class WeeklyBingoRewardData : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0012 col: 0
         *  name: 
         *  repeat count: 2
         */

        /* offset: 0000 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0015 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 10
         *  name: Reward{Item}[2]
         *  type: 
         */

        /* offset: 0017 col: 11
         *  name: Reward{HQ}[2]
         *  type: 
         */

        /* offset: 0010 col: 12
         *  name: Reward{Quantity}[2]
         *  type: 
         */



        // col: 06 offset: 0004
        public uint unknown4;

        // col: 10 offset: 0008
        public uint RewardItem2;

        // col: 03 offset: 000c
        public ushort unknownc;

        // col: 08 offset: 000e
        public ushort unknowne;

        // col: 12 offset: 0010
        public ushort RewardQuantity2;

        // col: 00 offset: 0012
        public byte[] unknown12;

        // col: 04 offset: 0013
        public byte unknown13;

        // col: 05 offset: 0014
        public byte unknown14;

        // col: 09 offset: 0015
        public byte unknown15;

        // col: 07 offset: 0016
        public bool unknown16;

        // col: 11 offset: 0017
        public bool RewardHQ2;

        // col: 02 offset: 0018
        private byte packed18;
        public bool packed18_1 => ( packed18 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 10 offset: 0008
            RewardItem2 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 12 offset: 0010
            RewardQuantity2 = parser.ReadOffset< ushort >( 0x10 );

            // col: 0 offset: 0012
            unknown12 = new byte[2];
            unknown12[0] = parser.ReadOffset< byte >( 0x12 );
            unknown12[1] = parser.ReadOffset< byte >( 0x0 );

            // col: 4 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 5 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 9 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 7 offset: 0016
            unknown16 = parser.ReadOffset< bool >( 0x16 );

            // col: 11 offset: 0017
            RewardHQ2 = parser.ReadOffset< bool >( 0x17 );

            // col: 2 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18 );


        }
    }
}