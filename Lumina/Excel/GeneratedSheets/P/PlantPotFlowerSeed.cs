namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PlantPotFlowerSeed", columnHash: 0x84d0ceef )]
    public class PlantPotFlowerSeed : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: SeedIcon
         *  repeat count: 9
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



        // col: 00 offset: 0000
        public uint[] SeedIcon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SeedIcon = new uint[9];
            SeedIcon[0] = parser.ReadOffset< uint >( 0x0 );
            SeedIcon[1] = parser.ReadOffset< uint >( 0x4 );
            SeedIcon[2] = parser.ReadOffset< uint >( 0x8 );
            SeedIcon[3] = parser.ReadOffset< uint >( 0xc );
            SeedIcon[4] = parser.ReadOffset< uint >( 0x10 );
            SeedIcon[5] = parser.ReadOffset< uint >( 0x14 );
            SeedIcon[6] = parser.ReadOffset< uint >( 0x18 );
            SeedIcon[7] = parser.ReadOffset< uint >( 0x1c );
            SeedIcon[8] = parser.ReadOffset< uint >( 0x20 );


        }
    }
}