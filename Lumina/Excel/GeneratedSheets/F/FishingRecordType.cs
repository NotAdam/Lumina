namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordType", columnHash: 0x2c75ba5d )]
    public class FishingRecordType : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT

        /* offset: 0000 col: 0
         *  name: Addon
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: RankBRequirement
         *  type: 
         */

        /* offset: 0006 col: 2
         *  name: RankARequirement
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: RankAARequirement
         *  type: 
         */

        /* offset: 000a col: 4
         *  name: RankAAARequirement
         *  type: 
         */

        /* offset: 000c col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 6
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int Addon;

        // col: 01 offset: 0004
        public ushort RankBRequirement;

        // col: 02 offset: 0006
        public ushort RankARequirement;

        // col: 03 offset: 0008
        public ushort RankAARequirement;

        // col: 04 offset: 000a
        public ushort RankAAARequirement;

        // col: 05 offset: 000c
        public ushort unknownc;

        // col: 06 offset: 000e
        public byte unknowne;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Addon = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            RankBRequirement = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            RankARequirement = parser.ReadOffset< ushort >( 0x6 );

            // col: 3 offset: 0008
            RankAARequirement = parser.ReadOffset< ushort >( 0x8 );

            // col: 4 offset: 000a
            RankAAARequirement = parser.ReadOffset< ushort >( 0xa );

            // col: 5 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 6 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );


        }
    }
}