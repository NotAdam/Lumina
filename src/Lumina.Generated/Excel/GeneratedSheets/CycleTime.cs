using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CycleTime", columnHash: 0x5d58cc84 )]
    public class CycleTime : IExcelRow
    {
        
        public uint FirstCycle;
        public uint Cycle;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            FirstCycle = parser.ReadColumn< uint >( 0 );
            Cycle = parser.ReadColumn< uint >( 1 );
        }
    }
}