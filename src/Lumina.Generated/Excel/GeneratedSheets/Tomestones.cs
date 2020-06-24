using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tomestones", columnHash: 0xd870e208 )]
    public class Tomestones : IExcelRow
    {
        
        public ushort WeeklyLimit;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            WeeklyLimit = parser.ReadColumn< ushort >( 0 );
        }
    }
}