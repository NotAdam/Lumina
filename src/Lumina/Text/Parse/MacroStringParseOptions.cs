namespace Lumina.Text.Parse;

/// <summary>
/// Options for <see cref="SeStringBuilder.AppendMacroString"/>.
/// </summary>
/// <param name="CharEnumerationFlags">Specify how to interpret the text given.</param>
/// <param name="ExceptionMode"></param>
public readonly record struct MacroStringParseOptions(
    UtfEnumeratorFlags CharEnumerationFlags = UtfEnumeratorFlags.Default,
    MacroStringParseExceptionMode ExceptionMode = MacroStringParseExceptionMode.Throw );