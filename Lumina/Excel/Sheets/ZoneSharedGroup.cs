namespace Lumina.Excel.Sheets
{
    [SheetName( "ZoneSharedGroup" )]
    public class ZoneSharedGroup : IExcelRow
    {
        public uint col0;
        public uint Quest1;

        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;
            
            col0 = parser.ReadColumn< uint >( 0 );
            Quest1 = parser.ReadColumn< uint >( 2 );
        }
    }
}