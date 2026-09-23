using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Misc;

/// <summary>
/// A hash lookup table that maps <see langword="uint"/> keys to values of <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// A <see cref="System.Collections.Frozen.FrozenDictionary{TKey,TValue}"/> keeps its hash codes, values and
/// bucket table in three separate arrays, so a lookup is 3 cache misses; storing each key with its value
/// reduces that to 1.
/// </remarks>
/// <typeparam name="T">The <see langword="unmanaged"/> type of the values to be stored in the <see cref="HashLookup{T}"/>.</typeparam>
public sealed class HashLookup< T > : IReadOnlyDictionary< uint, T >
    where T : unmanaged
{
    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    private struct Entry
    {
        public uint Hash;
        public bool Occupied;
        public T Value;
    }

    private readonly Entry[] entries;
    private readonly uint mask;

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.Count"/>
    public int Count { get; }

    /// <inheritdoc/>
    public T this[ uint key ] =>
        TryGetValue( key, out var value ) ? value : throw new KeyNotFoundException();

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.Keys"/>
    public IEnumerable< uint > Keys {
        get {
            foreach( var entry in entries )
            {
                if( entry.Occupied )
                    yield return entry.Hash;
            }
        }
    }

    /// <inheritdoc cref="IReadOnlyDictionary{TKey,TValue}.Values"/>
    public IEnumerable< T > Values {
        get {
            foreach( var entry in entries )
            {
                if( entry.Occupied )
                    yield return entry.Value;
            }
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HashLookup{T}"/> class with the specified keys and values.
    /// </summary>
    /// <param name="keys">The <see langword="uint"/> keys to be stored in the <see cref="HashLookup{T}"/>.</param>
    /// <param name="values">The values of type <typeparamref name="T"/> corresponding to the specified keys.</param>
    /// <exception cref="ArgumentException">Thrown if the number of keys and values differ.</exception>
    public HashLookup( ReadOnlySpan< uint > keys, ReadOnlySpan< T > values )
    {
        if( keys.Length != values.Length )
            throw new ArgumentException( "Key and value counts differ", nameof( values ) );

        // Capacity = 4 * Count / 3, rounded up to the next power of two
        var capacity = 4;
        while( capacity * 3 < keys.Length * 4 )
            capacity <<= 1;

        entries = new Entry[capacity];
        mask = (uint)( capacity - 1 );

        for( var i = 0; i < keys.Length; i++ )
        {
            var slot = keys[ i ] & mask;
            while( entries[ slot ].Occupied )
            {
                if( entries[ slot ].Hash == keys[ i ] )
                    goto next;

                slot = ( slot + 1 ) & mask;
            }

            entries[ slot ].Hash = keys[ i ];
            entries[ slot ].Occupied = true;
            entries[ slot ].Value = values[ i ];
            Count++;

            next: ;
        }
    }

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetValue( uint key, out T value )
    {
        var slots = entries;
        var slot = key & mask;
        while( true )
        {
            ref var entry = ref slots[ slot ];
            if( entry.Hash == key && entry.Occupied )
            {
                value = entry.Value;
                return true;
            }

            if( !entry.Occupied )
            {
                value = default;
                return false;
            }

            slot = ( slot + 1 ) & mask;
        }
    }

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool ContainsKey( uint key ) => TryGetValue( key, out _ );

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    public IEnumerator< KeyValuePair< uint, T > > GetEnumerator()
    {
        foreach( var entry in entries )
        {
            if( entry.Occupied )
                yield return new( entry.Hash, entry.Value );
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
