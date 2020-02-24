namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionSection", columnHash: 0x2020acf6 )]
    public class DescriptionSection : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 0000 col: 0
         *  name: String
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: Page
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort String;

        // col: 01 offset: 0002
        public ushort Page;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            String = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            Page = parser.ReadOffset< ushort >( 0x2 );


        }
    }
}