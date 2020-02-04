using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataBreakpoint
    {
        public uint StartId;
        public uint RowCount;
    }
}