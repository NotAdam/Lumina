using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataOffset
    {
        public UInt32 RowId;
        public UInt32 Offset;
    }
}