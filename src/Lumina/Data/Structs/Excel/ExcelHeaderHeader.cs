using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct ExcelHeaderHeader
    {
        public fixed byte Magic[4];
        // todo: not sure? maybe?
        public ushort Version;
        public ushort DataOffset;
        public ushort ColumnCount;
        public ushort PageCount;
        public ushort LanguageCount;
        private ushort _unknown1;
        private byte _unknown2;
        public ExcelVariant Variant;
        private ushort _unknown3;
        public uint RowCount;
        private fixed uint U4[2];
    }
}