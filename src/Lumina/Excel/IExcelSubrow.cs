namespace Lumina.Excel;

/// <summary>
/// Defines a subrow type/schema for an excel sheet.
/// </summary>
/// <typeparam name="T">The type that implements the interface.</typeparam>
public interface IExcelSubrow< out T > where T : struct
{
    /// <summary>Gets the row ID.</summary>
    uint RowId { get; }

    /// <summary>Gets the subrow ID.</summary>
    ushort SubrowId { get; }

    /// <summary>
    /// Creates an instance of the current type. Designed only for use within <see cref="Lumina"/>.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="offset"></param>
    /// <param name="row"></param>
    /// <param name="subrow"></param>
    /// <returns>A newly created subrow object.</returns>
    abstract static T Create( ExcelPage page, uint offset, uint row, ushort subrow );
}