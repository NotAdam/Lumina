namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GardeningSeed", columnHash: 0xa8a6cb9c )]
    public class GardeningSeed : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Item
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: ModelID
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Icon
         *  type: 
         */

        /* offset: 000b col: 3
         *  name: SE
         *  type: 
         */

        /* offset: 000b col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 5
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Item;

        // col: 02 offset: 0004
        public uint Icon;

        // col: 01 offset: 0008
        public ushort ModelID;

        // col: 05 offset: 000a
        public byte unknowna;

        // col: 03 offset: 000b
        private byte packedb;
        public bool SE => ( packedb & 0x1 ) == 0x1;
        public bool packedb_2 => ( packedb & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            ModelID = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 3 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb );


        }
    }
}