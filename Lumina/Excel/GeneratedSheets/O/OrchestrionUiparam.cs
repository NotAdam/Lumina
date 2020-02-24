namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionUiparam", columnHash: 0xd73eab80 )]
    public class OrchestrionUiparam : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0002 col: 0
         *  name: OrchestrionCategory
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Order
         *  type: 
         */



        // col: 01 offset: 0000
        public ushort Order;

        // col: 00 offset: 0002
        public byte OrchestrionCategory;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Order = parser.ReadOffset< ushort >( 0x0 );

            // col: 0 offset: 0002
            OrchestrionCategory = parser.ReadOffset< byte >( 0x2 );


        }
    }
}