namespace Lumina.Text.Expressions;

public enum ExpressionType : byte
{
    // Placeholder expressions (Zero arity): 0xD0 ~ 0xDF
    Hour = 0xDB,  // 0 ~ 23
    Weekday = 0xDD,  // 1(sunday) ~ 7(saturday)

    // Binary expressions
    GreaterThanOrEqualTo = 0xE0,
    GreaterThan = 0xE1,
    LessThanOrEqualTo = 0xE2,
    LessThan = 0xE3,
    Equal = 0xE4,
    NotEqual = 0xE5,

    // Parameter (unary expressions)
    IntegerParameter = 0xE8,
    PlayerParameter = 0xE9,
    StringParameter = 0xEA,
    ObjectParameter = 0xEB,

    // Placeholder expressions also exist between 0xEC ~ 0xEF, where 0xEC is at least checked existing.

    // Embedded SeString
    SeString = 0xff,  // Followed by length (including length) and data
}