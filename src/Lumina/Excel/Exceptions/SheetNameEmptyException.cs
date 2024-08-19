using System;

namespace Lumina.Excel.Exceptions;

/// <summary>Exception indicating that sheet name could not be resolved.</summary>
public sealed class SheetNameEmptyException : ArgumentException
{
    private const string DefaultMessage =
        $"Row type has no {nameof( SheetAttribute )} or its {nameof( SheetAttribute.Name )} is null, and no valid sheet name is specified.";

    /// <inheritdoc/>
    public SheetNameEmptyException() : base( DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? message ) : base( message ?? DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? message, Exception? innerException ) : base( message ?? DefaultMessage, innerException )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? message, string? paramName ) : base( message ?? DefaultMessage, paramName )
    { }

    /// <inheritdoc/>
    public SheetNameEmptyException( string? message, string? paramName, Exception? innerException )
        : base( message ?? DefaultMessage, paramName, innerException )
    { }
}