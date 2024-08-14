using System.Collections;
using Lumina.Data;

namespace Lumina.Excel;

/// <summary>
/// A generalized interface that all <see cref="ExcelSheet{T}"/>s implement.
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
    /// Whether or not this sheet has subrows, where each row id can have multiple subrows.
    /// </summary>
    bool HasSubrows { get; }

    /// <summary>
    /// The number of rows in this sheet.
    /// </summary>
    /// <remarks>
    /// If this sheet has gaps in row ids, it returns the number of rows that exist, not the highest row id.
    /// If this sheet has subrows, this will still return the number of rows and not the total number of subrows.
    /// </remarks>
    int Count { get; }

    /// <summary>
    /// The total number of subrows in this sheet across all rows.
    /// </summary>
    /// <exception cref="System.NotSupportedException">Thrown if the sheet does not support subrows</exception>
    int SubrowCount { get; }

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
    /// <exception cref="System.NotSupportedException">Thrown if the sheet does not support subrows</exception>
    bool HasSubrow( uint rowId, ushort subrowId );

    /// <summary>
    /// Tries to get the number of subrows in the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="System.NotSupportedException">Thrown if the sheet does not support subrows</exception>
    ushort? TryGetSubrowCount( uint rowId );

    /// <summary>
    /// Gets the number of subrows in the <paramref name="rowId"/>th row in this sheet. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="System.NotSupportedException">Thrown if the sheet does not support subrows</exception>
    /// <exception cref="System.ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/></exception>
    ushort GetSubrowCount( uint rowId );
}