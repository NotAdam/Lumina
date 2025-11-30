namespace Lumina.Excel;

/// <summary>
/// Defines a row type/schema for an excel sheet.
/// </summary>
/// <typeparam name="T">The type that implements the interface.</typeparam>
public interface IExcelRow< out T > where T : struct
{
    /// <summary>The associated <see cref="Excel.ExcelPage"/> of the row.</summary>
    public ExcelPage ExcelPage { get; }

    /// <summary>Offset to the referenced row in the <see cref="Excel.ExcelPage"/>.</summary>
    public uint RowOffset { get; }

    /// <summary>Gets the row ID.</summary>
    uint RowId { get; }

    /// <summary>
    /// Creates an instance of the current type. Designed only for use within <see cref="Lumina"/>.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="offset"></param>
    /// <param name="row"></param>
    /// <returns>A newly created row object.</returns>
    abstract static T Create( ExcelPage page, uint offset, uint row );
}