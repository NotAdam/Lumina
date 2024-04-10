namespace Lumina.Text.Payloads;

/// <summary>Valid macro payload types.</summary>
/// <remarks>A <c>terminator</c> argument does not mean that an argument is required.</remarks>
public enum MacroCode : byte
{
    /// <summary>Sets the reset time to the contextual time storage.</summary>
    /// <remarks>Parameters: weekday, hour, terminator.</remarks>
    [MacroCodeData( null, "n N x" )] SetResetTime = 0x06,

    /// <summary>Sets the specified time to the contextual time storage.</summary>
    /// <remarks>Parameters: unix timestamp in seconds, terminator.</remarks>
    [MacroCodeData( null, "n x" )] SetTime = 0x07,

    /// <summary>Tests an expression and uses a corresponding subexpression.</summary>
    /// <remarks>Parameters: condition, expression to use if condition is true, expression to use if condition is false.</remarks>
    [MacroCodeData( null, ". . * x" )] If = 0x08,

    /// <summary>Tests an expression and uses a corresponding subexpression.</summary>
    /// <remarks>Parameters: condition, expression to use if condition is 1, expression to use if condition is 2, and so on.</remarks>
    [MacroCodeData( null, ". . ." )] Switch = 0x09,

    /// <summary>Adds a characters name.</summary>
    /// <remarks>Parameters: ObjectId, terminator.</remarks>
    [MacroCodeData( null, "n x" )] PcName = 0x0A,
    
    /// <summary>Tests a characters gender.</summary>
    /// <remarks>Parameters: ObjectId, expression to use if the character is male, expression to use if the character is female, terminator.</remarks>
    [MacroCodeData( null, "n . . x" )] IfPcGender = 0x0B,
    
    /// <summary>Tests a characters name.</summary>
    /// <remarks>Parameters: ObjectId, the name to test against, expression to use if the name matches, expression to use if the name doesn't match, terminator.</remarks>
    [MacroCodeData( null, "n . . . x" )] IfPcName = 0x0C,

    /// <summary>Determines the type of josa required from the last character of the first expression.</summary>
    /// <remarks>Parameters: test string, eun/i/eul suffix, neun/ga/reul suffix, terminator.</remarks>
    [MacroCodeData( null, "s s s x" )] Josa = 0x0D,

    /// <summary>Determines the type of josa, ro in particular, required from the last character of the first expression.</summary>
    /// <remarks>Parameters: test string, ro suffix, euro suffix, terminator.</remarks>
    [MacroCodeData( null, "s s s x" )] Josaro = 0x0E,

    /// <summary>Tests if the character is the local player.</summary>
    /// <remarks>Parameters: ObjectId, expression to use if the character is the local player, expression to use if the character is not the local player, terminator.</remarks>
    [MacroCodeData( null, "n . . x" )] IfSelf = 0x0F,

    /// <summary>Adds a line break.</summary>
    [MacroCodeData( "br", "" )] NewLine = 0x10,

    /// <summary>Waits for a specified duration.</summary>
    /// <remarks>Parameters: delay in seconds, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Wait = 0x11,

    /// <summary>Adds an icon from gfdata.gfd.</summary>
    /// <remarks>Parameters: icon ID, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Icon = 0x12,

    /// <summary>Pushes the text foreground color.</summary>
    /// <remarks>Parameters: something that resolves to B8G8R8A8 or stackcolor(, ?), terminator</remarks>
    [MacroCodeData( null, "n N x" )] Color = 0x13,

    /// <summary>Pushes the text border color.</summary>
    /// <remarks>Parameters: something that resolves to B8G8R8A8 or stackcolor(, ?), terminator</remarks>
    [MacroCodeData( null, "n N x" )] EdgeColor = 0x14,

    /// <summary>Pushes the text shadow color.</summary>
    /// <remarks>Parameters: something that resolves to B8G8R8A8 or stackcolor(, ?), terminator</remarks>
    [MacroCodeData( null, "n N x" )] ShadowColor = 0x15,

    /// <summary>Adds a soft hyphen.</summary>
    [MacroCodeData( "-", "" )] SoftHyphen = 0x16,

    [MacroCodeData( null, "" )] Key = 0x17,
    [MacroCodeData( null, "n" )] Scale = 0x18,

    /// <summary>Sets whether to use bold text effect.</summary>
    /// <remarks>Parameters: bool enabled.</remarks>
    [MacroCodeData( null, "n" )] Bold = 0x19,

    /// <summary>Sets whether to use italic text effect.</summary>
    /// <remarks>Parameters: bool enabled.</remarks>
    [MacroCodeData( null, "n" )] Italic = 0x1A,

    [MacroCodeData( null, "n n" )] Edge = 0x1B,
    [MacroCodeData( null, "n n" )] Shadow = 0x1C,

    /// <summary>Adds a non-breaking space.</summary>
    [MacroCodeData( "nbsp", "" )] NonBreakingSpace = 0x1D,

    // TODO: how is this different from Icon?
    [MacroCodeData( null, "n N x" )] Icon2 = 0x1E,

    /// <summary>Adds a hyphen.</summary>
    [MacroCodeData( "--", "" )] Hyphen = 0x1F,

    /// <summary>Adds a decimal representation of an integer expression.</summary>
    /// <remarks>Parameters: integer expression, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Num = 0x20,

