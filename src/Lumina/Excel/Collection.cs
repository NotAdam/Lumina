using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <summary>
/// A collection helper used to layout and structure excel rows.
/// </summary>
/// <remarks>Mostly an implementation detail for reading excel rows. This type does not store or hold any row data, and is therefore lightweight and trivially constructable.</remarks>
/// <typeparam name="T">A type that wraps a group of fields inside a row.</typeparam>
public readonly unsafe struct Collection< T >( ExcelPage page, uint parentOffset, uint offset, delegate* managed<ExcelPage, uint, uint, uint, T> ctor, int size )
    : IList< T >, IReadOnlyList< T > where T : struct
{
    /// <inheritdoc cref="ICollection{T}.Count"/>
    public int Count => size;

    bool ICollection< T >.IsReadOnly => true;

    /// <inheritdoc/>
    public T this[ int index ] {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( index, size );
            return UnsafeCreateAt( index );
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
        var i = 0;
        var comparer = EqualityComparer< T >.Default;
        foreach( var element in this )
        {
            if( comparer.Equals( item, element ) )
                return i;
            ++i;
        }

        return -1;
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
        foreach( var e in this )
            array[ arrayIndex++ ] = e;
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Creates an item at the given index, without checking for boundaries.</summary>
    /// <param name="index">Index of the item.</param>
    /// <returns>Newly created item.</returns>
    private T UnsafeCreateAt( int index ) => ctor( page, parentOffset, offset, unchecked( (uint) index ) );

    /// <summary>Enumerator that enumerates over the different items.</summary>
    /// <param name="collection">Collection to iterate over.</param>
    public struct Enumerator( Collection< T > collection ) : IEnumerator< T >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public T Current { get; private set; }

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < collection.Count )
            {
                // UnsafeCreateAt must be called only when the preconditions are validated.
                // If it is to be called on-demand from get_Current, then it may end up being called with invalid parameters,
                // so we create the instance in advance here.
                Current = collection.UnsafeCreateAt( _index );
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