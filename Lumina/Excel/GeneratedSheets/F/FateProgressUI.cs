using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateProgressUI", columnHash: 0x73e43ab7 )]
    public class FateProgressUI : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Location;

        // col: 01 offset: 0004
        public int Achievement;

        // col: 02 offset: 0008
        public byte ReqFatesToRank2;

        // col: 03 offset: 0009
        public byte ReqFatesToRank3;

        // col: 04 offset: 000a
        public byte DisplayOrder;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Location = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Achievement = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            ReqFatesToRank2 = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            ReqFatesToRank3 = parser.ReadOffset< byte >( 0x9 );

            // col: 4 offset: 000a
            DisplayOrder = parser.ReadOffset< byte >( 0xa );


        }
    }
}