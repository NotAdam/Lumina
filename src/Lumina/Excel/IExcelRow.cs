namespace Lumina.Excel
{
    public interface IExcelRow
    {
        uint RowId { get; set; }
        uint SubRowId { get; set; }
        
        /// <summary>
        /// Used to populate data in implementing classes
        /// </summary>
        /// <param name="parser">The parser instance which provides access to row data</param>
        /// <param name="lumina">The lumina instance responsible for creating the sheet</param>
        void PopulateData( RowParser parser, Lumina lumina );
    }
}