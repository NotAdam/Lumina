using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelColumnDefinition
    {
        public ExcelColumnDataType Type;
        public ushort Offset;

        public bool IsBoolType => (int)Type > (int)ExcelColumnDataType.PackedBool0;
    }
}