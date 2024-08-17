using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <summary>Collection of subrows under one row.</summary>
/// <typeparam name="T">Type of the row.</typeparam>
public readonly struct SubrowCollection< T > : IList< T >, IReadOnlyList< T >
    where T : struct, IExcelRow< T >
{
    private readonly BaseExcelSheet.RowOffsetLookup _lookup;

    internal SubrowCollection( SubrowExcelSheet< T > sheet, scoped ref readonly BaseExcelSheet.RowOffsetLookup lookup )
    {
        Sheet = sheet;
        _lookup = lookup;
    }

    /// <summary>Gets the associated sheet.</summary>
    public SubrowExcelSheet< T > Sheet { get; }

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
            return Sheet.UnsafeCreateSubrow< T >( in _lookup, unchecked( (ushort) index ) );
        }
    }

    /// <inheritdoc/>
    T IList< T >.this[ int index ] {
        get => this[ index ];
        set => throw new NotSupportedException();
    }

    void IList<T>.Insert( int index, T item ) => throw new NotSupportedException();

    void IList<T>.RemoveAt( int index ) => throw new NotSupportedException();

    void ICollection<T>.Add( T item ) => throw new NotSupportedException();

    void ICollection<T>.Clear() => throw new NotSupportedException();

    bool ICollection<T>.Remove( T item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    public int IndexOf( T item )
    {
        if( item.RowId != RowId || item.SubrowId >= Count )
            return -1;

        var row = Sheet.UnsafeCreateSubrow< T >( in _lookup, item.SubrowId );
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
            array[ arrayIndex++ ] = Sheet.UnsafeCreateSubrow< T >( in _lookup, unchecked( (ushort) i ) );
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
        public readonly T Current => subrowCollection.Sheet.UnsafeCreateSubrow< T >( in subrowCollection._lookup, unchecked( (ushort) _index ) );

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < subrowCollection.Count )
                return true;

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