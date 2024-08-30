using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Text.ReadOnly;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using Lumina.Data.Structs.Excel;
using Lumina.Excel.Exceptions;
using System.Collections.Frozen;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

/// <summary>
/// Represents a module for working with excel sheets for a <see cref="Lumina.GameData"/> instance.
/// </summary>
public class ExcelModule
{
    internal GameData GameData { get; }

    internal Language Language => GameData.Options.DefaultExcelLanguage;

    internal bool VerifySheetChecksums => GameData.Options.PanicOnSheetChecksumMismatch;

    internal ResolveRsvDelegate? RsvResolver => GameData.Options.RsvResolver;
    
    private FrozenDictionary< string, SheetData > DefinedSheetCache { get; }
    private ConcurrentDictionary< string, SheetData > AdhocSheetCache { get; }
    private ConcurrentDictionary< Type, SheetAttribute? > SheetAttributeCache { get; } = [];
    private ConcurrentDictionary< int, RowRefIntervalTree > RowRefIntervalCache { get; } = [];

    /// <summary>
    /// A delegate provided by the user to resolve RSV strings.
    /// </summary>
    /// <param name="rsvString">The string to resolve. It is guaranteed that this string it begins with <c>_rsv_</c>.</param>
    /// <param name="resolvedString">The output resolved string.</param>
    /// <returns><see langword="true"/> if resolved and <paramref name="resolvedString"/> is written to and <see langword="false"/> otherwise.</returns>
    public delegate bool ResolveRsvDelegate( ReadOnlySeString rsvString, out ReadOnlySeString resolvedString );

    /// <summary>
    /// Get the names of all available sheets, parsed from root.exl.
    /// </summary>
    public IReadOnlyList< string > SheetNames => DefinedSheetCache.Keys;

    /// <summary>
    /// Create a new ExcelModule. This will do all the initial discovery of sheets from the EXL but not load any sheets.
    /// </summary>
    /// <param name="gameData">The <see cref="Lumina.GameData"/> instance to load sheets from</param>
    /// <exception cref="FileNotFoundException">Thrown when the root.exl file cannot be found - make sure that a 0a dat is available.</exception>
    public ExcelModule( GameData gameData )
    {
        GameData = gameData;

        var files = GameData.GetFile< ExcelListFile >( "exd/root.exl" ) ??
            throw new FileNotFoundException( "Unable to load exd/root.exl!" );

        GameData.Logger?.Information( "got {ExltEntryCount} exlt entries", files.ExdMap.Count );

        DefinedSheetCache = files.ExdMap.Keys
            .Select( name => ( Name: name, Header: GameData.GetFile< ExcelHeaderFile >( $"exd/{name}.exh") ) )
            .Where( sheet => sheet.Header is not null )
            .ToFrozenDictionary(
                sheet => sheet.Name,
                sheet => new SheetData( this, sheet.Header!, sheet.Name ),
                StringComparer.OrdinalIgnoreCase
            );
        AdhocSheetCache = new( StringComparer.OrdinalIgnoreCase );
    }

    /// <summary>Loads an <see cref="ExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <typeparamref name="T"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <typeparamref name="T"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks/>
    /// <exception cref="NotSupportedException">Sheet was not a <see cref="ExcelVariant.Default"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet(Type, Nullable{Language}, string?)"/>
    public ExcelSheet< T > GetSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelRow< T >
    {
        var attr = GetSheetAttributes( typeof( T ) ) ?? throw new SheetAttributeMissingException( null, nameof( T ) );
        name ??= attr.Name ?? throw new SheetNameEmptyException( nameof( name ) );

        var rawSheet = GetRawSheetCore( name, language, out var variant );

        if( VerifySheetChecksums && attr?.ColumnHash is { } hash && hash != rawSheet.ColumnHash )
            throw new MismatchedColumnHashException( hash, rawSheet.ColumnHash, nameof( T ) );

        if( variant != ExcelVariant.Default )
            throw new NotSupportedException( $"Specified sheet variant {variant} is not supported; was expecting {ExcelVariant.Default}." );

        return new ExcelSheet< T >( rawSheet );
    }

