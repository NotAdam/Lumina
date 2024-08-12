using System;
using System.Collections;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

public sealed class ExcelSheet<T> : IExcelSheet, IReadOnlyList<T> where T : struct, IExcelRow<T>
{
    /// <inheritdoc/>
    public ExcelModule Module { get; }

    /// <inheritdoc/>
    public Language Language { get; }

    private List<ExcelPage> Pages { get; }
    private FrozenDictionary<uint, (int PageIdx, uint Offset)>? Rows { get; }
    private FrozenDictionary<uint, (int PageIdx, uint Offset, ushort RowCount)>? Subrows { get; }
    private ushort SubrowDataOffset { get; }

    /// <summary>
    /// Whether or not this sheet has subrows, where each row id can have multiple subrows.
    /// </summary>
    [MemberNotNullWhen( true, nameof( Subrows ), nameof( SubrowDataOffset ) )]
    [MemberNotNullWhen( false, nameof( Rows ) )]
    public bool HasSubrows { get; }

    private static SheetAttribute Attribute =>
        typeof( T ).GetCustomAttribute<SheetAttribute>() ??
            throw new InvalidOperationException( "T has no SheetAttribute. Use the explicit sheet constructor." );

    /// <summary>
    /// The number of rows in this sheet.
    /// </summary>
    /// <remarks>
    /// If this sheet has gaps in row ids, it returns the number of rows that exist, not the highest row id.
    /// If this sheet has subrows, this will still return the number of rows and not the total number of subrows.
    /// </remarks>
    public int Count => Rows?.Count ?? Subrows!.Count;

    /// <summary>
    /// Get the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <remarks>This is an indexer helper, but you may want to treat this as a sparse list/matrix since <see cref="Count"/> only represents the total number of rows in the sheet, and not the highest row id.</remarks>
    /// <param name="rowId">The row id of the row you want</param>
    /// <returns>The row at <paramref name="rowId"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws when the row id does not have a row attached to it.</exception>
    public T this[int rowId] => GetRow( (uint)rowId );

    /// <summary>
    /// Create an <see cref="ExcelSheet{T}"/> instance with the <paramref name="module"/>'s default language.
    /// </summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <exception cref="InvalidOperationException"><see cref="T"/> does not have a valid <see cref="SheetAttribute"/></exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute"/> parameters were invalid (hash mismatch or invalid sheet name)</exception>
    public ExcelSheet( ExcelModule module ) : this( module, module.Language )
    {

    }

    /// <summary>
    /// Create an <see cref="ExcelSheet{T}"/> instance with a specific <see cref="Data.Language"/>.
    /// </summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="requestedLanguage">The language to use for this sheet.</param>
    /// <exception cref="InvalidOperationException"><see cref="T"/> does not have a valid <see cref="SheetAttribute"/></exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute"/> parameters were invalid (hash mismatch or invalid sheet name)</exception>
    public ExcelSheet( ExcelModule module, Language requestedLanguage ) : this( module, requestedLanguage, Attribute.Name, Attribute.ColumnHash )
    {

    }

    /// <summary>
    /// Create an <see cref="ExcelSheet{T}"/> instance with a specific <see cref="Data.Language"/>, name, and hash.
    /// </summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="requestedLanguage">The language to use for this sheet.</param>
    /// <param name="sheetName">The name of the sheet to read from.</param>
    /// <param name="columnHash">The hash of the columns in the sheet. If <see langword="null"/>, it will not check the hash.</param>
    /// <exception cref="ArgumentException"><paramref name="sheetName"/> or <paramref name="columnHash"/> parameters were invalid (hash mismatch or invalid sheet name)</exception>
    public ExcelSheet( ExcelModule module, Language requestedLanguage, string sheetName, uint? columnHash = null )
    {
        Module = module;

        var headerFile = module.GameData.GetFile<ExcelHeaderFile>( $"exd/{sheetName}.exh" ) ??
            throw new ArgumentException( "Invalid sheet name", nameof( sheetName ) );

        if( columnHash is { } hash && headerFile.GetColumnsHash() != hash )
            throw new ArgumentException( "Column hash mismatch", nameof( columnHash ) );

        HasSubrows = headerFile.Header.Variant == ExcelVariant.Subrows;

        Language = headerFile.Languages.Contains( requestedLanguage ) ? requestedLanguage : Language.None;

        Dictionary<uint, (int PageIdx, uint Offset)>? rows = null;
        Dictionary<uint, (int PageIdx, uint Offset, ushort RowCount)>? subrows = null;

        if( HasSubrows )
        {
            subrows = new( (int)headerFile.Header.RowCount );
            SubrowDataOffset = headerFile.Header.DataOffset;
        }
        else
            rows = new( (int)headerFile.Header.RowCount );

        Pages = new( headerFile.DataPages.Length );
        var pageIdx = 0;
        foreach( var pageDef in headerFile.DataPages )
        {
            var filePath = Language == Language.None ?
                $"exd/{sheetName}_{pageDef.StartId}.exd" :
                $"exd/{sheetName}_{pageDef.StartId}_{LanguageUtil.GetLanguageStr( Language )}.exd";
            var fileData = module.GameData.GetFile<ExcelDataFile>( filePath );
            if( fileData == null )
                continue;

            var newPage = new ExcelPage( Module, fileData.Data, headerFile.Header.DataOffset );
            Pages.Add( newPage );

            foreach( var rowPtr in fileData.RowData.Values )
            {
                var (rowDataSize, subrowCount) = (newPage.ReadUInt32( rowPtr.Offset ), newPage.ReadUInt16( rowPtr.Offset + 4 ));
                var rowOffset = rowPtr.Offset + 6;

                if( HasSubrows )
                {
                    if( subrowCount > 0 )
                        subrows!.Add( rowPtr.RowId, (pageIdx, rowOffset, subrowCount) );
                }
                else
                    rows!.Add( rowPtr.RowId, (pageIdx, rowOffset) );
            }

            pageIdx++;
        }

        if( HasSubrows )
            Subrows = subrows!.ToFrozenDictionary();
        else
            Rows = rows!.ToFrozenDictionary();
    }

