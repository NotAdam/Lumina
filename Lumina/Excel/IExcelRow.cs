namespace Lumina.Excel
{
    public interface IExcelRow
    {
        int RowId { get; set; }
        int SubRowId { get; set; }
        
        void PopulateData( RowParser parser, Lumina lumina );
    }
}