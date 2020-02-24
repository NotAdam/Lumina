using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingMapMarkerInfo", columnHash: 0x13236296 )]
    public class HousingMapMarkerInfo : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public float X;

        // col: 01 offset: 0004
        public float Y;

        // col: 02 offset: 0008
        public float Z;

        // col: 03 offset: 000c
        public float unknownc;

        // col: 04 offset: 0010
        public ushort Map;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            X = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            Y = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            Z = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            Map = parser.ReadOffset< ushort >( 0x10 );


        }
    }
}