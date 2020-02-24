namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureModel", columnHash: 0xdebb20e3 )]
    public class TreasureModel : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 0000 col: 0
         *  name: Path
         *  type: 
         */



        // col: 00 offset: 0000
        public string Path;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Path = parser.ReadOffset< string >( 0x0 );


        }
    }
}