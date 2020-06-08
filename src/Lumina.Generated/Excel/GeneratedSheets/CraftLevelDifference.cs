using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLevelDifference", columnHash: 0xba1851a4 )]
    public class CraftLevelDifference : IExcelRow
    {
        
        public short Difference;
        public short ProgressFactor;
        public short QualityFactor;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Difference = parser.ReadColumn< short >( 0 );
            ProgressFactor = parser.ReadColumn< short >( 1 );
            QualityFactor = parser.ReadColumn< short >( 2 );
        }
    }
}