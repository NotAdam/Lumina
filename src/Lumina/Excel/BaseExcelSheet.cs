using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <summary>A wrapper around an excel sheet.</summary>
public abstract class BaseExcelSheet
{
    /// <summary>Number of items in <see cref="_rowIndexLookupArray"/> that may resolve to no entry.</summary>
    // 7.05h: across 7292 sheets that exist and are referenced from exlt file, following ratio can be represented solely using lookup array of certain sizes.
    //  Max Gap, Coverage, Net Wasted
    //     1024,   99.15%,       38KB
    //     2048,   99.25%,       82KB
    //     3072,   99.29%,      109KB
    //     4096,   99.36%,      183KB
    //     5120,   99.40%,      239KB
    //     6144,   99.41%,      259KB
    //     9216,   99.42%,      295KB
    //    10240,   99.47%,      410KB
    //    14336,   99.48%,      463KB
    //    16384,   99.49%,      525KB
    //    19456,   99.51%,      599KB
    //    24576,   99.52%,      692KB
    //    26624,   99.53%,      793KB
    //    28672,   99.56%,     1011KB
    //    29696,   99.57%,     1127KB
    //    30720,   99.59%,     1244KB
    //    33792,   99.63%,     1633KB
    //    34816,   99.64%,     1765KB
    //    41984,   99.67%,     2089KB
    //    43008,   99.68%,     2255KB
    //    44032,   99.71%,     2594KB
    //    50176,   99.73%,     2789KB
    //    64512,   99.74%,     3041KB
    //    65536,   99.75%,     3293KB
    //    70656,   99.84%,     4941KB
    //    71680,   99.88%,     5773KB
    //    89088,   99.89%,     6118KB
    //   720896,   99.90%,     8934KB
    //   721920,   99.92%,    11754KB
    //  1049600,   99.93%,    15853KB
    //  1507328,   99.95%,    21741KB
    //  2001920,   99.96%,    29559KB
    //  2990080,   99.97%,    41236KB
    //  9832448,   99.99%,    79643KB
    // 10146816,  100.00%,   119276KB
    // We're allowing up to 65536 lookup items in _rowOffsetLookupTable, at cost of up to 3293KB of lookup items that resolve to nonexistence per language.
    private const int MaxUnusedLookupItemCount = 65536;

    private readonly ExcelPage[] _pages;
    private readonly RowOffsetLookup[] _rowOffsetLookupTable;
    private readonly ushort _subrowDataOffset;

    // RowLookup must use int as the key because it benefits from a fast path that removes indirections.
    // https://github.com/dotnet/runtime/blob/release/8.0/src/libraries/System.Collections.Immutable/src/System/Collections/Frozen/FrozenDictionary.cs#L140
    private readonly FrozenDictionary< int, int > _rowIndexLookupDict;

    private readonly int[] _rowIndexLookupArray;

    /// <summary>The module that this sheet belongs to.</summary>
    public ExcelModule Module { get; }

    /// <summary>The language of the rows in this sheet.</summary>
    /// <remarks>This can be different from the requested language if it wasn't supported.</remarks>
    public Language Language { get; }

    /// <summary>Contains information on the columns in this sheet.</summary>
    public IReadOnlyList< ExcelColumnDefinition > Columns { get; }

