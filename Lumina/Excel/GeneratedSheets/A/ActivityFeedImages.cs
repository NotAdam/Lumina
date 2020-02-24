namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedImages", columnHash: 0x530c5199 )]
    public class ActivityFeedImages : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: ExpansionImage
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: ActivityFeedJA
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: ActivityFeedEN
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: ActivityFeedDE
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: ActivityFeedFR
         *  type: 
         */



        // col: 00 offset: 0000
        public string ExpansionImage;

        // col: 01 offset: 0004
        public string ActivityFeedJA;

        // col: 02 offset: 0008
        public string ActivityFeedEN;

        // col: 03 offset: 000c
        public string ActivityFeedDE;

        // col: 04 offset: 0010
        public string ActivityFeedFR;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ExpansionImage = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            ActivityFeedJA = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            ActivityFeedEN = parser.ReadOffset< string >( 0x8 );

            // col: 3 offset: 000c
            ActivityFeedDE = parser.ReadOffset< string >( 0xc );

            // col: 4 offset: 0010
            ActivityFeedFR = parser.ReadOffset< string >( 0x10 );


        }
    }
}