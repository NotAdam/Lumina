using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingMerchantPose", columnHash: 0x3d65a9f1 )]
    public class HousingMerchantPose : IExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        public string Pose;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Pose = parser.ReadColumn< string >( 1 );
        }
    }
}