    /// <summary>Loads an <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <typeparamref name="T"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <typeparamref name="T"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks/>
    /// <exception cref="NotSupportedException">Sheet was not a <see cref="ExcelVariant.Subrows"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet(Type, Nullable{Language}, string?)"/>
    public SubrowExcelSheet< T > GetSubrowSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelSubrow< T >
    {
        var attr = GetSheetAttributes( typeof( T ) ) ?? throw new SheetAttributeMissingException( null, nameof( T ) );
        name ??= attr.Name ?? throw new SheetNameEmptyException( nameof( name ) );

        var rawSheet = GetRawSheetCore( name, language, out var variant );

        if( VerifySheetChecksums && attr?.ColumnHash is { } hash && hash != rawSheet.ColumnHash )
            throw new MismatchedColumnHashException( hash, rawSheet.ColumnHash, nameof( T ) );

        if ( variant != ExcelVariant.Subrows )
            throw new NotSupportedException( $"Specified sheet variant {variant} is not supported; was expecting {ExcelVariant.Subrows}." );

        return new SubrowExcelSheet< T >( (RawSubrowExcelSheet)rawSheet );
    }

    /// <summary>Loads a typed <see cref="IExcelSheet"/>.</summary>
    /// <param name="rowType">Type of the rows in the sheet.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <paramref name="rowType"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <paramref name="rowType"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>Only use this method if you need to create a sheet while using reflection.</para>
    /// <para>The returned instance of <see cref="IExcelSheet"/> should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="SheetAttributeMissingException"><paramref name="rowType"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="SheetNameEmptyException">Sheet name was not specified neither via <paramref name="rowType"/> nor <paramref name="name"/>.</exception>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet supports neither <paramref name="language"/> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="NotSupportedException">Sheet has an unsupported <see cref="ExcelVariant"/>.</exception>
    /// <exception cref="MismatchedColumnHashException">Sheet had a mismatched column hash.</exception>
    [RequiresDynamicCode( "Creating a generic sheet from a type requires reflection and dynamic code." )]
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public IExcelSheet GetBaseSheet( Type rowType, Language? language = null, string? name = null )
    {
        var attr = GetSheetAttributes( rowType ) ?? throw new SheetAttributeMissingException( null, nameof( rowType ) );
        name ??= attr.Name ?? throw new SheetNameEmptyException( nameof( name ) );

        var rawSheet = GetRawSheetCore( name, language, out var variant );

        if (VerifySheetChecksums && attr?.ColumnHash is { } hash && hash != rawSheet.ColumnHash )
            throw new MismatchedColumnHashException( hash, rawSheet.ColumnHash, nameof( rowType ) );

        ExcelVariant expectedVariant;
        Type returnType;
        if( typeof( IExcelRow<> ).MakeGenericType( rowType ).IsAssignableFrom( rowType ) )
        {
            expectedVariant = ExcelVariant.Default;
            returnType = typeof( ExcelSheet<> );
        }
        else if( typeof( IExcelSubrow<> ).MakeGenericType( rowType ).IsAssignableFrom( rowType ) )
        {
            expectedVariant = ExcelVariant.Subrows;
            returnType = typeof( SubrowExcelSheet<> );
        }
        else
            throw new NotSupportedException( $"Type \"{rowType}\" is not a valid row type." );

        if ( variant != expectedVariant )
            throw new NotSupportedException( $"Sheet \"{name}\" is not of {variant} variant." );

        return Activator.CreateInstance(
                returnType.MakeGenericType( rowType ),
                BindingFlags.Instance | BindingFlags.Public,
                null,
                [rawSheet],
                null ) as IExcelSheet ??
            throw new InvalidOperationException( "Something went wrong" );
    }

    /// <summary>Loads a <see cref="RawExcelSheet"/>.</summary>
    /// <param name="name">The requested sheet name.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>A raw excel sheet corresponding to <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// The returned instance of <see cref="RawExcelSheet"/> can be cast to <see cref="RawSubrowExcelSheet"/> if the underlying sheet is an <see cref="ExcelVariant.Subrows"/> variant.
    /// </remarks>
    /// <exception cref="ArgumentNullException"><paramref name="name"/> is null.</exception>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet supports neither <paramref name="language"/> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="NotSupportedException">Sheet has an unsupported <see cref="ExcelVariant"/>.</exception>
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public RawExcelSheet GetRawSheet( string name, Language? language = null ) =>
        GetRawSheetCore( name, language, out _ );

