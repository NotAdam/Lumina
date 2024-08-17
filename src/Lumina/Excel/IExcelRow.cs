using System;

namespace Lumina.Excel;

/// <summary>
/// Defines a row type/schema for an excel sheet.
/// </summary>
/// <typeparam name="T">The type that implements the interface.</typeparam>
public interface IExcelRow<T> where T : struct
{
    /// <summary>
    /// Creates an instance of the current type. Designed only for use within <see cref="Lumina"/>.
    /// </summary>
    /// <remarks>Only used for sheets that are not using subrows, and will throw otherwise.</remarks>
    /// <param name="page"></param>
    /// <param name="offset"></param>
    /// <param name="row"></param>
    /// <returns>A newly created row object.</returns>
    /// <exception cref="NotSupportedException">Thrown when the referenced sheet is using subrows.</exception>
    abstract static T Create( ExcelPage page, uint offset, uint row );

    /// <summary>
    /// Creates an instance of the current type. Designed only for use within <see cref="Lumina"/>.
    /// </summary>
    /// <remarks>Only used for sheets that are using subrows, and will throw otherwise.</remarks>
    /// <param name="page"></param>
    /// <param name="offset"></param>
    /// <param name="row"></param>
    /// <param name="subrow"></param>
    /// <returns>A newly created subrow object.</returns>
    /// <exception cref="NotSupportedException">Thrown when the referenced sheet is not using subrows.</exception>
    abstract static T Create( ExcelPage page, uint offset, uint row, ushort subrow );

    /// <summary>Gets the row ID.</summary>
    public uint RowId { get; }

    /// <summary>Gets the subrow ID.</summary>
    /// <exception cref="NotSupportedException">Thrown when the referenced sheet is not using subrows.</exception>
    public ushort SubrowId { get; }
}
