using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    /// <summary>
    /// 
    /// </summary>
    public struct RowDataCursor
    {
        // todo: .net6/c#10 record structs
        
        public ExcelDataFile SheetPage { get; internal set; }
        public ExcelDataOffset RowOffset { get; internal set; }
    }
}