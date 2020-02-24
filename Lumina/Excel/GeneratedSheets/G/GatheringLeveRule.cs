namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRule", columnHash: 0xdebb20e3 )]
    public class GatheringLeveRule : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Rule
         *  type: 
         */



        // col: 00 offset: 0000
        public string Rule;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Rule = parser.ReadOffset< string >( 0x0 );


        }
    }
}