namespace Lumina.Excel.Sheets
{
    [SheetName( "ZoneSharedGroup" )]
    public class ZoneSharedGroup : IExcelRow
    {
        public uint col0;
        public uint[] Quests;

        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            col0 = parser.ReadOffset< uint >( 0x0 );
            Quests = parser.ReadStructuresAsArray< uint >( 0x4, 6 );
        }
    }
}