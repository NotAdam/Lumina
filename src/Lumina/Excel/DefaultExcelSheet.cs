using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

/// <summary>An excel sheet of <see cref="ExcelVariant.Default"/> variant.</summary>
/// <typeparam name="T">Type of the rows contained within.</typeparam>
public sealed class DefaultExcelSheet< T > : ExcelSheet, ICollection<T>, IReadOnlyCollection<T> where T : struct, IExcelRow< T >
{
    internal DefaultExcelSheet( ExcelModule module, ExcelHeaderFile headerFile, Language requestedLanguage, string sheetName )
        : base( module, headerFile, requestedLanguage, sheetName )
    { }

    /// <inheritdoc/>
    bool ICollection< T >.IsReadOnly => true;

    /// <inheritdoc cref="GetRow"/>
    public T this[ uint rowId ] {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get => GetRow( rowId );
    }

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A nullable row object. Returns null if the row does not exist.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public T? GetRowOrDefault( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef(in lookup) ? null : UnsafeCreateRow< T >( in lookup );
    }

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="row"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetRow( uint rowId, out T row )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef(in lookup) )
        {
            row = default;
            return false;
        }

        row = UnsafeCreateRow< T >( in lookup );
        return true;
    }

    /// <summary>
    /// Gets the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A row object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws when the row id does not have a row attached to it.</exception>
    public T GetRow( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef(in lookup) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : UnsafeCreateRow< T >( in lookup );
    }

    /// <summary>
    /// Gets the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <remarks>If you are looking to find a row by its id, use <see cref="GetRow(uint)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row.</param>
    /// <returns>A row object.</returns>
    public T GetRowAt( int rowIndex )
    {
        ArgumentOutOfRangeException.ThrowIfNegative( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, OffsetLookupTable.Length );

        return UnsafeCreateRowAt< T >( rowIndex );
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    /// <inheritdoc/>
    public bool Contains( T item ) => TryGetRow( item.RowId, out var row ) && EqualityComparer< T >.Default.Equals( item, row );

    /// <inheritdoc/>
    public void CopyTo( T[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        foreach (var lookup in OffsetLookupTable)
            array[ arrayIndex++ ] = UnsafeCreateRow<T>( lookup );
    }

    /// <inheritdoc/>
    void ICollection< T >.Add( T item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    void ICollection< T >.Clear() => throw new NotSupportedException();

    /// <inheritdoc/>
    bool ICollection< T >.Remove( T item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Represents an enumerator that iterates over all rows in a <see cref="DefaultExcelSheet{T}"/>.</summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct Enumerator( DefaultExcelSheet< T > sheet ) : IEnumerator< T >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public readonly T Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
            get => sheet.UnsafeCreateRowAt< T >( _index );
        }

        /// <inheritdoc/>
        readonly object IEnumerator.Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
            get => Current;
        }

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        public bool MoveNext()
        {
            if( ++_index < sheet.Count )
                return true;

            --_index;
            return false;
        }

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        public void Reset() => _index = -1;

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        public readonly void Dispose()
        { }
    }
}