namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Ballista", columnHash: 0xcac0c160 )]
    public class Ballista : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: BNPC
         *  type: 
         */

        /* offset: 000f col: 1
         *  name: Near
         *  type: 
         */

        /* offset: 0010 col: 2
         *  name: Far
         *  type: 
         */

        /* offset: 0002 col: 3
         *  name: Angle
         *  type: 
         */

        /* offset: 000c col: 4
         *  name: Bullet
         *  type: 
         */

        /* offset: 000d col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 7
         *  name: Action[0]
         *  type: 
         */

        /* offset: 0006 col: 8
         *  name: Action[1]
         *  type: 
         */

        /* offset: 0008 col: 9
         *  name: Action[2]
         *  type: 
         */

        /* offset: 000a col: 10
         *  name: Action[3]
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort BNPC;

        // col: 03 offset: 0002
        public ushort Angle;

        // col: 07 offset: 0004
        public ushort Action0;

        // col: 08 offset: 0006
        public ushort Action1;

        // col: 09 offset: 0008
        public ushort Action2;

        // col: 10 offset: 000a
        public ushort Action3;

        // col: 04 offset: 000c
        public byte Bullet;

        // col: 05 offset: 000d
        public byte unknownd;

        // col: 06 offset: 000e
        public byte unknowne;

        // col: 01 offset: 000f
        public sbyte Near;

        // col: 02 offset: 0010
        public sbyte Far;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            BNPC = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            Angle = parser.ReadOffset< ushort >( 0x2 );

            // col: 7 offset: 0004
            Action0 = parser.ReadOffset< ushort >( 0x4 );

            // col: 8 offset: 0006
            Action1 = parser.ReadOffset< ushort >( 0x6 );

            // col: 9 offset: 0008
            Action2 = parser.ReadOffset< ushort >( 0x8 );

            // col: 10 offset: 000a
            Action3 = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            Bullet = parser.ReadOffset< byte >( 0xc );

            // col: 5 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 6 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 1 offset: 000f
            Near = parser.ReadOffset< sbyte >( 0xf );

            // col: 2 offset: 0010
            Far = parser.ReadOffset< sbyte >( 0x10 );


        }
    }
}