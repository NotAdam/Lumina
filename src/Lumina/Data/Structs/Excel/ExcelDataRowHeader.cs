using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ExcelDataRowHeader
    {
        public uint DataSize;
        public ushort RowCount;
    }
}