namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Carry", columnHash: 0x31e1f9e6 )]
    public class Carry : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Model
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Timeline
         *  type: 
         */

        /* offset: 0009 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 3
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public ulong Model;

        // col: 01 offset: 0008
        public byte Timeline;

        // col: 02 offset: 0009
        public byte unknown9;

        // col: 03 offset: 000a
        public byte unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Model = parser.ReadOffset< ulong >( 0x0 );

            // col: 1 offset: 0008
            Timeline = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}