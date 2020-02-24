namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Guide", columnHash: 0x2020acf6 )]
    public class Guide : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT

        /* offset: 0000 col: 0
         *  name: GuideTitle
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: GuidePage
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort GuideTitle;

        // col: 01 offset: 0002
        public ushort GuidePage;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            GuideTitle = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            GuidePage = parser.ReadOffset< ushort >( 0x2 );


        }
    }
}