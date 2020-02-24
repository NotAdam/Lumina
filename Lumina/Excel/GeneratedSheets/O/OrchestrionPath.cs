namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionPath", columnHash: 0xdebb20e3 )]
    public class OrchestrionPath : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: File
         *  type: 
         */



        // col: 00 offset: 0000
        public string File;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            File = parser.ReadOffset< string >( 0x0 );


        }
    }
}