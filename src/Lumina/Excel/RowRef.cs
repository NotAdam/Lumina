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
    /// Whether or not the <see cref="RowRef"/> is untyped.
    /// </summary>
    /// <remarks>
    /// An untyped <see cref="RowRef"/> is one that doesn't know which sheet it links to.
    /// </remarks>
    public bool IsUntyped => rowType == null;

    /// <summary>
    /// Whether or not the reference is of a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <returns>Whether or not this <see cref="RowRef"/> points to a <typeparamref name="T"/>.</returns>
    public bool Is<T>() where T : struct, IExcelRow<T> =>
        typeof( T ) == rowType;

    /// <summary>
    /// Tries to get the referenced row as a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <returns>The referenced row type. Returns null if this <see cref="RowRef"/> does not point to a <typeparamref name="T"/> or if the <see cref="RowId"/> does not exist in its sheet.</returns>
    public T? GetValueOrDefault<T>() where T : struct, IExcelRow<T>
    {
        if( !Is<T>() )
            return null;

        return module!.GetSheet<T>().GetRowOrDefault( RowId );
    }

    /// <summary>
    /// Tries to get the referenced row as a specific row type.
    /// </summary>
    /// <typeparam name="T">The row type/schema to check against.</typeparam>
    /// <param name="row">The output row object.</param>
    /// <returns><see langword="true"/> if the type is valid, the row exists, and <paramref name="row"/> is written to, and <see langword="false"/> otherwise.</returns>
    public bool TryGetValue<T>( out T row ) where T : struct, IExcelRow<T>
    {
        if( !Is<T>() )
        {
            row = default;
            return false;
        }

        return module!.GetSheet<T>().TryGetRow( RowId, out row );
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
            if( module.GetSheetGeneric( sheetType ) is { } sheet )
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
    /// <returns>A <see cref="RowRef"/> to a row in a <see cref="ExcelSheet{T}"/>.</returns>
    public static RowRef Create<T>( ExcelModule module, uint rowId ) where T : struct, IExcelRow<T> => new( module, rowId, typeof( T ) );

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
public readonly struct RowRef<T>( ExcelModule module, uint rowId ) where T : struct, IExcelRow<T>
{
    private readonly ExcelSheet<T> sheet = module.GetSheet<T>();

    /// <summary>
    /// The row id of the referenced row.
    /// </summary>
    public uint RowId => rowId;

    /// <summary>
    /// Whether or not the <see cref="RowId"/> exists in the sheet.
    /// </summary>
    public bool IsValid => sheet.HasRow( RowId );

    /// <summary>
    /// The referenced row value itself.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <see cref="IsValid"/> is false.</exception>
    public T Value => sheet.GetRow( RowId );

    /// <summary>
    /// Attempts to get the referenced row value. Is null if <see cref="RowId"/> does not exist in the sheet.
    /// </summary>
    public T? ValueNullable => sheet.GetRowOrDefault( RowId );

    private RowRef ToGeneric() => RowRef.Create<T>( module, rowId );

    /// <summary>
    /// Converts a concrete <see cref="RowRef{T}"/> to an generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="RowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( RowRef<T> row ) => row.ToGeneric();
}