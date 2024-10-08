using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

/// <summary>An excel sheet of <see cref="ExcelVariant.Default"/> variant.</summary>
/// <typeparam name="T">Type of the rows contained within.</typeparam>
/// <remarks>Creates a new instance of <see cref="ExcelSheet{T}"/>.</remarks>
/// <param name="sheet">The <see cref="RawExcelSheet"/> to access sheet data from.</param>
/// <returns>A new instance of <see cref="ExcelSheet{T}"/>.</returns>
/// <remarks>This constructor does not perform any type checks.</remarks>
public sealed class ExcelSheet< T >( RawExcelSheet sheet ) : IExcelSheet, ICollection< T >, IReadOnlyCollection< T > where T : struct, IExcelRow< T >
{
    /// <summary>Gets the raw sheet this typed sheet is based on.</summary>
    public RawExcelSheet RawSheet { get; } = sheet;

    /// <inheritdoc/>
    public ExcelModule Module => RawSheet.Module;

    /// <inheritdoc/>
    public Language Language => RawSheet.Language;

    /// <inheritdoc/>
    public IReadOnlyList< ExcelColumnDefinition > Columns => RawSheet.Columns;

    /// <inheritdoc/>
    public int Count => RawSheet.Count;

    bool ICollection< T >.IsReadOnly => true;

    /// <inheritdoc cref="GetRow"/>
    public T this[ uint rowId ] => GetRow( rowId );

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A nullable row object. Returns <see langword="null"/> if the row does not exist.</returns>
    public T? GetRowOrDefault( uint rowId )
    {
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? null : RawSheet.UnsafeCreateRow< T >( in lookup );
    }

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="row"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetRow( uint rowId, out T row )
    {
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
        {
            row = default;
            return false;
        }

        row = RawSheet.UnsafeCreateRow< T >( in lookup );
        return true;
    }

    /// <summary>
    /// Gets the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A row object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws when the row id does not have a row attached to it.</exception>
    public T GetRow( uint rowId )
    {
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : RawSheet.UnsafeCreateRow< T >( in lookup );
    }

    /// <summary>
    /// Gets the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order.
    /// </summary>
    /// <remarks>If you are looking to find a row by its id, use <see cref="GetRow(uint)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row.</param>
    /// <returns>A row object.</returns>
    public T GetRowAt( int rowIndex )
    {
        ArgumentOutOfRangeException.ThrowIfNegative( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, RawSheet.OffsetLookupTable.Length );

        return RawSheet.UnsafeCreateRowAt< T >( rowIndex );
    }

    /// <inheritdoc/>
    public ushort GetColumnOffset( int columnIdx ) => RawSheet.GetColumnOffset( columnIdx );

    /// <inheritdoc/>
    public bool HasRow( uint rowId ) => RawSheet.HasRow( rowId );

    /// <inheritdoc/>
    public bool Contains( T item ) => TryGetRow( item.RowId, out var row ) && EqualityComparer< T >.Default.Equals( item, row );

    /// <inheritdoc/>
    public void CopyTo( T[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        foreach( var lookup in RawSheet.OffsetLookupTable )
            array[ arrayIndex++ ] = RawSheet.UnsafeCreateRow< T >( in lookup );
    }

    void ICollection< T >.Add( T item ) => throw new NotSupportedException();

    void ICollection< T >.Clear() => throw new NotSupportedException();

    bool ICollection< T >.Remove( T item ) => throw new NotSupportedException();

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Represents an enumerator that iterates over all rows in a <see cref="ExcelSheet{T}"/>.</summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct Enumerator( ExcelSheet< T > sheet ) : IEnumerator< T >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public T Current { get; private set; }

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < sheet.Count )
            {
                // UnsafeCreateRowAt must be called only when the preconditions are validated.
                // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
                // so we create the instance in advance here.
                Current = sheet.RawSheet.UnsafeCreateRowAt< T >( _index );
                return true;
            }

            --_index;
            return false;
        }

        /// <inheritdoc/>
        public void Reset() => _index = -1;

        /// <inheritdoc/>
        public readonly void Dispose()
        { }
    }
}