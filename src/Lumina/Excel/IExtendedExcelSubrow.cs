using System;

namespace Lumina.Excel;

/// <summary>
/// An extended interface for <see cref="IExcelSubrow{T}"/> to provide additional functionality and extension methods.
/// </summary>
/// <inheritdoc cref="IExtendedExcelRow{T}"/>
public interface IExtendedExcelSubrow< T > : IExcelSubrow<T>, IEquatable<T> where T : struct, IExcelSubrow< T >, IExtendedExcelSubrow< T >, IEquatable<T>
{
    /// <inheritdoc cref="IExtendedExcelRow{T}.Page"/>
    ExcelPage Page { get; }

    /// <inheritdoc cref="IExtendedExcelRow{T}.Offset"/>
    uint Offset { get; }

    bool IEquatable<T>.Equals( T other ) =>
        Page == other.Page && RowId == other.RowId && SubrowId == other.SubrowId;

    /// <inheritdoc cref="IExtendedExcelRow{T}.operator=="/>
    virtual static bool operator ==( T l, T r ) =>
        l.Equals( r );

    /// <inheritdoc cref="IExtendedExcelRow{T}.operator!="/>
    virtual static bool operator !=( T l, T r ) =>
        !l.Equals( r );
}
