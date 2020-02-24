namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
    public class CutScreenImage : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  name: Type
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Image
         *  type: 
         */

        /* offset: 0006 col: 2
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public int Image;

        // col: 00 offset: 0004
        public short Type;

        // col: 02 offset: 0006
        public short unknown6;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Image = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            Type = parser.ReadOffset< short >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< short >( 0x6 );


        }
    }
}