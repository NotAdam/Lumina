using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordTypeTransient", columnHash: 0xda365c51 )]
    public class FishingRecordTypeTransient : IExcelRow
    {
        
        public int Image;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = parser.ReadColumn< int >( 0 );
        }
    }
}