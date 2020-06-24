using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspectionReward", columnHash: 0x2020acf6 )]
    public class HWDGathererInspectionReward : IExcelRow
    {
        
        public ushort Scrips;
        public ushort Points;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Scrips = parser.ReadColumn< ushort >( 0 );
            Points = parser.ReadColumn< ushort >( 1 );
        }
    }
}