using System;

namespace Lumina.Excel;

/// <summary>Exception indicating that no such sheet could be found.</summary>
public sealed class SheetNotFoundException : ArgumentException
{
    private const string DefaultMessage = "Sheet could not be found.";

    /// <inheritdoc/>
    public SheetNotFoundException() : base( DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNotFoundException( string? message ) : base( message ?? DefaultMessage )
    { }

    /// <inheritdoc/>
    public SheetNotFoundException( string? message, Exception? innerException ) : base( message ?? DefaultMessage, innerException )
    { }

    /// <inheritdoc/>
    public SheetNotFoundException( string? message, string? paramName ) : base( message ?? DefaultMessage, paramName )
    { }

    /// <inheritdoc/>
    public SheetNotFoundException( string? message, string? paramName, Exception? innerException )
        : base( message ?? DefaultMessage, paramName, innerException )
    { }
}