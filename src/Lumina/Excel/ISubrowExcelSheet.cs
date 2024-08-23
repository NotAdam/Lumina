using System;

namespace Lumina.Excel;

/// <summary>A wrapper around an excel subrow sheet.</summary>
public interface ISubrowExcelSheet : IExcelSheet
{
    /// <summary>
    /// The total number of subrows in this sheet across all rows.
    /// </summary>
    int TotalSubrowCount { get; }

    /// <summary>
    /// Whether this sheet has a subrow with the given <paramref name="rowId"/> and <paramref name="subrowId"/>.
    /// </summary>
    /// <param name="rowId">The row id to check.</param>
    /// <param name="subrowId">The subrow id to check.</param>
    /// <returns>Whether the subrow exists.</returns>
    bool HasSubrow( uint rowId, ushort subrowId );

    /// <summary>
    /// Tries to get the number of subrows in the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowCount">The number of subrows in this row.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="subrowCount"/> is written to and <see langword="false"/> otherwise.</returns>
    bool TryGetSubrowCount( uint rowId, out ushort subrowCount );

    /// <summary>
    /// Gets the number of subrows in the <paramref name="rowId"/>th row in this sheet. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/>.</exception>
    ushort GetSubrowCount( uint rowId );
}