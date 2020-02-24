namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxi", columnHash: 0x121fc5dc )]
    public class ChocoboTaxi : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Location
         *  type: 
         */

        /* offset: 0006 col: 1
         *  name: Fare
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: TimeRequired
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Location;

        // col: 02 offset: 0004
        public ushort TimeRequired;

        // col: 01 offset: 0006
        public byte Fare;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Location = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            TimeRequired = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            Fare = parser.ReadOffset< byte >( 0x6 );


        }
    }
}