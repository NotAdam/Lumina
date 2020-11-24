using System.Collections.Generic;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class ExcelPage
    {
        /// <summary>
        /// The path to the data file (exd) that contains the rows for the current page
        /// </summary>
        public string FilePath { get; set; } = null!;

        /// <summary>
        /// The start ID of the page
        /// </summary>
        public uint StartId { get; set; }

        /// <summary>
        /// How many rows are contained in this page
        /// </summary>
        public uint RowCount { get; set; }

        /// <summary>
        /// An index -> (rowid, offset) list which maps a local row index to where it is inside the current data page
        /// </summary>
        public Dictionary< uint, ExcelDataOffset >? RowData => File?.RowData;

        /// <summary>
        /// The underlying data file that contains the sheet data
        /// </summary>
        public ExcelDataFile? File { get; set; }
    }
}