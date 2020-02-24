namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Purify", columnHash: 0xde74b4c4 )]
    public class Purify : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Class
         *  type: 
         */

        /* offset: 0001 col: 1
         *  name: Level
         *  type: 
         */



        // col: 00 offset: 0000
        public byte Class;

        // col: 01 offset: 0001
        public byte Level;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Class = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Level = parser.ReadOffset< byte >( 0x1 );


        }
    }
}