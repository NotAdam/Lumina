using System;

namespace Lumina.Excel;

/// <summary>
/// A helper type to concretely reference a collection of subrows in a specific excel sheet.
/// </summary>
/// <typeparam name="T">The subrow type referenced by the subrows of <see cref="RowId"/>.</typeparam>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
public readonly struct SubrowRef< T >( ExcelModule? module, uint rowId ) where T : struct, IExcelSubrow< T >
{
    private readonly SubrowExcelSheet< T >? _sheet = module?.GetSubrowSheet<T>();

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
    public SubrowCollection< T > Value => ValueNullable ?? throw new InvalidOperationException();

    /// <summary>
    /// Attempts to get the referenced row value. Is <see langword="null"/> if it does not exist in the sheet.
    /// </summary>
    public SubrowCollection< T >? ValueNullable => _sheet?.GetRowOrDefault( rowId );

    private RowRef ToGeneric() => RowRef.CreateSubrow< T >( module, rowId );

    /// <summary>
    /// Converts a concrete <see cref="SubrowRef{T}"/> to a generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="SubrowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( SubrowRef< T > row ) => row.ToGeneric();
}