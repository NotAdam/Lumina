namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpeditionMemberBonus", columnHash: 0xde74b4c4 )]
    public class GcArmyExpeditionMemberBonus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Race
         *  type: 
         */

        /* offset: 0001 col: 1
         *  name: ClassJob
         *  type: 
         */



        // col: 00 offset: 0000
        public byte Race;

        // col: 01 offset: 0001
        public byte ClassJob;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Race = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            ClassJob = parser.ReadOffset< byte >( 0x1 );


        }
    }
}