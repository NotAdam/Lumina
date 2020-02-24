namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0xcc25b9f9 )]
    public class ScenarioTree : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0006 col: 0
         *  name: Type
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Image
         *  type: 
         */

        /* offset: 0000 col: 2
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public uint unknown0;

        // col: 01 offset: 0004
        public ushort Image;

        // col: 00 offset: 0006
        public byte Type;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Image = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            Type = parser.ReadOffset< byte >( 0x6 );


        }
    }
}