using System.Collections;
using Lumina.Data;

namespace Lumina.Excel;

/// <summary>
/// A generalized interface that all <see cref="ExcelSheet{}"/>s implement.
/// </summary>
/// <remarks>This interface exists to assist with more generic and reflection-based operations.</remarks>
public interface IExcelSheet : IEnumerable
{
    /// <summary>
    /// The module that this sheet belongs to.
    /// </summary>
    ExcelModule Module { get; }

    /// <summary>
    /// The language of the rows in this sheet.
    /// </summary>
    /// <remarks>This can be different from the requested language if it wasn't supported.</remarks>
    Language Language { get; }

    /// <summary>
    /// Whether or not this sheet has a row with the given <paramref name="rowId"/>.
    /// </summary>
    /// <remarks>
    /// If this sheet has subrows, this will check if the row id has any subrows.
    /// </remarks>
    /// <param name="rowId">The row id to check</param>
    /// <returns>Whether or not the row exists</returns>
    bool HasRow( uint rowId );

    /// <summary>
    /// Whether or not this sheet has a subrow with the given <paramref name="rowId"/> and <paramref name="subrowId"/>.
    /// </summary>
    /// <param name="rowId">The row id to check</param>
    /// <param name="subrowId">The subrow id to check</param>
    /// <returns>Whether or not the subrow exists</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    bool HasSubrow( uint rowId, ushort subrowId );

    /// <summary>
    /// Tries to get the number of subrows in the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    ushort? TryGetSubrowCount( uint rowId );

    /// <summary>
    /// Gets the number of subrows in the <paramref name="rowId"/>th row in this sheet. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/></exception>
    ushort GetSubrowCount( uint rowId );
}