    private protected BaseExcelSheet( ExcelModule module, ExcelHeaderFile headerFile, Language requestedLanguage, string sheetName )
    {
        var hasSubrows = headerFile.Header.Variant == ExcelVariant.Subrows;

        Module = module;
        Language = headerFile.Languages.Contains( requestedLanguage ) ? requestedLanguage : Language.None;
        Columns = headerFile.ColumnDefinitions;
        _subrowDataOffset = hasSubrows ? headerFile.Header.DataOffset : (ushort) 0;
        _pages = new ExcelPage[headerFile.DataPages.Length];
        _rowOffsetLookupTable = new RowOffsetLookup[headerFile.Header.RowCount];

        var i = 0;
        for( ushort pageIdx = 0; pageIdx < headerFile.DataPages.Length; pageIdx++ )
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

        // A lot of sheets do not have large gap between row IDs. If total number of gaps is less than a threshold, then make a lookup array.
        if( _rowOffsetLookupTable.Length > 0 )
        {
            var firstId = _rowOffsetLookupTable[ 0 ].RowId;
            var numSlots = _rowOffsetLookupTable[ ^1 ].RowId - firstId + 1;
            var numUnused = numSlots - headerFile.Header.RowCount;
            if( numUnused <= MaxUnusedLookupItemCount )
            {
                _rowIndexLookupArray = new int[ numSlots ];
                _rowIndexLookupArray.AsSpan().Fill( -1 );
                for (i = 0; i < _rowOffsetLookupTable.Length; i++)
                    _rowIndexLookupArray[_rowOffsetLookupTable[ i ].RowId - firstId] = i;

                // All items can be looked up from _rowIndexLookupArray. Dictionary is unnecessary.
                _rowIndexLookupDict = FrozenDictionary< int, int >.Empty;
            }
            else
            {
                _rowIndexLookupArray = new int[MaxUnusedLookupItemCount];
                _rowIndexLookupArray.AsSpan().Fill( -1 );

                var lastLookupArrayRowId = uint.MaxValue;
                for( i = 0; i < _rowOffsetLookupTable.Length; i++ )
                {
                    var offsetRowId = _rowOffsetLookupTable[ i ].RowId - firstId;
                    if( offsetRowId >= MaxUnusedLookupItemCount )
                    {
                        // Discard the unused entries.
                        Array.Resize( ref _rowIndexLookupArray, unchecked( (int) ( lastLookupArrayRowId + 1 ) ) );
                        break;
                    }

                    _rowIndexLookupArray[ offsetRowId ] = i;
                    lastLookupArrayRowId = offsetRowId;
                }

                // Skip the items that can be looked up from _rowIndexLookupArray.
                _rowIndexLookupDict = _rowOffsetLookupTable.Skip( i ).ToFrozenDictionary( static row => (int) row.RowId, _ => i++ );
            }

            Count = _rowOffsetLookupTable.Length;
        }
        else
        {
            _rowIndexLookupDict = FrozenDictionary< int, int >.Empty;
            _rowIndexLookupArray = [];
            _rowOffsetLookupTable = [default]; // so that _rowOffsetLookupTable.UnsafeAt(0) is always valid.
            Count = 0;
        }
    }

    /// <summary>Creates a new instance of <see cref="BaseExcelSheet"/> with the <paramref name="module"/>'s default language, deducing sheet names and column
    /// hashes from <typeparamref name="T"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <exception cref="InvalidOperationException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute.Name"/> was invalid (invalid sheet name).</exception>
    /// <exception cref="MismatchedColumnHashException"><see cref="SheetAttribute.ColumnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="BaseExcelSheet"/> that should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before further use.</returns>
    public static BaseExcelSheet From< T >( ExcelModule module ) where T : struct, IExcelRow< T > =>
        From< T >( module, module.Language );

    /// <summary>Creates a new instance of <see cref="BaseExcelSheet"/>, deducing sheet names and column hashes from <typeparamref name="T"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <exception cref="InvalidOperationException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException"><see cref="SheetAttribute.Name"/> was invalid (invalid sheet name).</exception>
    /// <exception cref="MismatchedColumnHashException"><see cref="SheetAttribute.ColumnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="BaseExcelSheet"/> that should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before further use.</returns>
    public static BaseExcelSheet From< T >( ExcelModule module, Language language ) where T : struct, IExcelRow< T >
    {
        var attribute = typeof( T ).GetCustomAttribute< SheetAttribute >() ??
            throw new InvalidOperationException( $"{nameof( T )} has no {nameof( SheetAttribute )}. Use the overload of {nameof( From )} with 4 parameters." );

        return From< T >( module, language, attribute.Name, attribute.ColumnHash );
    }

    /// <summary>Creates a new instance of <see cref="BaseExcelSheet"/>.</summary>
    /// <param name="module">The <see cref="ExcelModule"/> to access sheet data from.</param>
    /// <param name="language">The language to use for this sheet.</param>
    /// <param name="sheetName">The name of the sheet to read from.</param>
    /// <param name="columnHash">The hash of the columns in the sheet. If <see langword="null"/>, it will not check the hash.</param>
    /// <exception cref="ArgumentException"><paramref name="sheetName"/> was invalid (invalid sheet name).</exception>
    /// <exception cref="MismatchedColumnHashException"><paramref name="columnHash"/> was invalid (hash mismatch).</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet had an unsupported language.</exception>
    /// <exception cref="NotSupportedException">Header file had a <see cref="ExcelVariant"/> value that is not supported.</exception>
    /// <returns>A new instance of <see cref="BaseExcelSheet"/> that should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before further use.</returns>
    public static BaseExcelSheet From< T >( ExcelModule module, Language language, string sheetName, uint? columnHash = null )
        where T : struct, IExcelRow< T >
    {
        var headerFile = module.GameData.GetFile< ExcelHeaderFile >( $"exd/{sheetName}.exh" ) ??
            throw new ArgumentException( "Invalid sheet name", nameof( sheetName ) );

        if( module.VerifySheetChecksums && columnHash is { } hash && headerFile.GetColumnsHash() != hash )
            throw new MismatchedColumnHashException(hash, headerFile.GetColumnsHash(), nameof(columnHash) );

        if( !headerFile.Languages.Contains( language ) )
            throw new UnsupportedLanguageException();

        return headerFile.Header.Variant switch
        {
            ExcelVariant.Default => new ExcelSheet<T>( module, headerFile, language, sheetName ),
            ExcelVariant.Subrows => new SubrowExcelSheet<T>( module, headerFile, language, sheetName ),
            _ => throw new NotSupportedException( $"Specified sheet variant {headerFile.Header.Variant} is not supported." ),
        };
    }

