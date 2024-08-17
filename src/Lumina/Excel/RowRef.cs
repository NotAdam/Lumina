using System;

namespace Lumina.Excel;

/// <summary>
/// A helper type to dynamically reference a row in a different excel sheet.
/// </summary>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
/// <param name="rowType">The referenced row's actual <see cref="Type"/>.</param>
public readonly struct RowRef( ExcelModule? module, uint rowId, Type? rowType )
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
    /// Whether the reference is of a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <returns>Whether this <see cref="RowRef"/> points to a <typeparamref name="T"/>.</returns>
    public bool Is< T >() where T : struct, IExcelRow< T > =>
        typeof( T ) == rowType;

    /// <inheritdoc cref="Is{T}"/>
    public bool IsSubrow<T>() where T : struct, IExcelSubrow<T> =>
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

        return new RowRef< T >( module, rowId ).ValueNullable;
    }

    /// <inheritdoc cref="GetValueOrDefault{T}"/>
    public T? GetValueOrDefaultSubrow<T>() where T : struct, IExcelSubrow<T>
    {
        if( !IsSubrow<T>() || module is null )
            return null;

        return new SubrowRef<T>( module, rowId ).ValueNullable;
    }

    /// <summary>
    /// Tries to get the referenced row as a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the type is valid, the row exists, and <paramref name="row"/> is written to, and <see langword="false"/> otherwise.</returns>
    public bool TryGetValue< T >( out T row ) where T : struct, IExcelRow< T >
    {
        if( new RowRef< T >( module, rowId ).ValueNullable is { } v )
        {
            row = v;
            return true;
        }

        row = default;
        return false;
    }

    /// <inheritdoc cref="TryGetValue{T}(out T)"/>
    public bool TryGetValueSubrow<T>( out T row ) where T : struct, IExcelSubrow<T>
    {
        if( new SubrowRef<T>( module, rowId ).ValueNullable is { } v )
        {
            row = v;
            return true;
        }

        row = default;
        return false;
    }

    /// <summary>
    /// Attempts to create a <see cref="RowRef"/> to a row id of a list of row types, checking with each type in order.
    /// </summary>
    /// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
    /// <param name="rowId">The referenced row id.</param>
    /// <param name="sheetTypes">A list of row types to check against the <paramref name="rowId"/>, in order.</param>
    /// <returns>A <see cref="RowRef"/> to one of the <paramref name="sheetTypes"/>. If the row id does not exist in any of the sheets, an untyped <see cref="RowRef"/> is returned instead.</returns>
    public static RowRef GetFirstValidRowOrUntyped( ExcelModule module, uint rowId, params Type[] sheetTypes )
    {
        foreach( var sheetType in sheetTypes )
        {
            if( module.GetBaseSheet( sheetType ) is { } sheet )
            {
                if( sheet.HasRow( rowId ) )
                    return new( module, rowId, sheetType );
            }
        }

        return CreateUntyped( rowId );
    }

    /// <summary>
    /// Creates a <see cref="RowRef"/> to a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type referenced by the <paramref name="rowId"/>.</typeparam>
    /// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
    /// <param name="rowId">The referenced row id.</param>
    /// <returns>A <see cref="RowRef"/> to a row in a <see cref="BaseExcelSheet"/>.</returns>
    public static RowRef Create< T >( ExcelModule? module, uint rowId ) where T : struct, IExcelRow< T > => new( module, rowId, typeof( T ) );

    /// <inheritdoc cref="Create{T}(ExcelModule?, uint)"/>
    public static RowRef CreateSubrow<T>( ExcelModule? module, uint rowId ) where T : struct, IExcelSubrow<T> => new( module, rowId, typeof( T ) );

    /// <summary>
    /// Creates an untyped <see cref="RowRef"/>.
    /// </summary>
    /// <param name="rowId">The referenced row id.</param>
    /// <returns>An untyped <see cref="RowRef"/>.</returns>
    public static RowRef CreateUntyped( uint rowId ) => new( null, rowId, null );
}

/// <summary>
/// A helper type to concretely reference a row in a specific excel sheet.
/// </summary>
/// <typeparam name="T">The row type referenced by the <see cref="RowId"/>.</typeparam>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
public readonly struct RowRef< T >( ExcelModule? module, uint rowId ) where T : struct, IExcelRow< T >
{
    private readonly ExcelSheet<T>? _sheet = module?.GetSheet< T >();

    /// <summary>
    /// The row id of the referenced row.
    /// </summary>
    public uint RowId => rowId;

    /// <summary>
    /// Whether the <see cref="RowId"/> exists in the sheet.
    /// </summary>
    public bool IsValid => _sheet?.HasRow( RowId ) ?? false;

    /// <summary>
    /// The referenced row value itself.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if <see cref="IsValid"/> is false.</exception>
    public T Value => ValueNullable ?? throw new InvalidOperationException();

    /// <summary>
    /// Attempts to get the referenced row value. Is null if <see cref="RowId"/> does not exist in the sheet.
    /// </summary>
    public T? ValueNullable => _sheet?.GetRowOrDefault( rowId );

    private RowRef ToGeneric() => RowRef.Create< T >( module, rowId );

    /// <summary>
    /// Converts a concrete <see cref="RowRef{T}"/> to a generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="RowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( RowRef< T > row ) => row.ToGeneric();
}

/// <summary>
/// A helper type to concretely reference the first subrow of a row in a specific excel sheet.
/// </summary>
/// <typeparam name="T">The row type referenced by the <see cref="RowId"/>.</typeparam>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
public readonly struct SubrowRef<T>( ExcelModule? module, uint rowId ) where T : struct, IExcelSubrow<T>
{
    private readonly SubrowExcelSheet<T>? _sheet = module?.GetSubrowSheet<T>();

    /// <summary>
    /// The row id of the referenced subrow.
    /// </summary>
    public uint RowId => rowId;

    /// <summary>
    /// Whether the subrow exists in the sheet.
    /// </summary>
    public bool IsValid => _sheet?.HasSubrow( RowId, 0 ) ?? false;

    /// <summary>
    /// The referenced subrow value itself.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if <see cref="IsValid"/> is false.</exception>
    public T Value => ValueNullable ?? throw new InvalidOperationException();

    /// <summary>
    /// Attempts to get the referenced subrow value. Is null if it does not exist in the sheet.
    /// </summary>
    public T? ValueNullable => _sheet?.GetSubrowOrDefault( rowId, 0 );

    private RowRef ToGeneric() => RowRef.CreateSubrow<T>( module, rowId );

    /// <summary>
    /// Converts a concrete <see cref="SubrowRef{T}"/> to a generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="SubrowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( SubrowRef<T> row ) => row.ToGeneric();
}