namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbilityType", columnHash: 0xcd4cb81c )]
    public class ChocoboRaceAbilityType : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: IsActive
         *  type: 
         */



        // col: 00 offset: 0000
        private byte packed0;
        public bool IsActive => ( packed0 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0 );


        }
    }
}