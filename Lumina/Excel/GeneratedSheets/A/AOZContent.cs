namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContent", columnHash: 0x615a9876 )]
    public class AOZContent : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 000c col: 0
         *  name: StandardFinishTime
         *  type: 
         */

        /* offset: 000e col: 1
         *  name: IdealFinishTime
         *  type: 
         */

        /* offset: 0016 col: 2
         *  name: Act1FightType
         *  type: 
         */

        /* offset: 0010 col: 3
         *  name: Act1
         *  type: 
         */

        /* offset: 0019 col: 4
         *  name: ArenaType[1]
         *  type: 
         */

        /* offset: 0017 col: 5
         *  name: Act2FightType
         *  type: 
         */

        /* offset: 0012 col: 6
         *  name: Act2
         *  type: 
         */

        /* offset: 001a col: 7
         *  name: ArenaType[2]
         *  type: 
         */

        /* offset: 0018 col: 8
         *  name: Act3FightType
         *  type: 
         */

        /* offset: 0014 col: 9
         *  name: Act3
         *  type: 
         */

        /* offset: 001b col: 10
         *  name: ArenaType[3]
         *  type: 
         */

        /* offset: 0008 col: 11
         *  name: ContentEntry
         *  type: 
         */

        /* offset: 001c col: 12
         *  name: Order
         *  type: 
         */

        /* offset: 0000 col: 13
         *  name: GilReward
         *  type: 
         */

        /* offset: 0002 col: 14
         *  name: AlliedSealsReward
         *  type: 
         */

        /* offset: 0004 col: 15
         *  name: TomestonesReward
         *  type: 
         */



        // col: 13 offset: 0000
        public ushort GilReward;

        // col: 14 offset: 0002
        public ushort AlliedSealsReward;

        // col: 15 offset: 0004
        public ushort TomestonesReward;

        // col: 11 offset: 0008
        public uint ContentEntry;

        // col: 00 offset: 000c
        public ushort StandardFinishTime;

        // col: 01 offset: 000e
        public ushort IdealFinishTime;

        // col: 03 offset: 0010
        public ushort Act1;

        // col: 06 offset: 0012
        public ushort Act2;

        // col: 09 offset: 0014
        public ushort Act3;

        // col: 02 offset: 0016
        public byte Act1FightType;

        // col: 05 offset: 0017
        public byte Act2FightType;

        // col: 08 offset: 0018
        public byte Act3FightType;

        // col: 04 offset: 0019
        public byte ArenaType1;

        // col: 07 offset: 001a
        public byte ArenaType2;

        // col: 10 offset: 001b
        public byte ArenaType3;

        // col: 12 offset: 001c
        public byte Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 13 offset: 0000
            GilReward = parser.ReadOffset< ushort >( 0x0 );

            // col: 14 offset: 0002
            AlliedSealsReward = parser.ReadOffset< ushort >( 0x2 );

            // col: 15 offset: 0004
            TomestonesReward = parser.ReadOffset< ushort >( 0x4 );

            // col: 11 offset: 0008
            ContentEntry = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            StandardFinishTime = parser.ReadOffset< ushort >( 0xc );

            // col: 1 offset: 000e
            IdealFinishTime = parser.ReadOffset< ushort >( 0xe );

            // col: 3 offset: 0010
            Act1 = parser.ReadOffset< ushort >( 0x10 );

            // col: 6 offset: 0012
            Act2 = parser.ReadOffset< ushort >( 0x12 );

            // col: 9 offset: 0014
            Act3 = parser.ReadOffset< ushort >( 0x14 );

            // col: 2 offset: 0016
            Act1FightType = parser.ReadOffset< byte >( 0x16 );

            // col: 5 offset: 0017
            Act2FightType = parser.ReadOffset< byte >( 0x17 );

            // col: 8 offset: 0018
            Act3FightType = parser.ReadOffset< byte >( 0x18 );

            // col: 4 offset: 0019
            ArenaType1 = parser.ReadOffset< byte >( 0x19 );

            // col: 7 offset: 001a
            ArenaType2 = parser.ReadOffset< byte >( 0x1a );

            // col: 10 offset: 001b
            ArenaType3 = parser.ReadOffset< byte >( 0x1b );

            // col: 12 offset: 001c
            Order = parser.ReadOffset< byte >( 0x1c );


        }
    }
}