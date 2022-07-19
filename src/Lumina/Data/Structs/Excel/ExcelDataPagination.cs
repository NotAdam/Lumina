using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataPagination : IConvertEndianness
    {
        public uint StartId;
        public uint RowCount;

        public void ConvertEndianness()
        {
            RowCount = BinaryPrimitives.ReverseEndianness( RowCount );
            StartId = BinaryPrimitives.ReverseEndianness( StartId );
        }
    }
}