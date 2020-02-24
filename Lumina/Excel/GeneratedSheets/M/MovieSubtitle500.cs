namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieSubtitle500", columnHash: 0x07f99ad3 )]
    public class MovieSubtitle500 : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: StartTime
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: EndTime
         *  type: 
         */



        // col: 00 offset: 0000
        public float StartTime;

        // col: 01 offset: 0004
        public float EndTime;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            StartTime = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            EndTime = parser.ReadOffset< float >( 0x4 );


        }
    }
}