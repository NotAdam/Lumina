using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct ExcelHeaderHeader
    {
        public enum ExcelVariant : byte
        {
            Unknown, 
            Default,
            Subrows
        }
        
        public fixed byte Magic[4];
        // todo: not sure? maybe?
        public ushort Version;
        public ushort DataOffset;
        public ushort ColumnCount;
        public ushort ExdCount;
        public ushort LanguageCount;
        private ushort U1;
        private byte U2;
        public ExcelVariant Variant;
        private ushort U3;
        private fixed uint U4[3];
    }
}