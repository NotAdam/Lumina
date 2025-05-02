using System;

namespace Lumina.Text.Payloads;

/// <summary>
/// Type of payloads.
/// </summary>
[Obsolete( "Use MacroCode instead." )]
public enum PayloadType : byte
{
    /// <summary>
    /// Lumina internal representation marking that the payload is a text payload, and does not require special handling.
    /// This is an INVALID payload type, when wrapped into payload package.
    /// </summary>
    Text = 0x00,
    
    ResetTime = 0x06,
    Time = 0x07,
    If = 0x08,
    Switch = 0x09,
    ActorFullName = 0x0a,
    IfEquals = 0x0c,
    IfJosa = 0x0d,  // For Korean language; eun/neun, i/ga, or eul/reul
    IfJosaro = 0x0e,  // For Korean language; ro/euro
    IfPlayer = 0x0f,  // "You are"/"Someone Else is"
    NewLine = 0x10,
    BitmapFontIcon = 0x12,
    ColorFill = 0x13,
    ColorBorder = 0x14,
    SoftHyphen = 0x16,
    DialoguePageSeparator = 0x17,  // probably
    Italics = 0x1a,
    Indent = 0x1d,  // For French language
    Icon2 = 0x1e,
    Hyphen = 0x1f,
    Value = 0x20,
    Format = 0x22,
    TwoDigitValue = 0x24,  // "{:02}"
    SheetReference = 0x28,
    Highlight = 0x29,
    Link = 0x2b,
    Split = 0x2c,
    Placeholder = 0x2e,
    SheetReferenceJa = 0x30,
    SheetReferenceEn = 0x31,
    SheetReferenceDe = 0x32,
    SheetReferenceFr = 0x33,
    InstanceContent = 0x40,
    UiColorFill = 0x48,
    UiColorBorder = 0x49,
    ZeroPaddedValue = 0x50,
    OrdinalValue = 0x51,  // "1st", "2nd", "3rd", ...
}