using System;

namespace Lumina.Excel;

/// <summary>
/// An extended interface for <see cref="IExcelRow{T}"/> to provide additional functionality and extension methods.
/// </summary>
/// <typeparam name="T">The type that implements the interface.</typeparam>
public interface IExtendedExcelRow< T > : IExcelRow< T >, IEquatable< T > where T : struct, IExcelRow< T >, IExtendedExcelRow< T >, IEquatable< T >
{
    /// <summary>
    /// Gets the <see cref="ExcelPage"/> containing the data for this row.
    /// </summary>
    ExcelPage Page { get; }

    /// <summary>
    /// Gets the row offset in the <see cref="Page"/>.
    /// </summary>
    uint Offset { get; }

    bool IEquatable< T >.Equals( T other ) =>
        Page == other.Page && RowId == other.RowId;

    /// <summary>
    /// Indicates whether <paramref name="l"/> and <paramref name="r"/> are equal.
    /// </summary>
    /// <param name="l">The left parameter.</param>
    /// <param name="r">The right parameter.</param>
    /// <returns><see langword="true"/> if <paramref name="l"/> and <paramref name="r"/> are equal; <see langword="false"/> otherwise.</returns>
    virtual static bool operator ==( T l, T r ) =>
        l.Equals( r );

    /// <summary>
    /// Indicates whether <paramref name="l"/> and <paramref name="r"/> are not equal.
    /// </summary>
    /// <param name="l">The left parameter.</param>
    /// <param name="r">The right parameter.</param>
    /// <returns><see langword="true"/> if <paramref name="l"/> and <paramref name="r"/> are not equal; <see langword="false"/> otherwise.</returns>
    virtual static bool operator !=( T l, T r ) =>
        !l.Equals( r );
}