    /// <summary>Adds a hexadecimal representation of an integer expression.</summary>
    /// <remarks>Parameters: integer expression, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Hex = 0x21,

    /// <summary>Adds a decimal representation of an integer expression, separating by thousands.</summary>
    /// <remarks>Parameters: integer expression, separator (usually a comma or a dot), terminator.</remarks>
    [MacroCodeData( null, ". s x" )] Kilo = 0x22,

    /// <summary>Adds a readable byte string (possible suffixes: omitted, K, M, G, T).</summary>
    /// <remarks>Parameters: integer expression, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Byte = 0x23,

    /// <summary>Adds a zero-padded-to-two-digits decimal representation of an integer expression.</summary>
    /// <remarks>Parameters: integer expression, terminator.</remarks>
    [MacroCodeData( null, "n x" )] Sec = 0x24,

    [MacroCodeData( null, "n x" )] Time = 0x25,

    /// <summary>Adds a floating point number as text.</summary>
    /// <remarks>Parameters: integer expression, radix, separator, terminator.</remarks>
    [MacroCodeData( null, "n n s x" )] Float = 0x26,
    
    /// <summary>Begins or ends a region of link.</summary>
    /// <remarks>Parameters: <see cref="LinkMacroPayloadType"/>, numeric argument 1, numeric argument 2, numeric argument 3, display string.<br />
    /// See comments in <see cref="LinkMacroPayloadType"/> for the argument usages.</remarks>
    [MacroCodeData( null, "n n n n s" )] Link = 0x27,

    /// <summary>Adds a column from a sheet.</summary>
    /// <remarks>Parameters: sheet name, row ID, column index, expression passed as first local parameter to the columns text.</remarks>
    [MacroCodeData( null, "s . . ." )] Sheet = 0x28,

    /// <summary>Adds a string expression as-is.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] String = 0x29,

    /// <summary>Adds a string, fully upper cased.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] Caps = 0x2A,

    /// <summary>Adds a string, first character upper cased.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] Head = 0x2B,
    
    [MacroCodeData( null, "s s n x" )] Split = 0x2C,
    
    /// <summary>Adds a string, every words first character upper cased.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] HeadAll = 0x2D,

    [MacroCodeData( null, "n n . . ." )] Fixed = 0x2E,

    /// <summary>Adds a string, fully lower cased.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] Lower = 0x2F,

    /// <summary>Adds sheet text with proper declension in Japanese.</summary>
    /// <remarks>Parameters: sheet name, person, row id, amount, unused, unknown offset.</remarks>
    [MacroCodeData( null, "s . ." )] JaNoun = 0x30,

    /// <summary>Adds sheet text with proper declension in English.</summary>
    /// <remarks>Parameters: sheet name, person, row id, amount, unused, unused.</remarks>
    [MacroCodeData( null, "s . ." )] EnNoun = 0x31,

    /// <summary>Adds sheet text with proper declension in German.</summary>
    /// <remarks>Parameters: sheet name, person, row id, amount, case, unused.</remarks>
    [MacroCodeData( null, "s . ." )] DeNoun = 0x32,

    /// <summary>Adds sheet text with proper declension in French.</summary>
    /// <remarks>Parameters: sheet name, person, row id, amount, unused, unknown offset.</remarks>
    [MacroCodeData( null, "s . ." )] FrNoun = 0x33,

    /// <summary>Adds sheet text with proper declension in Chinese.</summary>
    /// <remarks>Parameters: sheet name, unused, row id, amount, unused, unknown offset.</remarks>
    [MacroCodeData( null, "s . ." )] ChNoun = 0x34,
    
    /// <summary>Adds a string, first character lower cased.</summary>
    /// <remarks>Parameters: string expression, terminator.</remarks>
    [MacroCodeData( null, "s x" )] LowerHead = 0x40,

    /// <summary>Pushes the text foreground color, referring to a color defined in UIColor sheet.</summary>
    /// <remarks>Parameters: row ID in UIColor sheet or 0 to pop(or reset?) the pushed color, terminator.</remarks>
    [MacroCodeData( null, "n x" )] ColorType = 0x48,

    /// <summary>Pushes the text border color, referring to a color defined in UIColor sheet.</summary>
    /// <remarks>Parameters: row ID in UIColor sheet or 0 to pop(or reset?) the pushed color, terminator.</remarks>
    [MacroCodeData( null, "n x" )] EdgeColorType = 0x49,

    /// <summary>Adds a zero-prefixed number as text.</summary>
    /// <remarks>Parameters: integer expression, target length, terminator.</remarks>
    [MacroCodeData( null, "n n x" )] Digit = 0x50,

    /// <summary>Adds an ordinal number as text (English only).</summary>
    [MacroCodeData( null, "n x" )] Ordinal = 0x51,

    /// <summary>Adds a non-visible sound payload.</summary>
    /// <remarks>Parameters: bool whether this sound is a Jingle (see sheet), the id.</remarks>
    [MacroCodeData( null, "n n" )] Sound = 0x60,
    
    /// <summary>Adds a formatted map name and corresponding coordinates, in the format of <c>Map Name\n( X  , Y )</c>.</summary>
    /// <remarks>Parameters: row ID in Level sheet, terminator.</remarks>
    [MacroCodeData( null, "n x" )] LevelPos = 0x61,
}