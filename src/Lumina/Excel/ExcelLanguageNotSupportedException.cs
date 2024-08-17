using System;

namespace Lumina.Excel;

/// <summary>Exception indicating that the requested language is not supported by the requested sheet.</summary>
public sealed class ExcelLanguageNotSupportedException : ArgumentOutOfRangeException
{
    private const string ErrorMessage = "Specified excel language is not supported for the sheet.";

    /// <inheritdoc/>
    public ExcelLanguageNotSupportedException() : base( null, ErrorMessage )
    { }

    /// <inheritdoc/>
    public ExcelLanguageNotSupportedException( string? paramName ) : this( ErrorMessage, paramName )
    { }

    /// <inheritdoc/>
    public ExcelLanguageNotSupportedException( string? message, Exception? innerException ) : base( message ?? ErrorMessage, innerException )
    { }

    /// <inheritdoc/>
    public ExcelLanguageNotSupportedException( string? paramName, object? actualValue, string? message )
        : base( paramName, actualValue, message ?? ErrorMessage )
    { }

    /// <inheritdoc/>
    public ExcelLanguageNotSupportedException( string? paramName, string? message ) : base( paramName, message ?? ErrorMessage )
    { }
}