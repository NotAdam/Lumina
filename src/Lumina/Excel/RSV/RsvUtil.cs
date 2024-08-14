using Lumina.Text.ReadOnly;
using System;

namespace Lumina.Excel.Rsv;

public static class RsvUtil
{
    // RsvPrefix => _rsv_
    private static ReadOnlySpan<byte> RsvPrefix => [0x5F, 0x72, 0x73, 0x76, 0x5F];

    /// <summary>
    /// Checks if the string is an RSV string and can therefore be resolved.
    /// </summary>
    /// <remarks>This only checks if the string begins with "_rsv_".</remarks>
    /// <param name="rsvString">The string to check</param>
    /// <returns>Whether or not the string is an RSV string.</returns>
    public static bool IsRsv( this ReadOnlySeString rsvString ) =>
        rsvString.Data.Span.StartsWith( RsvPrefix );

    /// <inheritdoc cref="IsRsv(ReadOnlySeString)"/>
    public static bool IsRsv( this ReadOnlySeStringSpan rsvString ) =>
        rsvString.Data.StartsWith( RsvPrefix );

    /// <summary>
    /// Attempts to resolve <paramref name="rsvString"/> with the given <paramref name="provider"/>.
    /// </summary>
    /// <remarks>This is safe to call on strings that are not RSVs, a.k.a. where <see cref="IsRsv(ReadOnlySeString)"/> returns <see langword="false"/>.</remarks>
    /// <param name="rsvString">The string to resolve</param>
    /// <param name="provider">The provider to check with</param>
    /// <returns>The newly resolved string. Returns <paramref name="rsvString"/> if it could not be resolved.</returns>
    public static ReadOnlySeString ResolveRsv( this ReadOnlySeString rsvString, IRsvProvider provider ) =>
        provider.ResolveOrSelf( rsvString );
}
