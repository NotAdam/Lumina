using Lumina.Data;
using System;

namespace Lumina.Excel;

/// <summary>
/// A helper type to concretely reference a row in a specific excel sheet.
/// </summary>
/// <typeparam name="T">The row type referenced by the <see cref="RowId"/>.</typeparam>
/// <param name="module">The <see cref="ExcelModule"/> to read sheet data from.</param>
/// <param name="rowId">The referenced row id.</param>
/// <param name="language">The associated language of the referenced row. Leave <see langword="null"/> to use <paramref name="module"/>'s default language.</param>
public struct RowRef< T >( ExcelModule? module, uint rowId, Language? language = null ) where T : struct, IExcelRow< T >
{
    private ExcelSheet< T >? _sheet = null; 
    private ExcelSheet< T >? Sheet {
        get {
            if( module == null )
                return null;
            return _sheet ??= module.GetSheet< T >(
                language == Data.Language.None ?
                    null : // Use default language if null (or fall back to None)
                    language
                );
        }
    }

    /// <summary>
    /// The row id of the referenced row.
    /// </summary>
    public readonly uint RowId => rowId;

    /// <summary>
    /// The associated language of this row.
    /// </summary>
    /// <remarks>
    /// Can be <see langword="null"/> if this <see cref="RowRef"/> has no associated <see cref="ExcelModule"/>.
    /// </remarks>
    public readonly Language? Language => language ?? module?.Language;

    /// <summary>
    /// Whether the <see cref="RowId"/> exists in the sheet.
    /// </summary>
    public bool IsValid => Sheet?.HasRow( RowId ) ?? false;

    /// <summary>
    /// The referenced row value itself.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if <see cref="IsValid"/> is false.</exception>
    public T Value => ValueNullable ?? throw new InvalidOperationException();

    /// <summary>
    /// Attempts to get the referenced row value. Is <see langword="null"/> if <see cref="RowId"/> does not exist in the sheet.
    /// </summary>
    public T? ValueNullable => Sheet?.GetRowOrDefault( rowId );

    private readonly RowRef ToGeneric() => RowRef.Create< T >( module, rowId, language );

    /// <summary>
    /// Converts a concrete <see cref="RowRef{T}"/> to a generic and dynamically typed <see cref="RowRef"/>.
    /// </summary>
    /// <param name="row">The <see cref="RowRef{T}"/> to convert.</param>
    public static explicit operator RowRef( RowRef< T > row ) => row.ToGeneric();
}