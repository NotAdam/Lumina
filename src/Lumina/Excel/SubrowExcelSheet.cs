using Lumina.Data;
using Lumina.Data.Structs.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <typeparam name="T">Type of the rows contained within.</typeparam>
/// <inheritdoc cref="RawSubrowExcelSheet"/>
public sealed class SubrowExcelSheet< T >( RawSubrowExcelSheet sheet ) : ISubrowExcelSheet, ICollection< SubrowCollection< T > >, IReadOnlyCollection< SubrowCollection< T > > where T : struct, IExcelSubrow< T >
{
    /// <summary>Gets the raw sheet this typed sheet is based on.</summary>
    public RawSubrowExcelSheet RawSheet { get; } = sheet;

    /// <inheritdoc/>
    public ExcelModule Module => RawSheet.Module;

    /// <inheritdoc/>
    public Language Language => RawSheet.Language;

    /// <inheritdoc/>
    public IReadOnlyList< ExcelColumnDefinition > Columns => RawSheet.Columns;

    /// <inheritdoc/>
    public int Count => RawSheet.Count;

    /// <inheritdoc/>
    public int TotalSubrowCount => RawSheet.TotalSubrowCount;

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
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
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
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
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
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
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
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, RawSheet.OffsetLookupTable.Length );

        return new( this, in RawSheet.UnsafeGetRowLookupAt( rowIndex ) );
    }

    /// <summary>
    /// Tries to get the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowId">The subrow id to get.</param>
    /// <returns>A nullable row object. Returns null if the subrow does not exist.</returns>
    public T? GetSubrowOrDefault( uint rowId, ushort subrowId )
    {
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) || subrowId >= lookup.SubrowCount ? null : RawSheet.UnsafeCreateSubrow< T >( in lookup, subrowId );
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
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) || subrowId >= lookup.SubrowCount )
        {
            subrow = default;
            return false;
        }

        subrow = RawSheet.UnsafeCreateSubrow< T >( in lookup, subrowId );
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
        ref readonly var lookup = ref RawSheet.GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null );

        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, lookup.SubrowCount );

        return RawSheet.UnsafeCreateSubrow< T >( in lookup, subrowId );
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
        var offsetLookupTable = RawSheet.OffsetLookupTable;
        ArgumentOutOfRangeException.ThrowIfNegative( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( rowIndex, offsetLookupTable.Length );

        ref readonly var lookup = ref RawSheet.UnsafeGetRowLookupAt( rowIndex );
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, lookup.SubrowCount );

        return RawSheet.UnsafeCreateSubrow< T >( in lookup, subrowId );
    }

    /// <inheritdoc/>
    public bool HasSubrow( uint rowId, ushort subrowId ) => RawSheet.HasSubrow( rowId, subrowId );

    /// <inheritdoc/>
    public bool TryGetSubrowCount( uint rowId, out ushort subrowCount ) => RawSheet.TryGetSubrowCount( rowId, out subrowCount );

    /// <inheritdoc/>
    public ushort GetSubrowCount( uint rowId ) => RawSheet.GetSubrowCount( rowId );

    /// <inheritdoc/>
    public ushort GetColumnOffset( int columnIdx ) => RawSheet.GetColumnOffset( columnIdx );

    /// <inheritdoc/>
    public bool HasRow( uint rowId ) => RawSheet.HasRow( rowId );

    /// <inheritdoc/>
    public bool Contains( SubrowCollection< T > item ) => ReferenceEquals( item.Sheet, this ) && RawSheet.HasRow( item.RowId );

    /// <inheritdoc/>
    public void CopyTo( SubrowCollection< T >[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        foreach( var lookup in RawSheet.OffsetLookupTable )
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
                Current = new( sheet, in sheet.RawSheet.UnsafeGetRowLookupAt( _index ) );
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

                    _subrowCount = sheet.RawSheet.UnsafeGetRowLookupAt( _index ).SubrowCount;
                    if( _subrowCount == 0 )
                        continue;

                    _subrowIndex = 0;
                    break;
                }
            }

            // UnsafeCreateSubrowAt must be called only when the preconditions are validated.
            // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
            // so we create the instance in advance here.
            Current = sheet.RawSheet.UnsafeCreateSubrowAt< T >( _index, _subrowIndex );
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