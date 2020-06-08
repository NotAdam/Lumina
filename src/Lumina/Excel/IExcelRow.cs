namespace Lumina.Excel
{
    public interface IExcelRow
    {
        uint RowId { get; set; }
        uint SubRowId { get; set; }
        
        void PopulateData( RowParser parser, Lumina lumina );
    }
}