using Lumina.Data;

namespace Lumina.Excel.RSV
{
    public record RsvKeyData
    {
        // todo: can't use init only because netstandard2.0 is shit
        
        public uint RowId { get; set; }

        public int SubRowId { get; set; }

        public uint ColumnIndex { get; set; }

        public Language Language { get; set; }

        public string SheetName { get; set; }
    }
}