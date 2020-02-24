namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CircleActivity", columnHash: 0x1a6ae0b3 )]
    public class CircleActivity : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Icon
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Order
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public int Icon;

        // col: 02 offset: 0008
        public ushort Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            Order = parser.ReadOffset< ushort >( 0x8 );


        }
    }
}