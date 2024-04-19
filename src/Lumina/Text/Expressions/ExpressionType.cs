using System;

namespace Lumina.Text.Expressions;

/// <summary>Named types for expressions.</summary>
public enum ExpressionType : byte
{
    /// <summary>Uses the millisecond value in the contextual time storage.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_msec" )]
    Millisecond = 0xD8,

    /// <summary>Uses the second value in the contextual time storage.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_sec" )]
    Second = 0xD9,

    /// <summary>Uses the minute value in the contextual time storage.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_min" )]
    Minute = 0xDA,

    /// <summary>Uses the hour value in the contextual time storage, ranging from 0 to 23.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_hour" )]
    Hour = 0xDB,

    /// <summary>Uses the day of month value in the contextual time storage.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_day" )]
    Day = 0xDC,

    /// <summary>Uses the weekday value in the contextual time storage, ranging from 1(Sunday) to 7(Saturday).</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_wday" )]
    Weekday = 0xDD,

    /// <summary>Uses the month value in the contextual time storage, ranging from 0(January) to 11(December).</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_mon" )]
    Month = 0xDE,

    /// <summary>Uses the year value in the contextual time storage, where 0 means the year 1900.</summary>
    [ExpressionData( ExpressionArity.Nullary, "t_year" )]
    Year = 0xDF,

    /// <summary>Tests if the evaluated result from first sub-expression is greater than or equal to the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[gteq]" )]
    GreaterThanOrEqualTo = 0xE0,

    /// <summary>Tests if the evaluated result from first sub-expression is greater than the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[gt]" )]
    GreaterThan = 0xE1,

    /// <summary>Tests if the evaluated result from first sub-expression is less than or equal to the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[lteq]" )]
    LessThanOrEqualTo = 0xE2,

    /// <summary>Tests if the evaluated result from first sub-expression is less than the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[lt]" )]
    LessThan = 0xE3,

    /// <summary>Tests if the evaluated result from first sub-expression is equal to the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[eq]" )]
    Equal = 0xE4,

    /// <summary>Tests if the evaluated result from first sub-expression is not equal to the evaluated result from second sub-expression.</summary>
    [ExpressionData( ExpressionArity.Binary, "[neq]" )]
    NotEqual = 0xE5,

    /// <summary>Uses a numeric value at the specified index in the local parameter storage.</summary>
    [ExpressionData( ExpressionArity.Unary, "lnum" )]
    LocalNumber = 0xE8,

    /// <summary>Uses a numeric value at the specified index in the global parameter storage.</summary>
    [ExpressionData( ExpressionArity.Unary, "gnum" )]
    GlobalNumber = 0xE9,

    /// <summary>Uses a SeString value at the specified index in the local parameter storage.</summary>
    [ExpressionData( ExpressionArity.Unary, "lstr" )]
    LocalString = 0xEA,

    /// <summary>Uses a SeString value at the specified index in the global parameter storage.</summary>
    [ExpressionData( ExpressionArity.Unary, "gstr" )]
    GlobalString = 0xEB,

    /// <summary>Uses the last color value pushed.</summary>
    [ExpressionData( ExpressionArity.Nullary, "stackcolor" )]
    StackColor = 0xEC,

    /// <summary>A SeString preceded by its length is followed.</summary>
    SeString = 0xff,

    /// <summary>Old name for <see cref="LocalNumber"/>.</summary>
    [Obsolete( $"Use {nameof( LocalNumber )}." )]
    IntegerParameter = LocalNumber,

    /// <summary>Old name for <see cref="GlobalNumber"/>.</summary>
    [Obsolete( $"Use {nameof( GlobalNumber )}." )]
    PlayerParameter = GlobalNumber,

    /// <summary>Old name for <see cref="LocalString"/>.</summary>
    [Obsolete( $"Use {nameof( LocalString )}." )]
    StringParameter = LocalString,

    /// <summary>Old name for <see cref="GlobalString"/>.</summary>
    [Obsolete( $"Use {nameof( GlobalString )}." )]
    ObjectParameter = GlobalString,
}