    private RawExcelSheet GetRawSheetCore( string name, Language? language, out ExcelVariant variant )
    {
        ArgumentNullException.ThrowIfNull( name );
        language ??= Language;

        ref readonly var definedData = ref DefinedSheetCache.GetValueRefOrNullRef( name );
        SheetData data;
        if( !Unsafe.IsNullRef( in definedData ) )
            data = definedData;
        else
        {
            data = AdhocSheetCache.GetOrAdd(
                name,
                static ( key, self ) => {
                    var headerFile = self.GameData.GetFile< ExcelHeaderFile >( $"exd/{key}.exh" ) ??
                        throw new SheetNotFoundException( null, nameof( key ) );

                    return new SheetData( self, headerFile, key );
                },
                this
            );
        }

        variant = data.Variant;

        return data.GetRawSheet( language.Value );
    }

    /// <summary>Unloads cached values that reference an assembly.</summary>
    /// <param name="assembly">Assembly to look for in the cache.</param>
    public void UnloadTypedCache( Assembly assembly )
    {
        foreach( var c in SheetAttributeCache.Keys )
        {
            if( c.Assembly == assembly )
                _ = SheetAttributeCache.TryRemove( c, out _ );
        }
    }

    internal unsafe Type? FindRowInterval( uint rowId, ReadOnlySpan<Type> types, [ConstantExpected] int typeHash )
    {
        // We do not need atomicity here. If the cache reallocates/changes (i.e. ConcurrentDictionary._tables is reallocated/rehashed),
        // TryAdd can simply fail and the GC will take care of the additional interval tree.
        if( !RowRefIntervalCache.TryGetValue( typeHash, out var ret ) )
            RowRefIntervalCache.TryAdd( typeHash, ret = new( this, types ) );
        return ret.Get( rowId );
    }

    internal RawExcelSheet GetSheetByType( Type type )
    {
        var attr = GetSheetAttributes( type ) ?? throw new SheetAttributeMissingException( null, nameof( type ) );
        var name = attr.Name ?? throw new SheetNameEmptyException( nameof( type ) );
        return GetRawSheet( name );
    }

    /// <summary>Gets the sheet attributes for <typeparamref name="T"/>.</summary>
    /// <typeparam name="T">Type of the row.</typeparam>
    /// <returns>Sheet attributes, if any.</returns>
    private SheetAttribute? GetSheetAttributes< T >() => GetSheetAttributes( typeof( T ) );

    /// <summary>Gets the sheet attributes for <paramref name="rowType"/>.</summary>
    /// <param name="rowType">Type of the row.</param>
    /// <returns>Sheet attributes, if any.</returns>
    private SheetAttribute? GetSheetAttributes( Type rowType ) =>
        SheetAttributeCache.GetOrAdd(
            rowType,
            static type => type.GetCustomAttribute< SheetAttribute >( false ) );

    private sealed class SheetData
    {
        public ExcelHeaderFile HeaderFile { get; }
        public Lazy< RawExcelSheet >?[] LanguageCache { get; }

        public ExcelVariant Variant => HeaderFile.Header.Variant;

        public SheetData( ExcelModule module, ExcelHeaderFile headerFile, string name )
        {
            HeaderFile = headerFile;
            var langs = headerFile.Languages.Prepend( Language.None );
            var maxLang = langs.Cast< ushort >().Max();
            LanguageCache = new Lazy< RawExcelSheet >?[maxLang + 1];
            foreach ( var lang in langs )
                LanguageCache[(ushort)lang] = new( () => CreateFor( module, lang, name ) );
        }

        private RawExcelSheet CreateFor( ExcelModule module, Language lang, string name ) =>
            Variant switch
            {
                ExcelVariant.Default => new RawExcelSheet( module, HeaderFile, lang, name ),
                ExcelVariant.Subrows => new RawSubrowExcelSheet( module, HeaderFile, lang, name ),
                var v => throw new NotSupportedException( $"Sheet variant {v} is not supported." ),
            };

        private Lazy< RawExcelSheet >? GetRawSheetCore( Language language )
        {
            if( LanguageCache.Length <= (ushort)language )
                return null;
            return LanguageCache[(ushort)language];
        }

        public RawExcelSheet GetRawSheet( Language language )
        {
            var entry = GetRawSheetCore( language );
            if( entry == null )
            {
                if( language == Language.None )
                    throw new UnsupportedLanguageException( nameof( language ), language, null );
                else
                {
                    entry = GetRawSheetCore( Language.None ) ??
                        throw new UnsupportedLanguageException( nameof( language ), language, null );
                }
            }

            return entry.Value;
        }
    }
}