    /// <summary>The number of rows in this sheet.</summary>
    /// <remarks>
    /// If this sheet has gaps in row ids, it returns the number of rows that exist, not the highest row id.
    /// If this sheet has subrows, this will still return the number of rows and not the total number of subrows.
    /// </remarks>
    public int Count { get; }

    /// <summary>Gets the offset lookup table.</summary>
    private protected ReadOnlySpan< RowOffsetLookup > OffsetLookupTable => _rowOffsetLookupTable;

    /// <summary>Gets the offset of the column at <paramref name="columnIdx"/> in the row data.</summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <returns>The offset of the column.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown when the column index is invalid. It must be less than <see cref="Columns"/>.Count.</exception>
    public ushort GetColumnOffset( int columnIdx ) => Columns[ columnIdx ].Offset;

    /// <summary>Whether this sheet has a row with the given <paramref name="rowId"/>.</summary>
    /// <remarks>If this sheet has subrows, this will check if the row id has any subrows.</remarks>
    /// <param name="rowId">The row id to check.</param>
    /// <returns>Whether the row exists.</returns>
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
        var lookupArrayIndex = unchecked( rowId - _rowOffsetLookupTable.UnsafeAt(0).RowId );
        if( lookupArrayIndex < _rowIndexLookupArray.Length )
        {
            var rowIndex = _rowIndexLookupArray.UnsafeAt( (int) lookupArrayIndex );
            if (rowIndex == -1)
                return ref Unsafe.NullRef<RowOffsetLookup>();
            return ref UnsafeGetRowLookupAt( rowIndex );
        }

        ref readonly var rowIndexRef = ref _rowIndexLookupDict.GetValueRefOrNullRef( (int) rowId );
        if( Unsafe.IsNullRef( in rowIndexRef ) )
            return ref Unsafe.NullRef<RowOffsetLookup>();
        return ref UnsafeGetRowLookupAt( rowIndexRef );
    }

    /// <summary>Gets a row lookup at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <returns>Lookup data for the desired row.</returns>
    internal ref readonly RowOffsetLookup UnsafeGetRowLookupAt( int rowIndex ) =>
        ref _rowOffsetLookupTable.UnsafeAt(rowIndex);

    /// <summary>Creates a row at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    internal T UnsafeCreateRowAt< T >( int rowIndex ) where T : struct, IExcelRow< T > =>
        UnsafeCreateRow< T >( in UnsafeGetRowLookupAt( rowIndex ) );

    /// <summary>Creates a subrow at the given index, without checking for bounds or preconditions.</summary>
    /// <param name="rowIndex">Index of the desired row.</param>
    /// <param name="subrowId">Index of the desired subrow.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    internal T UnsafeCreateSubrowAt< T >( int rowIndex, ushort subrowId ) where T : struct, IExcelRow< T > =>
        UnsafeCreateSubrow< T >( in UnsafeGetRowLookupAt( rowIndex ), subrowId );

    /// <summary>Creates a row using the given lookup data, without checking for bounds or preconditions.</summary>
    /// <param name="lookup">Lookup data for the desired row.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    internal T UnsafeCreateRow< T >( scoped ref readonly RowOffsetLookup lookup ) where T : struct, IExcelRow< T > =>
        T.Create(
            _pages.UnsafeAt(lookup.PageIndex),
            lookup.Offset,
            lookup.RowId );

    /// <summary>Creates a subrow using the given lookup data, without checking for bounds or preconditions.</summary>
    /// <param name="lookup">Lookup data for the desired row.</param>
    /// <param name="subrowId">Index of the desired subrow.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    internal T UnsafeCreateSubrow< T >( scoped ref readonly RowOffsetLookup lookup, ushort subrowId ) where T : struct, IExcelRow< T > =>
        T.Create(
            _pages.UnsafeAt(lookup.PageIndex),
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