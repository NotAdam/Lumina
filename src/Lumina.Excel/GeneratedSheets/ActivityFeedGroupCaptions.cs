// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedGroupCaptions", columnHash: 0x776ee24c )]
    public class ActivityFeedGroupCaptions : IExcelRow
    {
        
        public SeString JA;
        public SeString EN;
        public SeString DE;
        public SeString FR;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            JA = parser.ReadColumn< SeString >( 0 );
            EN = parser.ReadColumn< SeString >( 1 );
            DE = parser.ReadColumn< SeString >( 2 );
            FR = parser.ReadColumn< SeString >( 3 );
        }
    }
}