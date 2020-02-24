namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
    public class ChocoboRaceRank : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  name: Rating{Min}
         *  type: 
         */

        /* offset: 0006 col: 1
         *  name: Rating{Max}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Name
         *  type: 
         */

        /* offset: 000a col: 3
         *  name: Fee
         *  type: 
         */

        /* offset: 0000 col: 4
         *  name: Icon
         *  type: 
         */



        // col: 04 offset: 0000
        public int Icon;

        // col: 00 offset: 0004
        public ushort RatingMin;

        // col: 01 offset: 0006
        public ushort RatingMax;

        // col: 02 offset: 0008
        public ushort Name;

        // col: 03 offset: 000a
        public ushort Fee;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            RatingMin = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            RatingMax = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            Name = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            Fee = parser.ReadOffset< ushort >( 0xa );


        }
    }
}