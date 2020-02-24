namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarinePart", columnHash: 0xc971f464 )]
    public class SubmarinePart : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 000c col: 0
         *  name: Slot
         *  type: 
         */

        /* offset: 000d col: 1
         *  name: Rank
         *  type: 
         */

        /* offset: 000e col: 2
         *  name: Components
         *  type: 
         */

        /* offset: 0002 col: 3
         *  name: Surveillance
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: Retrieval
         *  type: 
         */

        /* offset: 0006 col: 5
         *  name: Speed
         *  type: 
         */

        /* offset: 0008 col: 6
         *  name: Range
         *  type: 
         */

        /* offset: 000a col: 7
         *  name: Favor
         *  type: 
         */

        /* offset: 0000 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 000f col: 9
         *  name: RepairMaterials
         *  type: 
         */



        // col: 08 offset: 0000
        public ushort unknown0;

        // col: 03 offset: 0002
        public short Surveillance;

        // col: 04 offset: 0004
        public short Retrieval;

        // col: 05 offset: 0006
        public short Speed;

        // col: 06 offset: 0008
        public short Range;

        // col: 07 offset: 000a
        public short Favor;

        // col: 00 offset: 000c
        public byte Slot;

        // col: 01 offset: 000d
        public byte Rank;

        // col: 02 offset: 000e
        public byte Components;

        // col: 09 offset: 000f
        public byte RepairMaterials;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            Surveillance = parser.ReadOffset< short >( 0x2 );

            // col: 4 offset: 0004
            Retrieval = parser.ReadOffset< short >( 0x4 );

            // col: 5 offset: 0006
            Speed = parser.ReadOffset< short >( 0x6 );

            // col: 6 offset: 0008
            Range = parser.ReadOffset< short >( 0x8 );

            // col: 7 offset: 000a
            Favor = parser.ReadOffset< short >( 0xa );

            // col: 0 offset: 000c
            Slot = parser.ReadOffset< byte >( 0xc );

            // col: 1 offset: 000d
            Rank = parser.ReadOffset< byte >( 0xd );

            // col: 2 offset: 000e
            Components = parser.ReadOffset< byte >( 0xe );

            // col: 9 offset: 000f
            RepairMaterials = parser.ReadOffset< byte >( 0xf );


        }
    }
}