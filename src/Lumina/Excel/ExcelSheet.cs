using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Excel;

/// <summary>A wrapper around an excel sheet.</summary>
public abstract class ExcelSheet
{
    private readonly ExcelPage[] _pages;
    private readonly RowOffsetLookup[] _rowOffsetLookupTable;
    private readonly ushort _subrowDataOffset;

    // RowLookup must use int as the key because it benefits from a fast path that removes indirections.
    // https://github.com/dotnet/runtime/blob/release/8.0/src/libraries/System.Collections.Immutable/src/System/Collections/Frozen/FrozenDictionary.cs#L140
    private readonly FrozenDictionary< int, int > _rowIndexLookupTable;

    /// <summary>The module that this sheet belongs to.</summary>
    public ExcelModule Module { get; }

    /// <summary>The language of the rows in this sheet.</summary>
    /// <remarks>This can be different from the requested language if it wasn't supported.</remarks>
    public Language Language { get; }

    /// <summary>Contains information on the columns in this sheet.</summary>
    public IReadOnlyList< ExcelColumnDefinition > Columns { get; }

    private protected ExcelSheet( ExcelModule module, ExcelHeaderFile headerFile, Language requestedLanguage, string sheetName )
    {
        var hasSubrows = headerFile.Header.Variant == ExcelVariant.Subrows;

        Module = module;
        Language = headerFile.Languages.Contains( requestedLanguage ) ? requestedLanguage : Language.None;
        Columns = headerFile.ColumnDefinitions;
        _subrowDataOffset = hasSubrows ? headerFile.Header.DataOffset : (ushort) 0;
        _pages = new ExcelPage[headerFile.DataPages.Length];
        _rowOffsetLookupTable = new RowOffsetLookup[headerFile.Header.RowCount];

        var i = 0;
        for( var pageIdx = (ushort) 0; pageIdx < headerFile.DataPages.Length; pageIdx++ )
        {
            var pageDef = headerFile.DataPages[ pageIdx ];
            var filePath = Language == Language.None
                ? $"exd/{sheetName}_{pageDef.StartId}.exd"
                : $"exd/{sheetName}_{pageDef.StartId}_{LanguageUtil.GetLanguageStr( Language )}.exd";
            var fileData = module.GameData.GetFile< ExcelDataFile >( filePath );
            if( fileData == null )
                continue;

            var newPage = _pages[ pageIdx ] = new( Module, fileData.Data, headerFile.Header.DataOffset );

            // If row count information from exh file is incorrect, cope with it.
            if( i + fileData.RowData.Count > _rowOffsetLookupTable.Length )
                Array.Resize( ref _rowOffsetLookupTable, i + fileData.RowData.Count );

            foreach( var rowPtr in fileData.RowData.Values )
            {
                var subrowCount = hasSubrows ? newPage.ReadUInt16( rowPtr.Offset + 4 ) : (ushort) 1;
                var rowOffset = rowPtr.Offset + 6;
                _rowOffsetLookupTable[ i++ ] = new( rowPtr.RowId, rowOffset, pageIdx, subrowCount );
            }
        }

        // If row count information from exh file is incorrect, cope with it. (2)
        if( i != _rowOffsetLookupTable.Length )
            Array.Resize( ref _rowOffsetLookupTable, i );

        i = 0;
        _rowIndexLookupTable = _rowOffsetLookupTable.ToFrozenDictionary( static row => (int) row.RowId, _ => i++ );
    }

    /// <summary>Creates a new instance of <see cref="ExcelSheet"/> with the <paramref name="module"/>'s default language, deducing sheet names and column
    /// hashes from <typeparamref name="T"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <exception cref="InvalidOperationException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute"/> parameters were invalid (hash mismatch or invalid sheet name).</exception>
    /// <returns>A new instance of <see cref="ExcelSheet"/> that should be cast to <see cref="DefaultExcelSheet{T}"/> or <see cref="SubrowsExcelSheet{T}"/>
    /// before further use.</returns>
    public static ExcelSheet From< T >( ExcelModule module ) where T : struct, IExcelRow< T > =>
        From< T >( module, module.Language );

    /// <summary>Creates a new instance of <see cref="ExcelSheet"/>, deducing sheet names and column hashes from <typeparamref name="T"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <exception cref="InvalidOperationException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute"/> parameters were invalid (hash mismatch or invalid sheet name).</exception>
    /// <returns>A new instance of <see cref="ExcelSheet"/> that should be cast to <see cref="DefaultExcelSheet{T}"/> or <see cref="SubrowsExcelSheet{T}"/>
    /// before further use.</returns>
    public static ExcelSheet From< T >( ExcelModule module, Language language ) where T : struct, IExcelRow< T >
    {
        var attribute = typeof( T ).GetCustomAttribute< SheetAttribute >() ??
            throw new InvalidOperationException( $"{nameof( T )} has no {nameof( SheetAttribute )}. Use the overload of {nameof( From )} with 4 parameters." );

        return From< T >( module, language, attribute.Name, attribute.ColumnHash );
    }

