namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapSymbol", columnHash: 0xe7e370e4 )]
    public class MapSymbol : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Icon
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: PlaceName
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: DisplayNavi
         *  type: 
         */



        // col: 00 offset: 0000
        public int Icon;

        // col: 01 offset: 0004
        public int PlaceName;

        // col: 02 offset: 0008
        private byte packed8;
        public bool DisplayNavi => ( packed8 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            PlaceName = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8 );


        }
    }
}