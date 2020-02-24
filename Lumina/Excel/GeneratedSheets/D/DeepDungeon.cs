namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeon", columnHash: 0xea7a6143 )]
    public class DeepDungeon : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 001a col: 0
         *  name: AetherpoolArm
         *  type: 
         */

        /* offset: 001b col: 1
         *  name: AetherpoolArmor
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: PomanderSlot
         *  repeat count: 16
         */

        /* offset: 0001 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0002 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0003 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0005 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0007 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0009 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 000b col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 18
         *  name: MagiciteSlot
         *  repeat count: 4
         */

        /* offset: 0011 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 22
         *  name: Name
         *  type: 
         */

        /* offset: 0018 col: 23
         *  name: ContentFinderCondition{Start}
         *  type: 
         */

        /* offset: 001c col: 24
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public byte[] PomanderSlot;

        // col: 18 offset: 0010
        public byte[] MagiciteSlot;

        // col: 22 offset: 0014
        public string Name;

        // col: 23 offset: 0018
        public ushort ContentFinderConditionStart;

        // col: 00 offset: 001a
        public byte AetherpoolArm;

        // col: 01 offset: 001b
        public byte AetherpoolArmor;

        // col: 24 offset: 001c
        private byte packed1c;
        public bool packed1c_1 => ( packed1c & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            PomanderSlot = new byte[16];
            PomanderSlot[0] = parser.ReadOffset< byte >( 0x0 );
            PomanderSlot[1] = parser.ReadOffset< byte >( 0x1 );
            PomanderSlot[2] = parser.ReadOffset< byte >( 0x2 );
            PomanderSlot[3] = parser.ReadOffset< byte >( 0x3 );
            PomanderSlot[4] = parser.ReadOffset< byte >( 0x4 );
            PomanderSlot[5] = parser.ReadOffset< byte >( 0x5 );
            PomanderSlot[6] = parser.ReadOffset< byte >( 0x6 );
            PomanderSlot[7] = parser.ReadOffset< byte >( 0x7 );
            PomanderSlot[8] = parser.ReadOffset< byte >( 0x8 );
            PomanderSlot[9] = parser.ReadOffset< byte >( 0x9 );
            PomanderSlot[10] = parser.ReadOffset< byte >( 0xa );
            PomanderSlot[11] = parser.ReadOffset< byte >( 0xb );
            PomanderSlot[12] = parser.ReadOffset< byte >( 0xc );
            PomanderSlot[13] = parser.ReadOffset< byte >( 0xd );
            PomanderSlot[14] = parser.ReadOffset< byte >( 0xe );
            PomanderSlot[15] = parser.ReadOffset< byte >( 0xf );

            // col: 18 offset: 0010
            MagiciteSlot = new byte[4];
            MagiciteSlot[0] = parser.ReadOffset< byte >( 0x10 );
            MagiciteSlot[1] = parser.ReadOffset< byte >( 0x11 );
            MagiciteSlot[2] = parser.ReadOffset< byte >( 0x12 );
            MagiciteSlot[3] = parser.ReadOffset< byte >( 0x13 );

            // col: 22 offset: 0014
            Name = parser.ReadOffset< string >( 0x14 );

            // col: 23 offset: 0018
            ContentFinderConditionStart = parser.ReadOffset< ushort >( 0x18 );

            // col: 0 offset: 001a
            AetherpoolArm = parser.ReadOffset< byte >( 0x1a );

            // col: 1 offset: 001b
            AetherpoolArmor = parser.ReadOffset< byte >( 0x1b );

            // col: 24 offset: 001c
            packed1c = parser.ReadOffset< byte >( 0x1c );


        }
    }
}