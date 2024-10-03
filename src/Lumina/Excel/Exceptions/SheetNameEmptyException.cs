using System;

namespace Lumina.Excel.Exceptions;

/// <summary>Exception indicating that sheet name could not be resolved.</summary>
public sealed class SheetNameEmptyException : ArgumentNullException
{
    private const string DefaultMessage =
        $"Sheet name must be specified via parameter or sheet attributes.";

    /// <inheritdoc/>
    public SheetNameEmptyException() : base( DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? paramName ) : base( paramName, DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? message, Exception? innerException ) : base( message ?? DefaultMessage, innerException )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? paramName, string? message ) : base( paramName, message ?? DefaultMessage )
    { }
}