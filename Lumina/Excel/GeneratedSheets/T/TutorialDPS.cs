namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TutorialDPS", columnHash: 0xdcfd9eba )]
    public class TutorialDPS : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Objective
         *  type: 
         */



        // col: 00 offset: 0000
        public byte Objective;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Objective = parser.ReadOffset< byte >( 0x0 );


        }
    }
}