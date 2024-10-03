using Lumina.Text.ReadOnly;
using System;
using System.Runtime.CompilerServices;

namespace Lumina.Extensions;

/// <summary>
/// Utility class for RSV string operations.
/// </summary>
public static class RsvExtensions
{
    /// <summary>
    /// Checks if the string is an RSV string and can therefore be resolved.
    /// </summary>
    /// <remarks>This only checks if the string begins with <c>_rsv_</c>.</remarks>
    /// <param name="rsvString">The string to check.</param>
    /// <returns>Whether or not the string is an RSV string.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public static bool IsRsv( this ReadOnlySeString rsvString ) =>
        rsvString.Data.Span.StartsWith( "_rsv_"u8 );

    /// <inheritdoc cref="IsRsv(ReadOnlySeString)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public static bool IsRsv( this ReadOnlySeStringSpan rsvString ) =>
        rsvString.Data.StartsWith( "_rsv_"u8 );
}