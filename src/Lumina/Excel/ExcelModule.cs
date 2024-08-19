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
using System.Runtime.CompilerServices;
using Lumina.Data.Structs.Excel;
using Lumina.Excel.Exceptions;

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

    private ConcurrentDictionary< (Type Type, Language Language, string Name), BaseExcelSheet > SheetCache { get; } = [];
    private ConcurrentDictionary< Type, SheetAttribute? > SheetAttributeCache { get; } = [];

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
    public IReadOnlyCollection< string > SheetNames { get; }

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

        SheetNames = [.. files.ExdMap.Keys];
    }

    /// <summary>Loads an <see cref="ExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <typeparamref name="T"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <typeparamref name="T"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks/>
    /// <exception cref="NotSupportedException">Sheet was not a <see cref="ExcelVariant.Default"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet(Type, Nullable{Language}, string?)"/>
    public ExcelSheet< T > GetSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelRow< T > =>
        (ExcelSheet< T >) GetBaseSheet( typeof( T ), language, name );

    /// <summary>Loads an <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <typeparamref name="T"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <typeparamref name="T"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks/>
    /// <exception cref="NotSupportedException">Sheet was not a <see cref="ExcelVariant.Subrows"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet(Type, Nullable{Language}, string?)"/>
    public SubrowExcelSheet< T > GetSubrowSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelSubrow< T > =>
        (SubrowExcelSheet< T >) GetBaseSheet( typeof( T ), language, name );

    /// <summary>Loads an <see cref="BaseExcelSheet"/>.</summary>
    /// <param name="rowType">Type of the rows in the sheet.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <paramref name="rowType"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
    /// <returns>An excel sheet corresponding to <paramref name="rowType"/>, <paramref name="language"/>, and <paramref name="name"/>
    /// that may be created anew or reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>Only use this method if you need to create a sheet while using reflection.</para>
    /// <para>The returned instance of <see cref="BaseExcelSheet"/> should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="SheetNameEmptyException">Sheet name was not specified neither via <paramref name="rowType"/> nor <paramref name="name"/>.</exception>
    /// <exception cref="SheetAttributeMissingException"><paramref name="rowType"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="SheetNotFoundException">Sheet does not exist.</exception>
    /// <exception cref="MismatchedColumnHashException">Sheet had a mismatched column hash.</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="NotSupportedException">Sheet had an unsupported <see cref="ExcelVariant"/>.</exception>
    [RequiresDynamicCode( "Creating a generic sheet from a type requires reflection and dynamic code." )]
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public BaseExcelSheet GetBaseSheet( Type rowType, Language? language = null, string? name = null )
    {
        var attr = GetSheetAttributes( rowType ) ?? throw new SheetAttributeMissingException( null, nameof( rowType ) );
        name ??= attr.Name ?? throw new SheetNameEmptyException( null, nameof( name ) );
        var sheet = SheetCache.GetOrAdd(
            ( rowType, language ?? Language, name ),
            static ( key, context ) => {
                Type t;
                try
                {
                    t = typeof( ExcelSheet<> ).MakeGenericType( key.Type );
                }
                catch( ArgumentException e1 )
                {
                    try
                    {
                        t = typeof( SubrowExcelSheet<> ).MakeGenericType( key.Type );
                    }
                    catch( ArgumentException e2 )
                    {
                        // Exception thrown here will propagate outside ConcurrentDictionary<>.GetOrAdd without touching the data stored inside dictionary.
                        throw new ArgumentException(
                            $"{key.Type.Name} must implement either {typeof( IExcelRow<> ).Name.Split( '`', 2 )[ 0 ]}<{key.Type.Name}> or {typeof( IExcelSubrow<> ).Name.Split( '`', 2 )[ 0 ]}<{key.Type.Name}>.",
                            nameof( rowType ),
                            new AggregateException( e1, e2 ) );
                    }
                }

                try
                {
                    return Activator.CreateInstance(
                            t,
                            BindingFlags.Instance | BindingFlags.Public,
                            null,
                            [context.Module, key.Language, key.Name, context.Attribute.ColumnHash],
                            null ) as BaseExcelSheet ??
                        throw new InvalidOperationException( "Something went wrong" );
                }
                catch( TargetInvocationException e )
                {
                    return InvalidSheet.Create( e.InnerException ?? e );
                }
                catch( Exception e )
                {
                    return InvalidSheet.Create( e );
                }
            },
            ( Module: this, Attribute: attr ) );

        if( sheet is not InvalidSheet { Exception: var e } )
            return sheet;
        if( e is UnsupportedLanguageException )
        {
            if( language == Language.None )
                throw new UnsupportedLanguageException( nameof( language ), language, null );
            return GetBaseSheet( rowType, Language.None );
        }

        throw e;
    }

    /// <summary>Unloads cached sheets that reference an assembly.</summary>
    /// <param name="assembly">Assembly to look for in the cached sheets.</param>
    public void UnloadCachedSheetsOfAssembly( Assembly assembly )
    {
        foreach( var c in SheetCache.Keys )
        {
            if( c.Type.Assembly == assembly )
                _ = SheetCache.TryRemove( c, out _ );
        }

        foreach( var c in SheetAttributeCache.Keys )
        {
            if( c.Assembly == assembly )
                _ = SheetAttributeCache.TryRemove( c, out _ );
        }
    }

    /// <summary>Gets the sheet attributes for <typeparamref name="T"/>.</summary>
    /// <typeparam name="T">Type of the row.</typeparam>
    /// <returns>Sheet attributes, if any.</returns>
    internal SheetAttribute? GetSheetAttributes< T >() => GetSheetAttributes( typeof( T ) );

    /// <summary>Gets the sheet attributes for <paramref name="rowType"/>.</summary>
    /// <param name="rowType">Type of the row.</param>
    /// <returns>Sheet attributes, if any.</returns>
    internal SheetAttribute? GetSheetAttributes( Type rowType ) =>
        SheetAttributeCache.GetOrAdd(
            rowType,
            static type => type.GetCustomAttribute< SheetAttribute >( false ) );

    private sealed class InvalidSheet : BaseExcelSheet
    {
        public Exception Exception { get; private set; }

        // never actually called
        private InvalidSheet() : base( default!, default, default!, default, default ) =>
            Exception = null!;

        public static InvalidSheet Create( Exception exception )
        {
            var ret = (InvalidSheet) RuntimeHelpers.GetUninitializedObject( typeof( InvalidSheet ) );
            ret.Exception = exception;
            return ret;
        }
    }
}