namespace Lumina.Excel.Generated
{
    [SheetName( "ZoneSharedGroup" )]
    public class ZoneSharedGroup : IExcelRow
    {
        public uint col0;
        public uint Quest1;

        public void PopulateData( RowParser parser )
        {
            col0 = parser.ReadColumn< uint >( 0 );
            Quest1 = parser.ReadColumn< uint >( 2 );
        }
    }
}