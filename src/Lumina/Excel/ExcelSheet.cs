using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

public sealed partial class ExcelSheet<T> : IExcelSheet where T : struct, IExcelRow<T>
{
    /// <inheritdoc/>
    public ExcelModule Module { get; }

    /// <inheritdoc/>
    public Language Language { get; }

    /// <inheritdoc/>
    [MemberNotNullWhen( true, nameof( Subrows ), nameof( SubrowDataOffset ) )]
    [MemberNotNullWhen( false, nameof( Rows ) )]
    public bool HasSubrows { get; }

    private List<ExcelPage> Pages { get; }
    private (uint RowId, (int PageIdx, uint Offset) Data)[]? Rows { get; }
    private (uint RowId, (int PageIdx, uint Offset, ushort RowCount) Data)[]? Subrows { get; }
    private FrozenDictionary<uint, int> RowLookup { get; }
    private ushort SubrowDataOffset { get; }

    private static SheetAttribute Attribute =>
        typeof( T ).GetCustomAttribute<SheetAttribute>() ??
            throw new InvalidOperationException( "T has no SheetAttribute. Use the explicit sheet constructor." );

    /// <inheritdoc cref="GetRow(uint)"/>
    public T this[uint rowId] => GetRow( rowId );

    /// <inheritdoc cref="GetSubrow(uint, ushort)"/>
    public T this[uint rowId, ushort subrowId] => GetSubrow( rowId, subrowId );

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

        List<(uint RowId, (int PageIdx, uint Offset) Data)>? rows = null;
        List<(uint RowId, (int PageIdx, uint Offset, ushort RowCount) Data)>? subrows = null;
        var totalSubrowCount = 0;

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
                var subrowCount = newPage.ReadUInt16( rowPtr.Offset + 4 );
                var rowOffset = rowPtr.Offset + 6;

                if( HasSubrows )
                {
                    if( subrowCount > 0 )
                    {
                        subrows!.Add( (rowPtr.RowId, (pageIdx, rowOffset, subrowCount)) );
                        totalSubrowCount += subrowCount;
                    }
                }
                else
                    rows!.Add( (rowPtr.RowId, (pageIdx, rowOffset)) );
            }

            pageIdx++;
        }

        if( HasSubrows )
        {
            Subrows = [.. subrows!];
            int i = 0;
            RowLookup = subrows!.ToFrozenDictionary( row => row.RowId, _ => i++ );
            subrowCount = totalSubrowCount;
        }
        else
        {
            Rows = [.. rows!];
            int i = 0;
            RowLookup = rows!.ToFrozenDictionary( row => row.RowId, _ => i++ );
        }
    }

    /// <inheritdoc/>
    public bool HasRow( uint rowId ) =>
        RowLookup.ContainsKey( rowId );

    /// <inheritdoc/>
    public bool HasSubrow( uint rowId, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return false;

        return subrowId < Subrows[val].Data.RowCount;
    }

    /// <inheritdoc/>
    public ushort? TryGetSubrowCount( uint rowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        return Subrows[val].Data.RowCount;
    }

    /// <inheritdoc/>
    public ushort GetSubrowCount( uint rowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

        return Subrows[val].Data.RowCount;
    }

    private T CreateRow( uint rowId, in (int PageIdx, uint Offset) val ) =>
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

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        return CreateRow( rowId, in Rows[val].Data );
    }


    /// <summary>
    /// Tries to get the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <param name="subrowId">The subrow id to get</param>
    /// <returns>A nullable row object. Returns null if the subrow does not exist.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    public T? TryGetSubrow( uint rowId, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            return null;

        if( subrowId >= Subrows[val].Data.RowCount )
            return null;

        return CreateSubrow( rowId, subrowId, in Subrows[val].Data );
    }

    /// <summary>
    /// Gets the <paramref name="rowId"/>th row in this sheet. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <param name="rowId">The row id to get</param>
    /// <returns>A row object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws when the row id does not have a row attached to it.</exception>
    public T GetRow( uint rowId ) =>
        TryGetRow( rowId ) ??
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

    /// <summary>
    /// Gets the <paramref name="subrowId"/>th subrow with row id <paramref name="rowId"/> in this sheet. Throws if the subrow does not exist.
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

        ref readonly var val = ref RowLookup.GetValueRefOrNullRef( rowId );
        if( Unsafe.IsNullRef( in val ) )
            throw new ArgumentOutOfRangeException( nameof( rowId ), "Row does not exist" );

        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( subrowId, Subrows[val].Data.RowCount );

        return CreateSubrow( rowId, subrowId, in Subrows[val].Data );
    }

    /// <summary>
    /// Gets the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order. If this sheet has subrows, it will return the first subrow.
    /// </summary>
    /// <remarks>If you are looking to find a row by its id, use <see cref="GetRow(uint)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row</param>
    /// <returns>A row object.</returns>
    public T GetRowAt( int rowIndex )
    {
        if( HasSubrows )
            return GetSubrowAt( rowIndex, 0 );

        var data = Rows[rowIndex];
        return CreateRow( data.RowId, in data.Data );
    }

    /// <summary>
    /// Gets the <paramref name="subrowId"/>th subrow of the <paramref name="rowIndex"/>th row in this sheet, ordered by row id in ascending order.
    /// </summary>
    /// <remarks>If you are looking to find a subrow by its id, use <see cref="GetSubrow(uint, ushort)"/> instead.</remarks>
    /// <param name="rowIndex">The zero-based index of this row</param>
    /// <param name="subrowId">The subrow id to get</param>
    /// <returns>A row object.</returns>
    /// <exception cref="NotSupportedException">Thrown if the sheet does not support subrows</exception>
    public T GetSubrowAt( int rowIndex, ushort subrowId )
    {
        if( !HasSubrows )
            throw new NotSupportedException( "Cannot access subrow in a sheet that doesn't support any." );

        var data = Subrows[rowIndex];
        return CreateSubrow( data.RowId, subrowId, in data.Data );
    }
}
