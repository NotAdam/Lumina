namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContentCandidateName", columnHash: 0xdebb20e3 )]
    public class OpenContentCandidateName : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );


        }
    }
}