    /// <inheritdoc/>
    public bool HasRow( uint rowId )
    {
        if( HasSubrows )
            return Subrows.ContainsKey( rowId );

        return Rows.ContainsKey( rowId );
    }

    /// <inheritdoc/>
    public bool HasSubrow( uint rowId, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref Subrows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return false;

        return subrowId < val.RowCount;
    }

    /// <inheritdoc/>
    public ushort? TryGetSubrowCount( uint rowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref Subrows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        return val.RowCount;
    }

    /// <inheritdoc/>
    public ushort GetSubrowCount( uint rowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref Subrows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

        return val.RowCount;
    }

    private T CreateRow(uint rowId, in (int PageIdx, uint Offset) val) =>
        T.Create( Pages[val.PageIdx], val.Offset, rowId );

    private T CreateSubrow( uint rowId, ushort subrowId, in (int PageIdx, uint Offset, ushort RowCount) val ) =>
        T.Create( Pages[val.PageIdx], val.Offset + 2 + ( subrowId * ( SubrowDataOffset + 2u ) ), rowId, subrowId );

    /// <summary>
    /// Tries to get the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>A nullable row object. Returns null if the row does not exist.</returns>
    public T? TryGetRow( uint rowId )
    {
        if( HasSubrows )
            return TryGetSubrow( rowId, 0 );

        ref readonly var val = ref Rows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        return CreateRow( rowId, in val );
    }


    /// <summary>
    /// Tries to get the <paramref name="subrowId"/>th subrow from the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <param name="subrowId">The subrow id to get</param>
    /// <returns>A nullable row object. Returns null if the subrow does not exist.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    public T? TryGetSubrow( uint rowId, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref Subrows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        if( subrowId >= val.RowCount )
            return null;

        return CreateSubrow( rowId, subrowId, in val );
    }

    /// <summary>
    /// Gets the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>A row object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/></exception>
    public T GetRow( uint rowId ) =>
        TryGetRow( rowId ) ??
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

    /// <summary>
    /// Gets the <paramref name="subrowId"/>th subrow from the <paramref name="rowId"/>th row in this sheet. Throws if the subrow does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <param name="subrowId">The subrow id to get</param>
    /// <returns>A row object.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/></exception>
    public T GetSubrow( uint rowId, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref Subrows.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, val.RowCount );

        return CreateSubrow( rowId, subrowId, in val );
    }

    /// <summary>
    /// Returns an enumerator that can be used to iterate over all subrows in all rows in this sheet.
    /// </summary>
    /// <returns>An <see cref="IEnumerator{T}"/> of all subrows in this sheet</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    public IEnumerator<T> GetSubrowEnumerator()
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot enumerate subrows in a sheet that doesn't support any." );

        foreach( var rowData in Subrows )
        {
            for( ushort i = 0; i < rowData.Value.RowCount; ++i )
                yield return CreateSubrow( rowData.Key, i, rowData.Value );
        }
    }

    /// <summary>
    /// Returns an enumerator that can be used to iterate over all rows in this sheet. If this sheet has subrows, it will iterate over the first subrow of every row.
    /// </summary>
    /// <returns>An <see cref="IEnumerator{T}"/> of all rows (or first subrows) in this sheet</returns>
    public IEnumerator<T> GetEnumerator()
    {
        if( !HasSubrows )
        {
            foreach( var rowData in Rows )
                yield return CreateRow( rowData.Key, rowData.Value );
        }
        else
        {
            foreach( var rowData in Subrows )
                yield return CreateSubrow( rowData.Key, 0, rowData.Value );
        }
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
