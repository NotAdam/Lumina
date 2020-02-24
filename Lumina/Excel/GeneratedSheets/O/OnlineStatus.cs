namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OnlineStatus", columnHash: 0xd87db84c )]
    public class OnlineStatus : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0009 col: 0
         *  name: List
         *  type: 
         */

        /* offset: 0009 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  name: Priority
         *  type: 
         */

        /* offset: 0000 col: 3
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: Icon
         *  type: 
         */



        // col: 03 offset: 0000
        public string Name;

        // col: 04 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public byte Priority;

        // col: 00 offset: 0009
        private byte packed9;
        public bool List => ( packed9 & 0x1 ) == 0x1;
        public bool packed9_2 => ( packed9 & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Priority = parser.ReadOffset< byte >( 0x8 );

            // col: 0 offset: 0009
            packed9 = parser.ReadOffset< byte >( 0x9 );


        }
    }
}