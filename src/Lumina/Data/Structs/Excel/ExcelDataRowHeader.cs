using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ExcelDataRowHeader
    {
        public uint DataSize;
        public ushort RowCount;

        public static ExcelDataRowHeader Read(LuminaBinaryReader reader)
        {
            return new ExcelDataRowHeader
            {
                DataSize = reader.ReadUInt32(),
                RowCount = reader.ReadUInt16(),
            };
        }
    }
}