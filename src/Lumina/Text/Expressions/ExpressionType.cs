namespace Lumina.Text.Expressions;

public enum ExpressionType : byte
{
    // Placeholder expressions (Zero arity): 0xD8 ~ 0xDF
    Millisecond = 0xD8, // t_msec
    Second = 0xD9, // t_sec
    Minute = 0xDA, // t_min
    Hour = 0xDB,  // t_hour 0 ~ 23
    Day = 0xDC, // t_day
    Weekday = 0xDD,  // t_wday 1(sunday) ~ 7(saturday)
    Month = 0xDE, // t_mon
    Year = 0xDF, // t_year

    // Binary expressions
    GreaterThanOrEqualTo = 0xE0, // [gteq]
    GreaterThan = 0xE1, // [gt]
    LessThanOrEqualTo = 0xE2, // [lteq]
    LessThan = 0xE3, // [lt]
    Equal = 0xE4, // [eq]
    NotEqual = 0xE5, // [neq]

    // Parameter (unary expressions)
    IntegerParameter = 0xE8, // lnum
    PlayerParameter = 0xE9, // gnum
    StringParameter = 0xEA, // lstr
    ObjectParameter = 0xEB, // gstr

    // Placeholder expressions also exist between 0xEC ~ 0xEF, where 0xEC is at least checked existing.
    StackColor = 0xEC, // stackcolor

    // Embedded SeString
    SeString = 0xff,  // Followed by length (including length) and data
}