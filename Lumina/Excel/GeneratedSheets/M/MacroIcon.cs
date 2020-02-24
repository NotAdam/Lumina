namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIcon", columnHash: 0xda365c51 )]
    public class MacroIcon : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Icon
         *  type: 
         */



        // col: 00 offset: 0000
        public int Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );


        }
    }
}