namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeOfficer", columnHash: 0xef9733d1 )]
    public class DpsChallengeOfficer : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0034 col: 0
         *  name: UnlockQuest
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: ChallengeName
         *  repeat count: 25
         */

        /* offset: 0002 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 001e col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 002a col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 25
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public ushort[] ChallengeName;

        // col: 00 offset: 0034
        public uint UnlockQuest;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ChallengeName = new ushort[25];
            ChallengeName[0] = parser.ReadOffset< ushort >( 0x0 );
            ChallengeName[1] = parser.ReadOffset< ushort >( 0x2 );
            ChallengeName[2] = parser.ReadOffset< ushort >( 0x4 );
            ChallengeName[3] = parser.ReadOffset< ushort >( 0x6 );
            ChallengeName[4] = parser.ReadOffset< ushort >( 0x8 );
            ChallengeName[5] = parser.ReadOffset< ushort >( 0xa );
            ChallengeName[6] = parser.ReadOffset< ushort >( 0xc );
            ChallengeName[7] = parser.ReadOffset< ushort >( 0xe );
            ChallengeName[8] = parser.ReadOffset< ushort >( 0x10 );
            ChallengeName[9] = parser.ReadOffset< ushort >( 0x12 );
            ChallengeName[10] = parser.ReadOffset< ushort >( 0x14 );
            ChallengeName[11] = parser.ReadOffset< ushort >( 0x16 );
            ChallengeName[12] = parser.ReadOffset< ushort >( 0x18 );
            ChallengeName[13] = parser.ReadOffset< ushort >( 0x1a );
            ChallengeName[14] = parser.ReadOffset< ushort >( 0x1c );
            ChallengeName[15] = parser.ReadOffset< ushort >( 0x1e );
            ChallengeName[16] = parser.ReadOffset< ushort >( 0x20 );
            ChallengeName[17] = parser.ReadOffset< ushort >( 0x22 );
            ChallengeName[18] = parser.ReadOffset< ushort >( 0x24 );
            ChallengeName[19] = parser.ReadOffset< ushort >( 0x26 );
            ChallengeName[20] = parser.ReadOffset< ushort >( 0x28 );
            ChallengeName[21] = parser.ReadOffset< ushort >( 0x2a );
            ChallengeName[22] = parser.ReadOffset< ushort >( 0x2c );
            ChallengeName[23] = parser.ReadOffset< ushort >( 0x2e );
            ChallengeName[24] = parser.ReadOffset< ushort >( 0x30 );

            // col: 0 offset: 0034
            UnlockQuest = parser.ReadOffset< uint >( 0x34 );


        }
    }
}