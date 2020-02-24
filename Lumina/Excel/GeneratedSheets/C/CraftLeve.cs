namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLeve", columnHash: 0x51a3acc3 )]
    public class CraftLeve : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Leve
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: CraftLeveTalk
         *  type: 
         */

        /* offset: 0020 col: 2
         *  name: Repeats
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: 
         *  repeat count: 4
         */

        /* offset: 0018 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 001e col: 10
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public int Leve;

        // col: 01 offset: 0004
        public int CraftLeveTalk;

        // col: 03 offset: 0008
        public int[] unknown8;

        // col: 07 offset: 0010
        public int unknown10;

        // col: 09 offset: 0014
        public int unknown14;

        // col: 08 offset: 001c
        public ushort unknown1c;

        // col: 10 offset: 001e
        public ushort unknown1e;

        // col: 02 offset: 0020
        public byte Repeats;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Leve = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            CraftLeveTalk = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = new int[4];
            unknown8[0] = parser.ReadOffset< int >( 0x8 );
            unknown8[1] = parser.ReadOffset< int >( 0x18 );
            unknown8[2] = parser.ReadOffset< int >( 0xc );
            unknown8[3] = parser.ReadOffset< int >( 0x1a );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 9 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 8 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 10 offset: 001e
            unknown1e = parser.ReadOffset< ushort >( 0x1e );

            // col: 2 offset: 0020
            Repeats = parser.ReadOffset< byte >( 0x20 );


        }
    }
}