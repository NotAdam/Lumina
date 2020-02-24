namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
    public class ChocoboRaceStatus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Status
         *  type: 
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int Status;

        // col: 01 offset: 0004
        public ushort unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Status = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}