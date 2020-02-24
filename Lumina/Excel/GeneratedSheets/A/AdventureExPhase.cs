namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AdventureExPhase", columnHash: 0x2ebeea9f )]
    public class AdventureExPhase : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Quest
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Adventure{Begin}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Adventure{End}
         *  type: 
         */

        /* offset: 0010 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Quest;

        // col: 01 offset: 0004
        public uint AdventureBegin;

        // col: 02 offset: 0008
        public uint AdventureEnd;

        // col: 04 offset: 000c
        public uint unknownc;

        // col: 03 offset: 0010
        public byte unknown10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            AdventureBegin = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            AdventureEnd = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 3 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );


        }
    }
}