    /// <summary>Creates a new instance of <see cref="ExcelSheet"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <param name="sheetName">The name of the sheet to read from.</param>
    /// <param name="columnHash">The hash of the columns in the sheet. If <see langword="null"/>, it will not check the hash.</param>
    /// <exception cref="ArgumentException"><paramref name="sheetName"/> or <paramref name="columnHash"/> parameters were invalid (hash mismatch or invalid sheet name).</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <exception cref="InvalidOperationException">Sheet is of <see cref="ExcelVariant.Subrows"/> variant, but <typeparamref name="T"/> does not implement it.
    /// </exception>
    /// <returns>A new instance of <see cref="ExcelSheet"/> that should be cast to <see cref="DefaultExcelSheet{T}"/> or <see cref="SubrowsExcelSheet{T}"/>
    /// before further use.</returns>
    public static ExcelSheet From< T >( ExcelModule module, Language language, string sheetName, uint? columnHash = null )
        where T : struct, IExcelRow< T >
    {
        var headerFile = module.GameData.GetFile< ExcelHeaderFile >( $"exd/{sheetName}.exh" ) ??
            throw new ArgumentException( "Invalid sheet name", nameof( sheetName ) );

        if( module.VerifySheetChecksums && columnHash is { } hash && headerFile.GetColumnsHash() != hash )
            throw new ArgumentException( "Column hash mismatch", nameof( columnHash ) );

        if( !headerFile.Languages.Contains( language ) )
            throw new ExcelLanguageNotSupportedException();

        switch( headerFile.Header.Variant )
        {
            case ExcelVariant.Default:
                return new DefaultExcelSheet< T >( module, headerFile, language, sheetName );
            case ExcelVariant.Subrows:
                return new SubrowsExcelSheet< T >( module, headerFile, language, sheetName );
            case ExcelVariant.Unknown:
            default:
                throw new NotSupportedException( $"Specified sheet variant {headerFile.Header.Variant} is not supported." );
        }
    }

    /// <summary>The number of rows in this sheet.</summary>
    /// <remarks>
    /// If this sheet has gaps in row ids, it returns the number of rows that exist, not the highest row id.
    /// If this sheet has subrows, this will still return the number of rows and not the total number of subrows.
    /// </remarks>
    public int Count {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get => _rowOffsetLookupTable.Length;
    }

    /// <summary>Gets the offset lookup table.</summary>
    private protected ReadOnlySpan< RowOffsetLookup > OffsetLookupTable {
        [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
        get => _rowOffsetLookupTable;
    }

    /// <summary>Gets the offset of the column at <paramref name="columnIdx"/> in the row data.</summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <returns>The offset of the column.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown when the column index is invalid. It must be less than <see cref="Columns"/>.Count.</exception>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public ushort GetColumnOffset( int columnIdx ) =>
        Columns[ columnIdx ].Offset;

    /// <summary>Whether this sheet has a row with the given <paramref name="rowId"/>.</summary>
    /// <remarks>If this sheet has subrows, this will check if the row id has any subrows.</remarks>
    /// <param name="rowId">The row id to check.</param>
    /// <returns>Whether the row exists.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public bool HasRow( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return !Unsafe.IsNullRef( in lookup ) && lookup.SubrowCount > 0;
    }

    /// <summary>Gets a row lookup at the given index, if possible.</summary>
    /// <param name="rowId">Index of the desired row.</param>
    /// <returns>Lookup data for the desired row, or a null reference if no corresponding row exists.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal ref readonly RowOffsetLookup GetRowLookupOrNullRef( uint rowId )
    {
        ref readonly var rowIndexRef = ref _rowIndexLookupTable.GetValueRefOrNullRef( (int) rowId );
        if( Unsafe.IsNullRef( in rowIndexRef ) )
            return ref Unsafe.NullRef<RowOffsetLookup>();
        return ref UnsafeGetRowLookupAt( rowIndexRef );
    }

    /// <summary>Gets a row lookup at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <returns>Lookup data for the desired row.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal ref readonly RowOffsetLookup UnsafeGetRowLookupAt( int rowIndex ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetArrayDataReference( _rowOffsetLookupTable ), rowIndex );

    /// <summary>Creates a row at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal T UnsafeCreateRowAt< T >( int rowIndex ) where T : struct, IExcelRow< T > =>
        UnsafeCreateRow< T >( in UnsafeGetRowLookupAt( rowIndex ) );

    /// <summary>Creates a subrow at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <param name="subrowId">Index of the desired subrow.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal T UnsafeCreateSubrowAt< T >( int rowIndex, ushort subrowId ) where T : struct, IExcelRow< T > =>
        UnsafeCreateSubrow< T >( in UnsafeGetRowLookupAt( rowIndex ), subrowId );

    /// <summary>Creates a row using the given lookup data, without checking for bounds or preconditions.</summary>
    /// <param name="lookup">Lookup data for the desired row.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal T UnsafeCreateRow< T >( scoped in RowOffsetLookup lookup ) where T : struct, IExcelRow< T > =>
        T.Create(
            Unsafe.Add( ref MemoryMarshal.GetArrayDataReference( _pages ), lookup.PageIndex ),
            lookup.Offset,
            lookup.RowId );

    /// <summary>Creates a subrow using the given lookup data, without checking for bounds or preconditions.</summary>
    /// <param name="lookup">Lookup data for the desired row.</param>
    /// <param name="subrowId">Index of the desired subrow.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    internal T UnsafeCreateSubrow< T >( scoped in RowOffsetLookup lookup, ushort subrowId ) where T : struct, IExcelRow< T > =>
        T.Create(
            Unsafe.Add( ref MemoryMarshal.GetArrayDataReference( _pages ), lookup.PageIndex ),
            lookup.Offset + 2 + subrowId * ( _subrowDataOffset + 2u ),
            lookup.RowId,
            subrowId );

    /// <summary>Lookup data for locating backing data for a row.</summary>
    /// <param name="RowId">ID of the row. This is separate from the row indices.</param>
    /// <param name="Offset">Byte offset of the row, relative to the beginning of an exd file.</param>
    /// <param name="PageIndex">Index of the page that contains the data for this row.</param>
    /// <param name="SubrowCount">Number of subrows in the row, or <c>1</c> if the sheet does not support subrows.</param>
    internal readonly record struct RowOffsetLookup( uint RowId, uint Offset, ushort PageIndex, ushort SubrowCount );
}