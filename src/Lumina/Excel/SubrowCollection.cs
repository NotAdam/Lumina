using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <summary>Collection of subrows under one row.</summary>
/// <typeparam name="T">Type of the row.</typeparam>
public readonly struct SubrowCollection< T > : IList< T >, IReadOnlyList< T >
    where T : struct, IExcelSubrow< T >
{
    private readonly RawExcelSheet.RowOffsetLookup _lookup;

    internal SubrowCollection( RawSubrowExcelSheet sheet, scoped ref readonly RawExcelSheet.RowOffsetLookup lookup )
    {
        _rawSheet = sheet;
        _lookup = lookup;
    }

    [Obsolete( "Use RawSheet instead; Create an issue on GitHub if RawSheet does not fit your use case." )]
    internal SubrowCollection( SubrowExcelSheet<T> sheet, scoped ref readonly RawExcelSheet.RowOffsetLookup lookup )
    {
        _sheet = sheet;
        _lookup = lookup;
    }

    private RawSubrowExcelSheet? _rawSheet { get; }
    private SubrowExcelSheet<T>? _sheet { get; }

    /// <summary>Gets the associated raw sheet.</summary>
    public RawSubrowExcelSheet RawSheet => _rawSheet ?? _sheet!.RawSheet;

    /// <summary>Gets the associated sheet.</summary>
    [Obsolete("Use RawSheet instead; Create an issue on GitHub if RawSheet does not fit your use case.")]
    public SubrowExcelSheet<T> Sheet => _sheet ?? new( RawSheet );

    /// <summary>Gets the Row ID of the subrows contained within.</summary>
    public uint RowId => _lookup.RowId;

    /// <inheritdoc cref="ICollection{T}.Count"/>
    public int Count => _lookup.SubrowCount;

    bool ICollection< T >.IsReadOnly => true;

    /// <inheritdoc/>
    public T this[ int index ] {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get {
            ArgumentOutOfRangeException.ThrowIfNegative( index );
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( index, Count );
            return RawSheet.UnsafeCreateSubrow< T >( in _lookup, unchecked( (ushort) index ) );
        }
    }

    /// <inheritdoc/>
    T IList< T >.this[ int index ] {
        get => this[ index ];
        set => throw new NotSupportedException();
    }

    void IList< T >.Insert( int index, T item ) => throw new NotSupportedException();

    void IList< T >.RemoveAt( int index ) => throw new NotSupportedException();

    void ICollection< T >.Add( T item ) => throw new NotSupportedException();

    void ICollection< T >.Clear() => throw new NotSupportedException();

    bool ICollection< T >.Remove( T item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    public int IndexOf( T item )
    {
        if( item.RowId != RowId || item.SubrowId >= Count )
            return -1;

        var row = RawSheet.UnsafeCreateSubrow< T >( in _lookup, item.SubrowId );
        return EqualityComparer< T >.Default.Equals( item, row ) ? item.SubrowId : -1;
    }

    /// <inheritdoc/>
    public bool Contains( T item ) => IndexOf( item ) != -1;

    /// <inheritdoc/>
    public void CopyTo( T[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        for( var i = 0; i < Count; i++ )
            array[ arrayIndex++ ] = RawSheet.UnsafeCreateSubrow< T >( in _lookup, unchecked( (ushort) i ) );
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Enumerator that enumerates over subrows under one row.</summary>
    /// <param name="subrowCollection">Subrow collection to iterate over.</param>
    public struct Enumerator( SubrowCollection< T > subrowCollection ) : IEnumerator< T >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public T Current { get; private set; }

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < subrowCollection.Count )
            {
                // UnsafeCreateSubrow must be called only when the preconditions are validated.
                // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
                // so we create the instance in advance here.
                Current = subrowCollection.RawSheet.UnsafeCreateSubrow< T >( in subrowCollection._lookup, unchecked( (ushort) _index ) );
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