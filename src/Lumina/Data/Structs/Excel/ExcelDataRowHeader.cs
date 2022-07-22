using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ExcelDataRowHeader : IConvertEndianness
    {
        public uint DataSize;
        public ushort RowCount;

        public void ConvertEndianness()
        {
            DataSize = BinaryPrimitives.ReverseEndianness( DataSize );
            RowCount = BinaryPrimitives.ReverseEndianness( RowCount );
        }
    }
}