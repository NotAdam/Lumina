namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteOpenRule", columnHash: 0x985449ce )]
    public class ContentRouletteOpenRule : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Type
         *  type: 
         */



        // col: 01 offset: 0000
        public uint Type;

        // col: 00 offset: 0004
        private byte packed4;
        public bool packed4_1 => ( packed4 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Type = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}