namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
    public class BuddyItem : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  type: 
         */

        /* offset: 0003 col: 1
         *  name: UseField
         *  type: 
         */

        /* offset: 0003 col: 2
         *  name: UseTraining
         *  type: 
         */

        /* offset: 0003 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0002 col: 4
         *  name: Status
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort Item;

        // col: 04 offset: 0002
        public byte Status;

        // col: 01 offset: 0003
        private byte packed3;
        public bool UseField => ( packed3 & 0x1 ) == 0x1;
        public bool UseTraining => ( packed3 & 0x2 ) == 0x2;
        public bool packed3_4 => ( packed3 & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< ushort >( 0x0 );

            // col: 4 offset: 0002
            Status = parser.ReadOffset< byte >( 0x2 );

            // col: 1 offset: 0003
            packed3 = parser.ReadOffset< byte >( 0x3 );


        }
    }
}