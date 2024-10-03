using Lumina.Data;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Lumina.Excel;

/// <summary>
/// A helper type to dynamically reference a row in a specific excel sheet.
/// </summary>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
/// <param name="rowType">The referenced row's actual <see cref="Type"/>.</param>
/// <param name="language">The associated language of the referenced row. Leave <see langword="null"/> to use <paramref name="module"/>'s default language.</param>
public readonly struct RowRef( ExcelModule? module, uint rowId, Type? rowType, Language? language = null )
{
    /// <summary>
    /// The row id of the referenced row.
    /// </summary>
    public uint RowId => rowId;

    /// <summary>
    /// Whether the <see cref="RowRef"/> is untyped.
    /// </summary>
    /// <remarks>
    /// An untyped <see cref="RowRef"/> is one that doesn't know which sheet it links to.
    /// </remarks>
    public bool IsUntyped => rowType == null;

    /// <summary>
    /// The associated language of this row.
    /// </summary>
    /// <remarks>
    /// Can be <see langword="null"/> if this <see cref="RowRef"/> has no associated <see cref="ExcelModule"/>.
    /// </remarks>
    public Language? Language => language ?? module?.Language;

    /// <summary>
    /// Whether the reference is of a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <returns>Whether this <see cref="RowRef"/> points to a <typeparamref name="T"/>.</returns>
    public bool Is< T >() where T : struct, IExcelRow< T > =>
        typeof( T ) == rowType;

    /// <inheritdoc cref="Is{T}"/>
    public bool IsSubrow< T >() where T : struct, IExcelSubrow< T > =>
        typeof( T ) == rowType;

    /// <summary>
    /// Tries to get the referenced row as a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <returns>The referenced row type. Returns null if this <see cref="RowRef"/> does not point to a <typeparamref name="T"/> or if the <see cref="RowId"/> does not exist in its sheet.</returns>
    public T? GetValueOrDefault< T >() where T : struct, IExcelRow< T >
    {
        if( !Is< T >() || module is null )
            return null;

        return new RowRef< T >( module, rowId, language ).ValueNullable;
    }

    /// <inheritdoc cref="GetValueOrDefault{T}"/>
    public SubrowCollection< T >? GetValueOrDefaultSubrow< T >() where T : struct, IExcelSubrow< T >
    {
        if( !IsSubrow< T >() || module is null )
            return null;

        return new SubrowRef< T >( module, rowId, language ).ValueNullable;
    }

    /// <summary>
    /// Tries to get the referenced row as a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the type is valid, the row exists, and <paramref name="row"/> is written to, and <see langword="false"/> otherwise.</returns>
    public bool TryGetValue< T >( out T row ) where T : struct, IExcelRow< T >
    {
        if( !Is< T >() || module is null )
        {
            row = default;
            return false;
        }

        row = new RowRef< T >( module, rowId, language ).Value;
        return true;
    }

    /// <inheritdoc cref="TryGetValue{T}(out T)"/>
    public bool TryGetValueSubrow< T >( out SubrowCollection< T > row ) where T : struct, IExcelSubrow< T >
    {
        if( !IsSubrow< T >() || module is null )
        {
            row = default;
            return false;
        }

        row = new SubrowRef< T >( module, rowId, language ).Value;
        return true;
    }

    /// <summary>
    /// Attempts to create a <see cref="RowRef"/> to a row id of a list of row types, checking with each type in order.
    /// </summary>
    /// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
    /// <param name="rowId">The referenced row id.</param>
    /// <param name="types">A list of <see cref="IExcelRow{T}"/>/<see cref="IExcelSubrow{T}"/> types to check against <paramref name="rowId"/>, in order.</param>
    /// <param name="typeHash">The order-sensitive hash of <paramref name="types"/>.</param>
    /// <param name="language">The associated language of the row. Leave <see langword="null"/> to use <paramref name="module"/>'s default language instead.</param>
    /// <returns>A <see cref="RowRef"/> to one of the <paramref name="types"/>. If the row id does not exist in any of the sheets, an untyped <see cref="RowRef"/> is returned instead.</returns>
    /// <remarks>Use <see cref="CreateTypeHash(ReadOnlySpan{Type})"/> to generate a <paramref name="typeHash"/>. It's recommended to make this a compile-time constant if possible to improve performance.</remarks>
    public static RowRef GetFirstValidRowOrUntyped( ExcelModule module, uint rowId, ReadOnlySpan< Type > types, [ConstantExpected] int typeHash, Language? language = null )
    {
        if( module.FindRowInterval( rowId, types, typeHash ) is { } type )
            return new( module, rowId, type, language );

        return CreateUntyped( rowId, language ?? module.Language );
    }

    /// <remarks/>
    /// <inheritdoc cref="GetFirstValidRowOrUntyped(ExcelModule, uint, ReadOnlySpan{Type}, int, Nullable{Language})"/>
    [Obsolete( "It's recommended to use the other overload and to manually generate a typeHash. Only this overload if you are explicitly disregarding performance." )]
    public static RowRef GetFirstValidRowOrUntyped( ExcelModule module, uint rowId, ReadOnlySpan< Type > types, Language? language = null )
    {
        var hash = new HashCode();
        foreach( var hashType in types )
            hash.Add( hashType.TypeHandle.Value );

#pragma warning disable CA1857 // ConstantExpectedAttribute is explicitly ignored; we are re-emitting a warning with ObsoleteAttribute.
        if( module.FindRowInterval( rowId, types, hash.ToHashCode() ) is { } type )
#pragma warning restore CA1857
            return new( module, rowId, type, language );

        return CreateUntyped( rowId, language ?? module.Language );
    }

    /// <summary>
    /// Creates an order-sensitive hash of <paramref name="types"/>.
    /// </summary>
    /// <param name="types">A list of ordered <see cref="IExcelRow{T}"/>/<see cref="IExcelSubrow{T}"/> types.</param>
    /// <returns>A <c>typeHash</c> for use in <see cref="GetFirstValidRowOrUntyped(ExcelModule, uint, ReadOnlySpan{Type}, int)"/></returns>
    /// <remarks>It is not recommended to call this at runtime because of the performance hit. Use <see cref="GetFirstValidRowOrUntyped(ExcelModule, uint, ReadOnlySpan{Type}, Nullable{Language})"/> if you do not have a <c>typeHash</c> at compile-time.</remarks>
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public static int CreateTypeHash( ReadOnlySpan< Type > types )
    {
        var ret = new HashCode();
        foreach( var type in types )
            ret.Add( $"{type.Assembly.FullName};{type.FullName}" );
        return ret.ToHashCode();
    }

    /// <summary>
    /// Creates a <see cref="RowRef"/> to a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type referenced by the <paramref name="rowId"/>.</typeparam>
    /// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
    /// <param name="rowId">The referenced row id.</param>
    /// <param name="language">The associated language of the row. Leave <see langword="null"/> to use <paramref name="module"/>'s default language instead.</param>
    /// <returns>A <see cref="RowRef"/> to a row in a <see cref="IExcelSheet"/>.</returns>
    public static RowRef Create< T >( ExcelModule? module, uint rowId, Language? language = null ) where T : struct, IExcelRow< T > => new( module, rowId, typeof( T ), language );

    /// <inheritdoc cref="Create{T}(ExcelModule?, uint, Nullable{Language})"/>
    public static RowRef CreateSubrow< T >( ExcelModule? module, uint rowId, Language? language = null ) where T : struct, IExcelSubrow< T > => new( module, rowId, typeof( T ), language );

    /// <summary>
    /// Creates an untyped <see cref="RowRef"/>.
    /// </summary>
    /// <param name="rowId">The referenced row id.</param>
    /// <param name="language">The associated language of the row, if there is any.</param>
    /// <returns>An untyped <see cref="RowRef"/>.</returns>
    public static RowRef CreateUntyped( uint rowId, Language? language = null ) => new( null, rowId, null, language );
}