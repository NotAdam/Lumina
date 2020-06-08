using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieSubtitle500", columnHash: 0x07f99ad3 )]
    public class MovieSubtitle500 : IExcelRow
    {
        
        public float StartTime;
        public float EndTime;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            StartTime = parser.ReadColumn< float >( 0 );
            EndTime = parser.ReadColumn< float >( 1 );
        }
    }
}