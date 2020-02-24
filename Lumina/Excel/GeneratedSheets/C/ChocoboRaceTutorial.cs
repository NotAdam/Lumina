namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTutorial", columnHash: 0xef6c7b71 )]
    public class ChocoboRaceTutorial : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: NpcYell
         *  repeat count: 8
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 9
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int[] NpcYell;

        // col: 08 offset: 0020
        public ushort unknown20;

        // col: 09 offset: 0022
        public ushort unknown22;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NpcYell = new int[8];
            NpcYell[0] = parser.ReadOffset< int >( 0x0 );
            NpcYell[1] = parser.ReadOffset< int >( 0x4 );
            NpcYell[2] = parser.ReadOffset< int >( 0x8 );
            NpcYell[3] = parser.ReadOffset< int >( 0xc );
            NpcYell[4] = parser.ReadOffset< int >( 0x10 );
            NpcYell[5] = parser.ReadOffset< int >( 0x14 );
            NpcYell[6] = parser.ReadOffset< int >( 0x18 );
            NpcYell[7] = parser.ReadOffset< int >( 0x1c );

            // col: 8 offset: 0020
            unknown20 = parser.ReadOffset< ushort >( 0x20 );

            // col: 9 offset: 0022
            unknown22 = parser.ReadOffset< ushort >( 0x22 );


        }
    }
}