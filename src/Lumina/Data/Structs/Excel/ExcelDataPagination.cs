using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataPagination
    {
        public uint StartId;
        public uint RowCount;

        public static ExcelDataPagination Read(LuminaBinaryReader reader)
        {
            return new ExcelDataPagination()
            {
                StartId = reader.ReadUInt32(),
                RowCount = reader.ReadUInt32(),
            };
        }
    }
}