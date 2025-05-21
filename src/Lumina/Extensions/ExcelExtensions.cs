using Lumina.Excel;

namespace Lumina.Extensions;

/// <summary>
/// Extensions for <see cref="ExcelSheet{T}"/>, <see cref="IExcelRow{T}"/>, and <see cref="IExtendedExcelRow{T}"/>.
/// </summary>
public static class RowExcelExtensions
{
    public static RowRef<T> GetRowRef<T>(this ExcelSheet<T> sheet, uint rowId) where T : struct, IExcelRow<T>
    {
        return new RowRef<T>( sheet.RawSheet, rowId );
    }

    public static RowRef GetGenericRowRef<T>( this ExcelSheet<T> sheet, uint rowId ) where T : struct, IExcelRow<T>
    {
        return RowRef.Create<T>( sheet.Module, rowId, sheet.Language );
    }

    public static RowRef<T> AsRowRef<T>( this T row ) where T : struct, IExcelRow<T>, IExtendedExcelRow<T>
    {
        return new RowRef<T>( row.Page.Sheet, row.RowId );
    }

    public static RowRef AsGenericRowRef<T>( this T row ) where T : struct, IExcelRow<T>, IExtendedExcelRow<T>
    {
        return RowRef.Create<T>( row.Page.Module, row.RowId, row.Page.Language );
    }

    public static RawRow AsRawRow<T>( this T row ) where T : struct, IExcelRow<T>, IExtendedExcelRow<T>
    {
        return new RawRow( row.Page, row.Offset, row.RowId );
    }
}

/// <summary>
/// Extensions for <see cref="SubrowExcelSheet{T}"/>, <see cref="IExcelSubrow{T}"/>, and <see cref="IExtendedExcelSubrow{T}"/>.
/// </summary>
public static class SubrowExcelExtensions
{
    public static SubrowRef<T> GetRowRef<T>( this SubrowExcelSheet<T> sheet, uint rowId ) where T : struct, IExcelSubrow<T>
    {
        return new SubrowRef<T>( sheet.RawSheet, rowId );
    }

    public static RowRef GetGenericRowRef<T>( this SubrowExcelSheet<T> sheet, uint rowId ) where T : struct, IExcelSubrow<T>
    {
        return RowRef.CreateSubrow<T>( sheet.Module, rowId, sheet.Language );
    }

    public static SubrowRef<T> AsRowRef<T>( this T row ) where T : struct, IExcelSubrow<T>, IExtendedExcelSubrow<T>
    {
        return new SubrowRef<T>( (RawSubrowExcelSheet)row.Page.Sheet, row.RowId );
    }

    public static RowRef AsGenericRowRef<T>( this T row ) where T : struct, IExcelSubrow<T>, IExtendedExcelSubrow<T>
    {
        return RowRef.CreateSubrow<T>( row.Page.Module, row.RowId, row.Page.Language );
    }

    public static RawSubrow AsRawRow<T>( this T row ) where T : struct, IExcelSubrow<T>, IExtendedExcelSubrow<T>
    {
        return new RawSubrow( row.Page, row.Offset, row.RowId, row.SubrowId );
    }
}
