namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VaseFlower", columnHash: 0x8c05af34 )]
    public class VaseFlower : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0007 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 3
         *  name: Item
         *  type: 
         */



        // col: 03 offset: 0000
        public uint Item;

        // col: 00 offset: 0004
        public ushort unknown4;

        // col: 01 offset: 0006
        public byte unknown6;

        // col: 02 offset: 0007
        public byte unknown7;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 2 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );


        }
    }
}