namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemHelp", columnHash: 0x8e477c70 )]
    public class EventItemHelp : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Description
         *  type: 
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Description;

        // col: 01 offset: 0004
        private byte packed4;
        public bool packed4_1 => ( packed4 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Description = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}