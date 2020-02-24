namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
    public class DeepDungeonMap5X : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: DeepDungeonRoom
         *  repeat count: 5
         */

        /* offset: 0002 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public ushort[] DeepDungeonRoom;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            DeepDungeonRoom = new ushort[5];
            DeepDungeonRoom[0] = parser.ReadOffset< ushort >( 0x0 );
            DeepDungeonRoom[1] = parser.ReadOffset< ushort >( 0x2 );
            DeepDungeonRoom[2] = parser.ReadOffset< ushort >( 0x4 );
            DeepDungeonRoom[3] = parser.ReadOffset< ushort >( 0x6 );
            DeepDungeonRoom[4] = parser.ReadOffset< ushort >( 0x8 );


        }
    }
}