namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTips", columnHash: 0x71371b8c )]
    public class ScenarioTreeTips : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 000a col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 1
         *  name: Tips1
         *  type: 
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 3
         *  name: Tips2
         *  type: 
         */



        // col: 01 offset: 0000
        public uint Tips1;

        // col: 03 offset: 0004
        public uint Tips2;

        // col: 02 offset: 0008
        public ushort unknown8;

        // col: 00 offset: 000a
        public byte unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Tips1 = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            Tips2 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 0 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}