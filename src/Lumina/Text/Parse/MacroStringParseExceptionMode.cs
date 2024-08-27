namespace Lumina.Text.Parse;

/// <summary>Specify the action on macro string parse failure.</summary>
public enum MacroStringParseExceptionMode
{
    /// <summary>Throw a <see cref="MacroStringParseException"/> on failure.</summary>
    Throw,

    /// <summary>Write the error message as a string into <see cref="SeStringBuilder"/>.</summary>
    EmbedError,

    /// <summary>Ignores the error and instead write the problematic part as plaintext.</summary>
    Ignore,
}