using System;

namespace Lumina.Text.Parse;

/// <summary>Exception thrown when macro string parsing has failed.</summary>
public sealed class MacroStringParseException : InvalidOperationException
{
    /// <summary>Initializes a new instance of the <see cref="MacroStringParseException"/> class.</summary>
    /// <param name="message">Error message.</param>
    /// <param name="offset">Byte offset of </param>
    public MacroStringParseException( string message, int offset ) : base( message ) => Offset = offset;

    /// <summary>Gets the byte offset of the input string that failed to parse.</summary>
    public int Offset { get; }
}