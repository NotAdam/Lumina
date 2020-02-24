namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YKW", columnHash: 0xa866cd57 )]
    public class YKW : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0008 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 1
         *  name: Item
         *  type: 
         */

        /* offset: 000a col: 2
         *  name: Location
         *  repeat count: 3
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 5
         *  no SaintCoinach definition found
         */



        // col: 05 offset: 0000
        public string unknown0;

        // col: 01 offset: 0004
        public uint Item;

        // col: 00 offset: 0008
        public ushort unknown8;

        // col: 02 offset: 000a
        public ushort[] Location;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Item = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000a
            Location = new ushort[3];
            Location[0] = parser.ReadOffset< ushort >( 0xa );
            Location[1] = parser.ReadOffset< ushort >( 0xc );
            Location[2] = parser.ReadOffset< ushort >( 0xe );


        }
    }
}