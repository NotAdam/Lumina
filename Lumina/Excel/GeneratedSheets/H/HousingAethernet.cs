namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAethernet", columnHash: 0x751baa92 )]
    public class HousingAethernet : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Level
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: TerritoryType
         *  type: 
         */

        /* offset: 0006 col: 2
         *  name: PlaceName
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: Order
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Level;

        // col: 01 offset: 0004
        public ushort TerritoryType;

        // col: 02 offset: 0006
        public ushort PlaceName;

        // col: 03 offset: 0008
        public byte Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Level = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            TerritoryType = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            PlaceName = parser.ReadOffset< ushort >( 0x6 );

            // col: 3 offset: 0008
            Order = parser.ReadOffset< byte >( 0x8 );


        }
    }
}