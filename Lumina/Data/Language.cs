using System;

namespace Lumina.Data
{
    [Flags]
    public enum Language : ushort
    {
        None,
        Japanese,
        English,
        German,
        French,
        ChineseSimplified,
        ChineseTraditional,
        Korean
    }
}