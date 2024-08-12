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
public readonly struct LazyCollection<T>( ExcelPage page, uint parentOffset, uint offset, Func<ExcelPage, uint, uint, uint, T> ctor, int size ) : IReadOnlyList<T> where T : struct
{
    /// <inheritdoc/>
    public T this[int index] {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( index, size );
            return ctor( page, parentOffset, offset, (uint)index );
        }
    }

    /// <inheritdoc/>
    public int Count => size;

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator()
    {
        for( var i = 0; i < size; ++i )
            yield return this[i];
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();
}