using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataPagination
    {
        public uint StartId;
        public uint RowCount;
    }
}