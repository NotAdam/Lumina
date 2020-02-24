namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveTimeline", columnHash: 0xf057da9c )]
    public class MoveTimeline : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Idle
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: MoveForward
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: MoveBack
         *  type: 
         */

        /* offset: 0006 col: 3
         *  name: MoveLeft
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: MoveRight
         *  type: 
         */

        /* offset: 000a col: 5
         *  name: MoveUp
         *  type: 
         */

        /* offset: 000c col: 6
         *  name: MoveDown
         *  type: 
         */

        /* offset: 000e col: 7
         *  name: MoveTurnLeft
         *  type: 
         */

        /* offset: 0010 col: 8
         *  name: MoveTurnRight
         *  type: 
         */

        /* offset: 0012 col: 9
         *  name: Extra
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort Idle;

        // col: 01 offset: 0002
        public ushort MoveForward;

        // col: 02 offset: 0004
        public ushort MoveBack;

        // col: 03 offset: 0006
        public ushort MoveLeft;

        // col: 04 offset: 0008
        public ushort MoveRight;

        // col: 05 offset: 000a
        public ushort MoveUp;

        // col: 06 offset: 000c
        public ushort MoveDown;

        // col: 07 offset: 000e
        public ushort MoveTurnLeft;

        // col: 08 offset: 0010
        public ushort MoveTurnRight;

        // col: 09 offset: 0012
        public ushort Extra;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Idle = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            MoveForward = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            MoveBack = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            MoveLeft = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            MoveRight = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            MoveUp = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            MoveDown = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            MoveTurnLeft = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            MoveTurnRight = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            Extra = parser.ReadOffset< ushort >( 0x12 );


        }
    }
}