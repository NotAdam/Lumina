using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataOffset
    {
        public UInt32 RowId;
        public UInt32 Offset;

        public static ExcelDataOffset Read(LuminaBinaryReader reader)
        {
            return new ExcelDataOffset()
            {
                RowId = reader.ReadUInt32(),
                Offset = reader.ReadUInt32(),
            };
        }
    }
}