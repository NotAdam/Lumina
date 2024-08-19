using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel.Exceptions;

namespace Lumina.Excel;

/// <summary>An excel sheet of <see cref="ExcelVariant.Default"/> variant.</summary>
/// <typeparam name="T">Type of the rows contained within.</typeparam>
public sealed class ExcelSheet< T > : BaseExcelSheet, ICollection< T >, IReadOnlyCollection< T > where T : struct, IExcelRow< T >
{
    /// <summary>Creates a new instance of <see cref="ExcelSheet{T}"/>, deducing sheet names (unless overridden with <paramref name="name"/>) and column hashes
    /// from <typeparamref name="T"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet. Use <see langword="null"/> to use <see cref="ExcelModule.Language"/>.</param>
    /// <param name="name">The explicit sheet name, if needed. Leave <see langword="null"/> to use the type's sheet name. Explicit names are necessary for
    /// quest/dungeon/cutscene sheets.</param>
    /// <exception cref="SheetNameEmptyException"><typeparamref name="T"/> had no <see cref="SheetAttribute"/> and <paramref name="name"/> was empty.
    /// </exception>
    /// <exception cref="MismatchedColumnHashException"><see cref="SheetAttribute.ColumnHash"/> was invalid (hash mismatch).</exception>
    /// <inheritdoc cref="ExcelSheet{T}.ExcelSheet(ExcelModule, Language, string, Nullable{uint})"/>
    public ExcelSheet( ExcelModule module, Language? language = null, string? name = null )
        : this( module, language ?? module.Language, name, module.GetSheetAttributes< T >() )
    { }

    /// <summary>Creates a new instance of <see cref="ExcelSheet{T}"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <param name="name">The name of the sheet to read from.</param>
    /// <param name="columnHash">The hash of the columns in the sheet. If <see langword="null"/>, it will not check the hash.</param>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="MismatchedColumnHashException"><paramref name="columnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="ExcelSheet{T}"/>.</returns>
    public ExcelSheet( ExcelModule module, Language language, string name, uint? columnHash )
        : base( module, language, name, columnHash, ExcelVariant.Default )
    { }

    private ExcelSheet( ExcelModule module, Language language, string? name, SheetAttribute? attribute )
        : this( module, language, name ?? attribute?.Name ?? throw new SheetNameEmptyException( null, nameof( name ) ), attribute?.ColumnHash )
    { }

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
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? null : UnsafeCreateRow< T >( in lookup );
    }

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="row"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetRow( uint rowId, out T row )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
        {
            row = default;
            return false;
        }

        row = UnsafeCreateRow< T >( in lookup );
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
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : UnsafeCreateRow< T >( in lookup );
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
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, OffsetLookupTable.Length );

        return UnsafeCreateRowAt< T >( rowIndex );
    }

    /// <inheritdoc/>
    public bool Contains( T item ) => TryGetRow( item.RowId, out var row ) && EqualityComparer< T >.Default.Equals( item, row );

    /// <inheritdoc/>
    public void CopyTo( T[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        foreach( var lookup in OffsetLookupTable )
            array[ arrayIndex++ ] = UnsafeCreateRow< T >( in lookup );
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
                Current = sheet.UnsafeCreateRowAt< T >( _index );
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