using System.Collections.Generic;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class ExcelPage
    {
        public string FilePath { get; set; }

        public uint StartId { get; set; }

        public uint RowCount { get; set; }

        public Dictionary< uint, ExcelDataOffset > RowData => File.RowData;

        public ExcelDataFile File { get; set; }
    }
}