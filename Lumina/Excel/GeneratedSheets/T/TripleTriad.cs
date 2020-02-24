namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriad", columnHash: 0x2f29903e )]
    public class TripleTriad : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0030 col: 0
         *  name: TripleTriadCard{Fixed}
         *  repeat count: 5
         */

        /* offset: 0032 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 003a col: 5
         *  name: TripleTriadCard{Variable}
         *  repeat count: 5
         */

        /* offset: 003c col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 003e col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0042 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 004a col: 10
         *  name: TripleTriadRule
         *  repeat count: 2
         */

        /* offset: 004b col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 004d col: 12
         *  name: UsesRegionalRules
         *  type: 
         */

        /* offset: 0044 col: 13
         *  name: Fee
         *  type: 
         */

        /* offset: 004c col: 14
         *  name: PreviousQuestJoin
         *  type: 
         */

        /* offset: 0010 col: 15
         *  name: PreviousQuest
         *  repeat count: 3
         */

        /* offset: 0014 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0046 col: 18
         *  name: StartTime
         *  type: 
         */

        /* offset: 0048 col: 19
         *  name: EndTime
         *  type: 
         */

        /* offset: 001c col: 20
         *  name: DefaultTalk{Challenge}
         *  type: 
         */

        /* offset: 0020 col: 21
         *  name: DefaultTalk{Unavailable}
         *  type: 
         */

        /* offset: 0024 col: 22
         *  name: DefaultTalk{NPCWin}
         *  type: 
         */

        /* offset: 0028 col: 23
         *  name: DefaultTalk{Draw}
         *  type: 
         */

        /* offset: 002c col: 24
         *  name: DefaultTalk{PCWin}
         *  type: 
         */

        /* offset: 004d col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 26
         *  name: Item{PossibleReward}
         *  repeat count: 4
         */

        /* offset: 0004 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 29
         *  no SaintCoinach definition found
         */



        // col: 26 offset: 0000
        public uint[] ItemPossibleReward;

        // col: 15 offset: 0010
        public uint[] PreviousQuest;

        // col: 20 offset: 001c
        public uint DefaultTalkChallenge;

        // col: 21 offset: 0020
        public uint DefaultTalkUnavailable;

        // col: 22 offset: 0024
        public uint DefaultTalkNPCWin;

        // col: 23 offset: 0028
        public uint DefaultTalkDraw;

        // col: 24 offset: 002c
        public uint DefaultTalkPCWin;

        // col: 00 offset: 0030
        public ushort[] TripleTriadCardFixed;

        // col: 05 offset: 003a
        public ushort[] TripleTriadCardVariable;

        // col: 13 offset: 0044
        public ushort Fee;

        // col: 18 offset: 0046
        public ushort StartTime;

        // col: 19 offset: 0048
        public ushort EndTime;

        // col: 10 offset: 004a
        public byte[] TripleTriadRule;

        // col: 14 offset: 004c
        public byte PreviousQuestJoin;

        // col: 12 offset: 004d
        private byte packed4d;
        public bool UsesRegionalRules => ( packed4d & 0x1 ) == 0x1;
        public bool packed4d_2 => ( packed4d & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 26 offset: 0000
            ItemPossibleReward = new uint[4];
            ItemPossibleReward[0] = parser.ReadOffset< uint >( 0x0 );
            ItemPossibleReward[1] = parser.ReadOffset< uint >( 0x4 );
            ItemPossibleReward[2] = parser.ReadOffset< uint >( 0x8 );
            ItemPossibleReward[3] = parser.ReadOffset< uint >( 0xc );

            // col: 15 offset: 0010
            PreviousQuest = new uint[3];
            PreviousQuest[0] = parser.ReadOffset< uint >( 0x10 );
            PreviousQuest[1] = parser.ReadOffset< uint >( 0x14 );
            PreviousQuest[2] = parser.ReadOffset< uint >( 0x18 );

            // col: 20 offset: 001c
            DefaultTalkChallenge = parser.ReadOffset< uint >( 0x1c );

            // col: 21 offset: 0020
            DefaultTalkUnavailable = parser.ReadOffset< uint >( 0x20 );

            // col: 22 offset: 0024
            DefaultTalkNPCWin = parser.ReadOffset< uint >( 0x24 );

            // col: 23 offset: 0028
            DefaultTalkDraw = parser.ReadOffset< uint >( 0x28 );

            // col: 24 offset: 002c
            DefaultTalkPCWin = parser.ReadOffset< uint >( 0x2c );

            // col: 0 offset: 0030
            TripleTriadCardFixed = new ushort[5];
            TripleTriadCardFixed[0] = parser.ReadOffset< ushort >( 0x30 );
            TripleTriadCardFixed[1] = parser.ReadOffset< ushort >( 0x32 );
            TripleTriadCardFixed[2] = parser.ReadOffset< ushort >( 0x34 );
            TripleTriadCardFixed[3] = parser.ReadOffset< ushort >( 0x36 );
            TripleTriadCardFixed[4] = parser.ReadOffset< ushort >( 0x38 );

            // col: 5 offset: 003a
            TripleTriadCardVariable = new ushort[5];
            TripleTriadCardVariable[0] = parser.ReadOffset< ushort >( 0x3a );
            TripleTriadCardVariable[1] = parser.ReadOffset< ushort >( 0x3c );
            TripleTriadCardVariable[2] = parser.ReadOffset< ushort >( 0x3e );
            TripleTriadCardVariable[3] = parser.ReadOffset< ushort >( 0x40 );
            TripleTriadCardVariable[4] = parser.ReadOffset< ushort >( 0x42 );

            // col: 13 offset: 0044
            Fee = parser.ReadOffset< ushort >( 0x44 );

            // col: 18 offset: 0046
            StartTime = parser.ReadOffset< ushort >( 0x46 );

            // col: 19 offset: 0048
            EndTime = parser.ReadOffset< ushort >( 0x48 );

            // col: 10 offset: 004a
            TripleTriadRule = new byte[2];
            TripleTriadRule[0] = parser.ReadOffset< byte >( 0x4a );
            TripleTriadRule[1] = parser.ReadOffset< byte >( 0x4b );

            // col: 14 offset: 004c
            PreviousQuestJoin = parser.ReadOffset< byte >( 0x4c );

            // col: 12 offset: 004d
            packed4d = parser.ReadOffset< byte >( 0x4d );


        }
    }
}