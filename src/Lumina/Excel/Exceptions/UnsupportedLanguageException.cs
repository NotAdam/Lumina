using System;

namespace Lumina.Excel.Exceptions;

/// <summary>Exception indicating that the requested language is not supported by the requested sheet.</summary>
public sealed class UnsupportedLanguageException : ArgumentOutOfRangeException
{
    private const string ErrorMessage = "Specified excel language is not supported for the sheet.";

    /// <inheritdoc/>
    public UnsupportedLanguageException() : base( null, ErrorMessage )
    { }

    /// <inheritdoc/>
    public UnsupportedLanguageException( string? paramName ) : this( ErrorMessage, paramName )
    { }

    /// <inheritdoc/>
    public UnsupportedLanguageException( string? message, Exception? innerException ) : base( message ?? ErrorMessage, innerException )
    { }

    /// <inheritdoc/>
    public UnsupportedLanguageException( string? paramName, object? actualValue, string? message )
        : base( paramName, actualValue, message ?? ErrorMessage )
    { }

    /// <inheritdoc/>
    public UnsupportedLanguageException( string? paramName, string? message ) : base( paramName, message ?? ErrorMessage )
    { }
}