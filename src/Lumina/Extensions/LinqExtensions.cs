using System;
using System.Collections.Generic;

namespace Lumina.Extensions;

/// <summary>
/// Utility class for additional struct-based enumerable operations.
/// </summary>
/// <remarks>Most useful for easily looping over <see cref="Excel.ExcelSheet{T}"/> and <see cref="Excel.SubrowExcelSheet{T}"/> types.</remarks>
public static class LinqExtensions
{
    /// <summary>Returns the first element of a sequence, or <see langword="null"/> if the sequence contains no elements.</summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to return the first element of.</param>
    /// <returns><see langword="null"/> if <paramref name="source"/> is empty; otherwise, the first element in <paramref name="source"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static T? FirstOrNull<T>( this IEnumerable<T> source ) where T : struct
    {
        ArgumentNullException.ThrowIfNull( source );

        var e = source.GetEnumerator();
        if( e.MoveNext() )
        {
            return e.Current;
        }

        return null;
    }

    /// <summary>Returns the first element of the sequence that satisfies a condition or <see langword="null"/> if no such element is found.</summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to return an element from.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <returns><see langword="null"/> if <paramref name="source"/> is empty or if no element passes the test specified by <paramref name="predicate"/>; otherwise, the first element in <paramref name="source"/> that passes the test specified by <paramref name="predicate"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is <see langword="null"/>.</exception>
    public static T? FirstOrNull<T>( this IEnumerable<T> source, Predicate<T> predicate ) where T : struct
    {
        ArgumentNullException.ThrowIfNull( source );
        ArgumentNullException.ThrowIfNull( predicate );

        foreach( var element in source )
        {
            if( predicate( element ) )
            {
                return element;
            }
        }

        return null;
    }

    // https://github.com/dotnet/runtime/blob/96ae7cfefb0ae0ad621edc56bf690da174d9c7ab/src/libraries/System.Linq/src/System/Linq/First.cs#L65
    /// <summary>Attempts to get the first element of a sequence.</summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to return the first element of.</param>
    /// <param name="result"><see langword="default"/> if <paramref name="source"/> is empty; otherwise, the first element in <paramref name="source"/>.</param>
    /// <returns>Whether or not the first element was found.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static bool TryGetFirst<T>( this IEnumerable<T> source, out T result ) where T : struct
    {
        ArgumentNullException.ThrowIfNull( source );

        using( var e = source.GetEnumerator() )
        {
            if( e.MoveNext() )
            {
                result = e.Current;
                return true;
            }
        }

        result = default;
        return false;
    }

    // https://github.com/dotnet/runtime/blob/96ae7cfefb0ae0ad621edc56bf690da174d9c7ab/src/libraries/System.Linq/src/System/Linq/First.cs#L105
    /// <summary>Attempts to get the first element of the sequence that satisfies a condition.</summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to return an element from.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="result"><see langword="default"/> if <paramref name="source"/> is empty or if no element passes the test specified by <paramref name="predicate"/>; otherwise, the first element in <paramref name="source"/> that passes the test specified by <paramref name="predicate"/>.</param>
    /// <returns>Whether or not an element was found that passes <paramref name="predicate"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is <see langword="null"/>.</exception>
    public static bool TryGetFirst<T>( this IEnumerable<T> source, Predicate<T> predicate, out T result ) where T : struct
    {
        ArgumentNullException.ThrowIfNull( source );
        ArgumentNullException.ThrowIfNull( predicate );

        foreach( var element in source )
        {
            if( predicate( element ) )
            {
                result = element;
                return true;
            }
        }

        result = default;
        return false;
    }
}