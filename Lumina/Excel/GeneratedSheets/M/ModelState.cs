namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelState", columnHash: 0xd73eab80 )]
    public class ModelState : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT

        /* offset: 0002 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Start
         *  type: 
         */



        // col: 01 offset: 0000
        public ushort Start;

        // col: 00 offset: 0002
        public byte unknown2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Start = parser.ReadOffset< ushort >( 0x0 );

            // col: 0 offset: 0002
            unknown2 = parser.ReadOffset< byte >( 0x2 );


        }
    }
}