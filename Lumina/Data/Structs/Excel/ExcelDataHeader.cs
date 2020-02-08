using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct ExcelDataHeader
    {
        public fixed byte Magic[4];
        public UInt16 Version;
        private UInt16 U1;
        public UInt32 IndexSize;
        private fixed UInt16 U2[10];
    }
}