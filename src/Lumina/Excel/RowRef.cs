using System;

namespace Lumina.Excel;

/// <summary>
/// A helper type to concretely reference a row in a specific excel sheet.
/// </summary>
/// <typeparam name="T">The row type referenced by the <see cref="RowId"/>.</typeparam>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
public readonly struct RowRef< T >( ExcelModule? module, uint rowId ) where T : struct, IExcelRow< T >
{
    private readonly ExcelSheet< T >? _sheet = module?.GetSheet< T >();

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
    /// Attempts to get the referenced row value. Is <see langword="null"/> if <see cref="RowId"/> does not exist in the sheet.
    /// </summary>
    public T? ValueNullable => _sheet?.GetRowOrDefault( rowId );

    private RowRef ToGeneric() => RowRef.Create< T >( module, rowId );

    /// <summary>
    /// Converts a concrete <see cref="RowRef{T}"/> to a generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="RowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( RowRef< T > row ) => row.ToGeneric();
}
