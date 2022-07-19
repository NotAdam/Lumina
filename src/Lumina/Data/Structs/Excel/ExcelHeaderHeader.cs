using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelHeaderHeader
    {
        public byte[] Magic;
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
        private uint[] U4;

        public static ExcelHeaderHeader Read( LuminaBinaryReader br )
        {
            return new ExcelHeaderHeader
            {
                Magic = br.ReadBytes( 4 ),
                Version = br.ReadUInt16(),
                DataOffset = br.ReadUInt16(),
                ColumnCount = br.ReadUInt16(),
                PageCount = br.ReadUInt16(),
                LanguageCount = br.ReadUInt16(),
                _unknown1 = br.ReadUInt16(),
                _unknown2 = br.ReadByte(),
                Variant = (ExcelVariant)br.ReadByte(),
                _unknown3 = br.ReadUInt16(),
                RowCount = br.ReadUInt32(),
                U4 = br.ReadUInt32s( 2 )
            };
        }
    }
}