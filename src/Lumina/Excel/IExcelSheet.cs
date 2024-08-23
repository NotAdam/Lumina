using Lumina.Data;
using Lumina.Data.Structs.Excel;
using System;
using System.Collections.Generic;

namespace Lumina.Excel;

/// <summary>A wrapper around an excel sheet.</summary>
public interface IExcelSheet
{
    /// <summary>The module that this sheet belongs to.</summary>
    ExcelModule Module { get; }

    /// <summary>The language of the rows in this sheet.</summary>
    /// <remarks>This can be different from the requested language if it wasn't supported.</remarks>
    Language Language { get; }

    /// <summary>Contains information on the columns in this sheet.</summary>
    IReadOnlyList< ExcelColumnDefinition > Columns { get; }

    /// <summary>The number of rows in this sheet.</summary>
    /// <remarks>
    /// If this sheet has gaps in row ids, it returns the number of rows that exist, not the highest row id.
    /// If this sheet has subrows, this will still return the number of rows and not the total number of subrows.
    /// </remarks>
    int Count { get; }

    /// <summary>Gets the offset of the column at <paramref name="columnIdx"/> in the row data.</summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <returns>The offset of the column.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown when the column index is invalid. It must be less than <see cref="Columns"/>.Count.</exception>
    ushort GetColumnOffset( int columnIdx );

    /// <summary>Whether this sheet has a row with the given <paramref name="rowId"/>.</summary>
    /// <remarks>If this sheet has subrows, this will check if the row id has any subrows.</remarks>
    /// <param name="rowId">The row id to check.</param>
    /// <returns>Whether the row exists.</returns>
    bool HasRow( uint rowId );
}