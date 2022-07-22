using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataOffset : IConvertEndianness
    {
        public UInt32 RowId;
        public UInt32 Offset;

        public void ConvertEndianness()
        {
            RowId = BinaryPrimitives.ReverseEndianness( RowId );
            Offset = BinaryPrimitives.ReverseEndianness( Offset );
        }
    }
}