namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingPlacement", columnHash: 0xdebb20e3 )]
    public class HousingPlacement : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Text
         *  type: 
         */



        // col: 00 offset: 0000
        public string Text;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );


        }
    }
}