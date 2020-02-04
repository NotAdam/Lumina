namespace Lumina.Data.Structs.Excel
{
    public enum ExcelColumnDataType : ushort
    {
        String = 0x0,
        Bool = 0x1,
        Int8 = 0x2,
        UInt8 = 0x3,
        Int16 = 0x4,
        UInt16 = 0x5,
        Int32 = 0x6,
        UInt32 = 0x7,
        // unused?
        Unk = 0x8,
        Float32 = 0x9,
        Int64 = 0xA,
        UInt64 = 0xB,
        // unused?
        Unk2 = 0xC,
        
        // 0 is read like data & 1, 1 is like data & 2, 2 = data & 4, etc...
        PackedBool0 = 0x19,
        PackedBool1 = 0x1A,
        PackedBool2 = 0x1B,
        PackedBool3 = 0x1C,
        PackedBool4 = 0x1D,
        PackedBool5 = 0x1E,
        PackedBool6 = 0x1F,
        PackedBool7 = 0x20,
    }
}