using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedGroupCaptions", columnHash: 0x776ee24c )]
    public class ActivityFeedGroupCaptions : IExcelRow
    {
        
        public string JA;
        public string EN;
        public string DE;
        public string FR;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            JA = parser.ReadColumn< string >( 0 );
            EN = parser.ReadColumn< string >( 1 );
            DE = parser.ReadColumn< string >( 2 );
            FR = parser.ReadColumn< string >( 3 );
        }
    }
}