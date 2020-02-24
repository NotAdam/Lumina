namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DefaultTalk", columnHash: 0xe6dec88d )]
    public class DefaultTalk : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0024 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 5
         *  name: ActionTimeline{Pose}
         *  repeat count: 3
         */

        /* offset: 0008 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0005 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0015 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0002 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0007 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 20
         *  name: Text
         *  repeat count: 3
         */

        /* offset: 001c col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 22
         *  no SaintCoinach definition found
         */



        // col: 05 offset: 0000
        public ushort[] ActionTimelinePose;

        // col: 11 offset: 0002
        public ushort unknown2;

        // col: 02 offset: 0004
        public byte unknown4;

        // col: 08 offset: 0005
        public byte unknown5;

        // col: 14 offset: 0006
        public byte unknown6;

        // col: 17 offset: 0007
        private byte packed7;
        public bool packed7_1 => ( packed7 & 0x1 ) == 0x1;

        // col: 12 offset: 000a
        public ushort unknowna;

        // col: 03 offset: 000c
        public byte unknownc;

        // col: 09 offset: 000d
        public byte unknownd;

        // col: 15 offset: 000e
        public byte unknowne;

        // col: 18 offset: 000f
        private byte packedf;
        public bool packedf_1 => ( packedf & 0x1 ) == 0x1;

        // col: 13 offset: 0012
        public ushort unknown12;

        // col: 04 offset: 0014
        public byte unknown14;

        // col: 10 offset: 0015
        public byte unknown15;

        // col: 16 offset: 0016
        public byte unknown16;

        // col: 19 offset: 0017
        private byte packed17;
        public bool packed17_1 => ( packed17 & 0x1 ) == 0x1;

        // col: 20 offset: 0018
        public string[] Text;

        // col: 00 offset: 0024
        public uint unknown24;

        // col: 01 offset: 0028
        public byte unknown28;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            ActionTimelinePose = new ushort[3];
            ActionTimelinePose[0] = parser.ReadOffset< ushort >( 0x0 );
            ActionTimelinePose[1] = parser.ReadOffset< ushort >( 0x8 );
            ActionTimelinePose[2] = parser.ReadOffset< ushort >( 0x10 );

            // col: 11 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 8 offset: 0005
            unknown5 = parser.ReadOffset< byte >( 0x5 );

            // col: 14 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 17 offset: 0007
            packed7 = parser.ReadOffset< byte >( 0x7 );

            // col: 12 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 9 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 15 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 18 offset: 000f
            packedf = parser.ReadOffset< byte >( 0xf );

            // col: 13 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 4 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 10 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 16 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 19 offset: 0017
            packed17 = parser.ReadOffset< byte >( 0x17 );

            // col: 20 offset: 0018
            Text = new string[3];
            Text[0] = parser.ReadOffset< string >( 0x18 );
            Text[1] = parser.ReadOffset< string >( 0x1c );
            Text[2] = parser.ReadOffset< string >( 0x20 );

            // col: 0 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 1 offset: 0028
            unknown28 = parser.ReadOffset< byte >( 0x28 );


        }
    }
}