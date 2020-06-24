using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointTransient", columnHash: 0x7164626b )]
    public class GatheringPointTransient : IExcelRow
    {
        
        public ushort EphemeralStartTime;
        public ushort EphemeralEndTime;
        public LazyRow< GatheringRarePopTimeTable > GatheringRarePopTimeTable;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EphemeralStartTime = parser.ReadColumn< ushort >( 0 );
            EphemeralEndTime = parser.ReadColumn< ushort >( 1 );
            GatheringRarePopTimeTable = new LazyRow< GatheringRarePopTimeTable >( lumina, parser.ReadColumn< int >( 2 ), language );
        }
    }
}