namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
    public class ConfigKey : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  name: Label
         *  type: 
         */

        /* offset: 000a col: 1
         *  name: Param
         *  type: 
         */

        /* offset: 000b col: 2
         *  name: Platform
         *  type: 
         */

        /* offset: 000e col: 3
         *  name: Required
         *  type: 
         */

        /* offset: 000c col: 4
         *  name: Category
         *  type: 
         */

        /* offset: 0008 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 7
         *  name: Text
         *  type: 
         */



        // col: 07 offset: 0000
        public string Text;

        // col: 00 offset: 0004
        public string Label;

        // col: 05 offset: 0008
        public ushort unknown8;

        // col: 01 offset: 000a
        public byte Param;

        // col: 02 offset: 000b
        public byte Platform;

        // col: 04 offset: 000c
        public byte Category;

        // col: 06 offset: 000d
        public byte unknownd;

        // col: 03 offset: 000e
        private byte packede;
        public bool Required => ( packede & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Label = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 1 offset: 000a
            Param = parser.ReadOffset< byte >( 0xa );

            // col: 2 offset: 000b
            Platform = parser.ReadOffset< byte >( 0xb );

            // col: 4 offset: 000c
            Category = parser.ReadOffset< byte >( 0xc );

            // col: 6 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 3 offset: 000e
            packede = parser.ReadOffset< byte >( 0xe );


        }
    }
}