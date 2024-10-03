using System;

namespace Lumina.Excel.Exceptions;

/// <summary>Exception indicating that sheet attribute was empty.</summary>
public sealed class SheetAttributeMissingException : ArgumentException
{
    private const string DefaultMessage = $"Row type has no {nameof( SheetAttribute )}.";

    /// <inheritdoc/>
    public SheetAttributeMissingException() : base( DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetAttributeMissingException( string? message ) : base( message ?? DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetAttributeMissingException( string? message, Exception? innerException ) : base( message ?? DefaultMessage, innerException )
    { }

    /// <inheritdoc/>
    public SheetAttributeMissingException( string? message, string? paramName ) : base( message ?? DefaultMessage, paramName )
    { }

    /// <inheritdoc/>
    public SheetAttributeMissingException( string? message, string? paramName, Exception? innerException )
        : base( message ?? DefaultMessage, paramName, innerException )
    { }
}