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
/// <param name="page"></param>
/// <param name="parentOffset"></param>
/// <param name="offset"></param>
/// <param name="ctor"></param>
/// <param name="size"></param>
public readonly struct Collection< T >( ExcelPage page, uint parentOffset, uint offset, Func< ExcelPage, uint, uint, uint, T > ctor, int size )
    : IReadOnlyList< T >, ICollection< T > where T : struct
{
    /// <inheritdoc/>
    public T this[ int index ] {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( index, size );
            return ctor( page, parentOffset, offset, (uint) index );
        }
    }

    /// <inheritdoc/>
    public int Count => size;

    bool ICollection< T >.IsReadOnly => true;

    void ICollection< T >.Add( T item ) => throw new NotSupportedException();

    void ICollection< T >.Clear() => throw new NotSupportedException();

    bool ICollection< T >.Remove( T item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    public bool Contains( T item )
    {
        var comparer = EqualityComparer< T >.Default;
        foreach( var element in this )
        {
            if( comparer.Equals( item, element ) )
                return true;
        }

        return false;
    }

    /// <inheritdoc/>
    public void CopyTo( T[] array, int arrayIndex )
    {
        ArgumentNullException.ThrowIfNull( array );
        ArgumentOutOfRangeException.ThrowIfNegative( arrayIndex );
        if( Count > array.Length - arrayIndex )
            throw new ArgumentException( "The number of elements in the source list is greater than the available space." );
        for( var i = 0; i < Count; i++ )
            array[ arrayIndex++ ] = this[ i ];
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public Enumerator GetEnumerator() => new( this );

    readonly IEnumerator< T > IEnumerable< T >.GetEnumerator() => GetEnumerator();

    readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Enumerator that enumerates over the different items.</summary>
    /// <param name="collection">Collection to iterate over.</param>
    public struct Enumerator( Collection< T > collection ) : IEnumerator< T >
    {
        private int _index = -1;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public readonly T Current => collection[ _index ];

        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( ++_index < collection.Count )
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