using Lumina.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

/// <typeparam name="T">Type of the rows contained within.</typeparam>
/// <inheritdoc cref="BaseSubrowExcelSheet"/>
public sealed class SubrowExcelSheet< T >
    : BaseSubrowExcelSheet, ICollection< SubrowCollection< T > >, IReadOnlyCollection< SubrowCollection< T > >
    where T : struct, IExcelSubrow< T >
{
    /// <summary>Creates a new instance of <see cref="SubrowExcelSheet{T}"/>, deducing sheet names (unless overridden with <paramref name="name"/>) and column
    /// hashes from <typeparamref name="T"/>.</summary>
    /// <typeparam name="T">Type of each row.</typeparam>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet. Use <see langword="null"/> to use <see cref="ExcelModule.Language"/>.</param>
    /// <param name="name">The explicit sheet name, if needed. Leave <see langword="null"/> to use the type's sheet name. Explicit names are necessary for
    /// quest/dungeon/cutscene sheets.</param>
    /// <exception cref="SheetNameEmptyException"><typeparamref name="T"/> had no <see cref="SheetAttribute"/> and <paramref name="name"/> was empty.
    /// </exception>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="MismatchedColumnHashException"><see cref="SheetAttribute.ColumnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="ExcelSheet{T}"/>.</returns>
    public SubrowExcelSheet( ExcelModule module, Language? language = null, string? name = null )
        : this( module, language ?? module.Language, name, module.GetSheetAttributes< T >() )
    { }

    /// <summary>Creates a new instance of <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <typeparam name="T">Type of each row.</typeparam>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <param name="name">The name of the sheet to read from.</param>
    /// <param name="columnHash">The hash of the columns in the sheet. If <see langword="null"/>, it will not check the hash.</param>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="MismatchedColumnHashException"><paramref name="columnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="ExcelSheet{T}"/>.</returns>
    public SubrowExcelSheet( ExcelModule module, Language language, string name, uint? columnHash )
        : base( module, language, name, columnHash )
    { }

    private SubrowExcelSheet( ExcelModule module, Language language, string? name, SheetAttribute? attribute )
        : this( module, language, name ?? attribute?.Name ?? throw new SheetNameEmptyException( null, nameof( name ) ), attribute?.ColumnHash )
    { }

    /// <inheritdoc/>
    bool ICollection< SubrowCollection< T > >.IsReadOnly => true;

    /// <inheritdoc cref="GetRow"/>
    public SubrowCollection< T > this[ uint rowId ] => GetRow( rowId );

    /// <inheritdoc cref="GetSubrow"/>
    public T this[ uint rowId, ushort subrowId ] => GetSubrow( rowId, subrowId );

    /// <summary>
    /// Tries to get the subrow collection with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A nullable subrow collection object. Returns <see langword="null"/> if the row does not exist.</returns>
    public SubrowCollection< T >? GetRowOrDefault( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? null : new( this, in lookup );
    }

    /// <summary>
    /// Tries to get the subrow collection with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="row">The output subrow collection object.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="row"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetRow( uint rowId, out SubrowCollection< T > row )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
        {
            row = default;
            return false;
        }

        row = new( this, in lookup );
        return true;
    }

    /// <summary>
    /// Gets the subrow collection with row id <paramref name="rowId"/> in this sheet. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>A subrow collection object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/>.</exception>
    public SubrowCollection< T > GetRow( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : new( this, in lookup );
    }

    /// <summary>
    /// Gets the subrow collection of the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order.
    /// </summary>
    /// <remarks>If you are looking to find a row by its id, use <see cref="GetRow(uint)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row.</param>
    /// <returns>A subrow collection object.</returns>
    public SubrowCollection< T > GetRowAt( int rowIndex )
    {
        ArgumentOutOfRangeException.ThrowIfNegative( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, OffsetLookupTable.Length );

        return new( this, in UnsafeGetRowLookupAt( rowIndex ) );
    }

    /// <summary>
    /// Tries to get the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowId">The subrow id to get.</param>
    /// <returns>A nullable row object. Returns null if the subrow does not exist.</returns>
    public T? GetSubrowOrDefault( uint rowId, ushort subrowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) || subrowId >= lookup.SubrowCount ? null : UnsafeCreateSubrow< T >( in lookup, subrowId );
    }

    /// <summary>
    /// Tries to get the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowId">The subrow id to get.</param>
    /// <param name="subrow">The output row object.</param>
    /// <returns><see langword="true"/> if the subrow exists and <paramref name="subrow"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetSubrow( uint rowId, ushort subrowId, out T subrow )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) || subrowId >= lookup.SubrowCount )
        {
            subrow = default;
            return false;
        }

        subrow = UnsafeCreateSubrow< T >( in lookup, subrowId );
        return true;
    }

    /// <summary>
    /// Gets the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet. Throws if the subrow does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowId">The subrow id to get.</param>
    /// <returns>A row object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/>.</exception>
    public T GetSubrow( uint rowId, ushort subrowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null );

        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, lookup.SubrowCount );

        return UnsafeCreateSubrow< T >( in lookup, subrowId );
    }

    /// <summary>
    /// Gets the <paramref name="subrowId"/>th subrow of the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order.
    /// </summary>
    /// <remarks>If you are looking to find a subrow by its id, use <see cref="GetSubrow(uint, ushort)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row.</param>
    /// <param name="subrowId">The subrow id to get.</param>
    /// <returns>A row object.</returns>
    public T GetSubrowAt( int rowIndex, ushort subrowId )
    {
        var offsetLookupTable = OffsetLookupTable;
        ArgumentOutOfRangeException.ThrowIfNegative( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, offsetLookupTable.Length );

        ref readonly var lookup = ref UnsafeGetRowLookupAt( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, lookup.SubrowCount );

        return UnsafeCreateSubrow< T >( in lookup, subrowId );
    }

    /// <inheritdoc/>
    public bool Contains( SubrowCollection< T > item ) => ReferenceEquals( item.Sheet, this ) && HasRow( item.RowId );

    /// <inheritdoc/>
    public void CopyTo( SubrowCollection< T >[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        foreach( var lookup in OffsetLookupTable )
            array[ arrayIndex++ ] = new( this, in lookup );
    }

    void ICollection< SubrowCollection< T > >.Add( SubrowCollection< T > item ) => throw new NotSupportedException();

    void ICollection< SubrowCollection< T > >.Clear() => throw new NotSupportedException();

    bool ICollection< SubrowCollection< T > >.Remove( SubrowCollection< T > item ) => throw new NotSupportedException();

    /// <summary>Gets an enumerator that enumerates over all subrows.</summary>
    /// <returns>A new enumerator.</returns>
    public FlatEnumerator Flatten() => new( this );

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    IEnumerator< SubrowCollection< T > > IEnumerable< SubrowCollection< T > >.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Represents an enumerator that iterates over all rows in a <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct Enumerator( SubrowExcelSheet< T > sheet ) : IEnumerator< SubrowCollection< T > >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public SubrowCollection< T > Current { get; private set; }

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < sheet.Count )
            {
                // UnsafeGetRowLookupAt must be called only when the preconditions are validated.
                // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
                // so we create the instance in advance here.
                Current = new( sheet, in sheet.UnsafeGetRowLookupAt( _index ) );
                return true;
            }

            --_index;
            return false;
        }

        /// <inheritdoc/>
        public void Reset() =>
            _index = -1;

        /// <inheritdoc/>
        public readonly void Dispose()
        { }
    }

    /// <summary>Represents an enumerator that iterates over all subrows in a <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct FlatEnumerator( SubrowExcelSheet< T > sheet ) : IEnumerator< T >, IEnumerable< T >
    {
        private int _index = -1;
        private ushort _subrowIndex = ushort.MaxValue;
        private ushort _subrowCount;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public T Current { get; private set; }

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_subrowIndex >= _subrowCount )
            {
                while( true )
                {
                    if( ++_index >= sheet.Count )
                    {
                        --_subrowIndex;
                        --_index;
                        return false;
                    }

                    _subrowCount = sheet.UnsafeGetRowLookupAt( _index ).SubrowCount;
                    if( _subrowCount == 0 )
                        continue;

                    _subrowIndex = 0;
                    break;
                }
            }

            // UnsafeCreateSubrowAt must be called only when the preconditions are validated.
            // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
            // so we create the instance in advance here.
            Current = sheet.UnsafeCreateSubrowAt< T >( _index, _subrowIndex );
            return true;
        }

        /// <inheritdoc/>
        public void Reset()
        {
            _index = -1;
            _subrowIndex = ushort.MaxValue;
            _subrowCount = 0;
        }

        /// <inheritdoc/>
        public readonly void Dispose()
        { }

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        public readonly FlatEnumerator GetEnumerator() => new( sheet );

        readonly IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

        readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}