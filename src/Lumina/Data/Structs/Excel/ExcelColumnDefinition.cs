using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelColumnDefinition
    {
        public ExcelColumnDataType Type;
        public ushort Offset;

        public bool IsBoolType => (int)Type > (int)ExcelColumnDataType.PackedBool0;

        public static ExcelColumnDefinition Read(LuminaBinaryReader reader)
        {
            return new ExcelColumnDefinition()
            {
                Type = (ExcelColumnDataType)reader.ReadUInt16(),
                Offset = reader.ReadUInt16(),
            };
        }
    }
}