namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Level", columnHash: 0xd3d8d868 )]
    public class Level : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: X
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Y
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Z
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: Yaw
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: Radius
         *  type: 
         */

        /* offset: 0020 col: 5
         *  name: Type
         *  type: 
         */

        /* offset: 0014 col: 6
         *  name: Object
         *  type: 
         */

        /* offset: 001c col: 7
         *  name: Map
         *  type: 
         */

        /* offset: 0018 col: 8
         *  name: EventId
         *  type: 
         */

        /* offset: 001e col: 9
         *  name: Territory
         *  type: 
         */



        // col: 00 offset: 0000
        public float X;

        // col: 01 offset: 0004
        public float Y;

        // col: 02 offset: 0008
        public float Z;

        // col: 03 offset: 000c
        public float Yaw;

        // col: 04 offset: 0010
        public float Radius;

        // col: 06 offset: 0014
        public uint Object;

        // col: 08 offset: 0018
        public uint EventId;

        // col: 07 offset: 001c
        public ushort Map;

        // col: 09 offset: 001e
        public ushort Territory;

        // col: 05 offset: 0020
        public byte Type;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            X = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            Y = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            Z = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            Yaw = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            Radius = parser.ReadOffset< float >( 0x10 );

            // col: 6 offset: 0014
            Object = parser.ReadOffset< uint >( 0x14 );

            // col: 8 offset: 0018
            EventId = parser.ReadOffset< uint >( 0x18 );

            // col: 7 offset: 001c
            Map = parser.ReadOffset< ushort >( 0x1c );

            // col: 9 offset: 001e
            Territory = parser.ReadOffset< ushort >( 0x1e );

            // col: 5 offset: 0020
            Type = parser.ReadOffset< byte >( 0x20 );


        }
    }
}