using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureSpot", columnHash: 0x4a63eb8e )]
    public class TreasureSpot : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT


        // col: 01 offset: 0000
        public float MapOffsetX;

        // col: 02 offset: 0004
        public float MapOffsetY;

        // col: 00 offset: 0008
        public int Location;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            MapOffsetX = parser.ReadOffset< float >( 0x0 );

            // col: 2 offset: 0004
            MapOffsetY = parser.ReadOffset< float >( 0x4 );

            // col: 0 offset: 0008
            Location = parser.ReadOffset< int >( 0x8 );


        }
    }
}