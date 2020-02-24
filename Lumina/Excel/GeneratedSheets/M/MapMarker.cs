namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapMarker", columnHash: 0x58f22163 )]
    public class MapMarker : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0006 col: 0
         *  name: X
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Y
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: Icon
         *  type: 
         */

        /* offset: 0002 col: 3
         *  name: PlaceName{Subtext}
         *  type: 
         */

        /* offset: 000a col: 4
         *  name: SubtextOrientation
         *  type: 
         */

        /* offset: 000b col: 5
         *  name: MapMarkerRegion
         *  type: 
         */

        /* offset: 000c col: 6
         *  name: Type
         *  type: 
         */

        /* offset: 000d col: 7
         *  name: Data{Type}
         *  type: 
         */

        /* offset: 0004 col: 8
         *  name: Data{Key}
         *  type: 
         */

        /* offset: 000e col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 10
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public ushort Icon;

        // col: 03 offset: 0002
        public ushort PlaceNameSubtext;

        // col: 08 offset: 0004
        public ushort DataKey;

        // col: 00 offset: 0006
        public short X;

        // col: 01 offset: 0008
        public short Y;

        // col: 04 offset: 000a
        public byte SubtextOrientation;

        // col: 05 offset: 000b
        public byte MapMarkerRegion;

        // col: 06 offset: 000c
        public byte Type;

        // col: 07 offset: 000d
        public byte DataType;

        // col: 09 offset: 000e
        public byte unknowne;

        // col: 10 offset: 000f
        public byte unknownf;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Icon = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            PlaceNameSubtext = parser.ReadOffset< ushort >( 0x2 );

            // col: 8 offset: 0004
            DataKey = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            X = parser.ReadOffset< short >( 0x6 );

            // col: 1 offset: 0008
            Y = parser.ReadOffset< short >( 0x8 );

            // col: 4 offset: 000a
            SubtextOrientation = parser.ReadOffset< byte >( 0xa );

            // col: 5 offset: 000b
            MapMarkerRegion = parser.ReadOffset< byte >( 0xb );

            // col: 6 offset: 000c
            Type = parser.ReadOffset< byte >( 0xc );

            // col: 7 offset: 000d
            DataType = parser.ReadOffset< byte >( 0xd );

            // col: 9 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 10 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );


        }
    }
}