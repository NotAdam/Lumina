using Lumina.Data.Files.Excel;

namespace Lumina.Excel
{
    public class ExcelSegment
    {
        public string FilePath { get; set; }

        public uint StartId { get; set; }

        public uint RowCount { get; set; }

        public ExcelDataFile File { get; set; }
    }
}