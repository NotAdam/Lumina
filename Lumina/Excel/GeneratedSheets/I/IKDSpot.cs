using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDSpot", columnHash: 0x96a22aea )]
    public class IKDSpot : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 00 offset: 0000
        public uint SpotMain;

        // col: 01 offset: 0004
        public uint SpotSub;

        // col: 02 offset: 0008
        public uint PlaceName;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SpotMain = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            SpotSub = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            PlaceName = parser.ReadOffset< uint >( 0x8 );


        }
    }
}