using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelColumnDefinition : IConvertEndianness
    {
        public ExcelColumnDataType Type;
        public ushort Offset;

        public bool IsBoolType => (int)Type > (int)ExcelColumnDataType.PackedBool0;

        public void ConvertEndianness()
        {
            Type = (ExcelColumnDataType)BinaryPrimitives.ReverseEndianness( (ushort)Type );
            Offset = BinaryPrimitives.ReverseEndianness( Offset );
        }
    }
}