using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingMerchantPose", columnHash: 0x3d65a9f1 )]
    public class HousingMerchantPose : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Pose;

        // col: 00 offset: 0004
        public ushort ActionTimeline;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Pose = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            ActionTimeline = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}