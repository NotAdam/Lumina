namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AquariumFish", columnHash: 0x9b5e32ba )]
    public class AquariumFish : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0006 col: 0
         *  name: AquariumWater
         *  type: 
         */

        /* offset: 0007 col: 1
         *  name: Size
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: Item
         *  type: 
         */

        /* offset: 0004 col: 3
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public uint Item;

        // col: 03 offset: 0004
        public ushort unknown4;

        // col: 00 offset: 0006
        public byte AquariumWater;

        // col: 01 offset: 0007
        public byte Size;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            AquariumWater = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            Size = parser.ReadOffset< byte >( 0x7 );


        }
    }
}