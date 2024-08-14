using Lumina.Text.ReadOnly;

namespace Lumina.Excel.Rsv;

/// <summary>
/// Represents a provider for resolving RSV strings.
/// </summary>
public interface IRsvProvider
{
    /// <summary>
    /// Determines if the provider can resolve the given RSV string.
    /// </summary>
    /// <param name="rsvString">The string to check.</param>
    /// <returns>Whether or not the provider contains a resolved string for <paramref name="rsvString"/>.</returns>
    bool CanResolve( ReadOnlySeString rsvString );

    /// <summary>
    /// Tries to resolve the given RSV string.
    /// </summary>
    /// <param name="rsvString">The string to resolve.</param>
    /// <returns>The newly resolved string. Returns <see langword="null"/> if it could not be resolved.</returns>
    ReadOnlySeString? TryResolve( ReadOnlySeString rsvString );

    /// <summary>
    /// Resolves the given RSV string.
    /// </summary>
    /// <param name="rsvString">The string to resolve.</param>
    /// <returns>The newly resolved string.</returns>
    /// <exception cref="System.ArgumentException">Thrown if the RSV string is not valid. <see cref="RsvUtil.IsRsv(ReadOnlySeString)"/> must return true.</exception>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">Thrown if the RSV key is not found in the provider.</exception>
    ReadOnlySeString Resolve( ReadOnlySeString rsvString );

    /// <summary>
    /// Tries to resolve the given RSV string.
    /// </summary>
    /// <param name="rsvString">The string to resolve.</param>
    /// <returns>The newly resolved string. Returns <paramref name="rsvString"/> if it could not be resolved.</returns>
    ReadOnlySeString ResolveOrSelf( ReadOnlySeString rsvString );
}
