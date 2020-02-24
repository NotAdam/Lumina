namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Knockback", columnHash: 0x6876beaf )]
    public class Knockback : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Distance
         *  type: 
         */

        /* offset: 0001 col: 1
         *  name: Speed
         *  type: 
         */

        /* offset: 0005 col: 2
         *  name: Motion
         *  type: 
         */

        /* offset: 0002 col: 3
         *  name: NearDistance
         *  type: 
         */

        /* offset: 0003 col: 4
         *  name: Direction
         *  type: 
         */

        /* offset: 0004 col: 5
         *  name: DirectionArg
         *  type: 
         */

        /* offset: 0005 col: 6
         *  name: CancelMove
         *  type: 
         */



        // col: 00 offset: 0000
        public byte Distance;

        // col: 01 offset: 0001
        public byte Speed;

        // col: 03 offset: 0002
        public byte NearDistance;

        // col: 04 offset: 0003
        public byte Direction;

        // col: 05 offset: 0004
        public byte DirectionArg;

        // col: 02 offset: 0005
        private byte packed5;
        public bool Motion => ( packed5 & 0x1 ) == 0x1;
        public bool CancelMove => ( packed5 & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Distance = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Speed = parser.ReadOffset< byte >( 0x1 );

            // col: 3 offset: 0002
            NearDistance = parser.ReadOffset< byte >( 0x2 );

            // col: 4 offset: 0003
            Direction = parser.ReadOffset< byte >( 0x3 );

            // col: 5 offset: 0004
            DirectionArg = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5 );


        }
    }
}