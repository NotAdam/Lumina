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

    private ConcurrentDictionary< (Type Type, Language Language), ExcelSheet > SheetCache { get; } = [];

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

    /// <summary>Loads an <see cref="DefaultExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An instance of <see cref="ExcelSheet"/> corresponding to <typeparamref name="T"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="ExcelLanguageNotSupportedException"/>.
    /// </remarks>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    /// <exception cref="ExcelLanguageNotSupportedException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="InvalidCastException">Sheet is not of the variant <see cref="ExcelVariant.Default"/>.</exception>
    public DefaultExcelSheet< T > GetDefaultSheet< T >( Language? language = null ) where T : struct, IExcelRow< T > =>
        (DefaultExcelSheet< T >) GetSheet< T >( language );

    /// <summary>Loads an <see cref="DefaultExcelSheet{T}"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An instance of <see cref="ExcelSheet"/> corresponding to <typeparamref name="T"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="ExcelLanguageNotSupportedException"/>.
    /// </remarks>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    /// <exception cref="ExcelLanguageNotSupportedException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="InvalidCastException">Sheet is not of the variant <see cref="ExcelVariant.Subrows"/>.</exception>
    public SubrowsExcelSheet< T > GetSubrowsSheet< T >( Language? language = null ) where T : struct, IExcelRow< T > =>
        (SubrowsExcelSheet< T >) GetSheet< T >( language );

    /// <summary>Loads an <see cref="ExcelSheet"/>.</summary>
    /// <param name="rowType">Type of the rows in the sheet.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An instance of <see cref="ExcelSheet"/> corresponding to <paramref name="rowType"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>Only use this method if you need to create a sheet while using reflection.</para>
    /// <para>If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="ExcelLanguageNotSupportedException"/>.</para>
    /// <para>The returned instance of <see cref="ExcelSheet"/> should be cast to <see cref="DefaultExcelSheet{T}"/> or <see cref="GetDefaultSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    /// <exception cref="ExcelLanguageNotSupportedException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    [RequiresDynamicCode( "Creating a generic sheet from a type requires reflection and dynamic code." )]
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public ExcelSheet GetSheet( Type rowType, Language? language = null )
    {
        if( !rowType.IsValueType )
            throw new ArgumentException( $"{nameof( rowType )} must be a struct.", nameof( rowType ) );

        if( !rowType.IsAssignableTo( typeof( IExcelRow<> ).MakeGenericType( rowType ) ) )
            throw new ArgumentException( $"{nameof( rowType )} must implement {typeof( IExcelRow<> ).Name}.", nameof( rowType ) );

        var sheet = SheetCache.GetOrAdd(
            ( rowType, language ?? Language ),
            static ( key, module ) => {
                var m = typeof( ExcelSheet )
                    .GetMethod( nameof( ExcelSheet.From ), BindingFlags.Static | BindingFlags.Public )!
                    .MakeGenericMethod( key.Type );
                try
                {
                    return m.Invoke( null, [module, key.Language] ) as ExcelSheet ?? throw new InvalidOperationException( "Something went wrong" );
                }
                catch( ExcelLanguageNotSupportedException )
                {
                    return LanguageNotSupportedPlaceholder.Instance;
                }
            },
            this );

        if( sheet != LanguageNotSupportedPlaceholder.Instance )
            return sheet;
        if( language == Language.None )
            throw new ExcelLanguageNotSupportedException( nameof( language ), language, null );
        return GetSheet( rowType, Language.None );
    }

    /// <summary>Loads an <see cref="ExcelSheet"/>.</summary>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An instance of <see cref="ExcelSheet"/> corresponding to <typeparamref name="T"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="ExcelLanguageNotSupportedException"/>.</para>
    /// <para>The returned instance of <see cref="ExcelSheet"/> should be cast to <see cref="DefaultExcelSheet{T}"/> or <see cref="GetDefaultSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    /// <exception cref="ExcelLanguageNotSupportedException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public ExcelSheet GetSheet< T >( Language? language = null ) where T : struct, IExcelRow< T >
    {
        var sheet = SheetCache.GetOrAdd(
            ( typeof( T ), language ?? Language ),
            static ( key, module ) => {
                try
                {
                    return ExcelSheet.From< T >( module, key.Language );
                }
                catch( ExcelLanguageNotSupportedException )
                {
                    return LanguageNotSupportedPlaceholder.Instance;
                }
            },
            this );

        if( sheet != LanguageNotSupportedPlaceholder.Instance )
            return sheet;
        if( language == Language.None )
            throw new ExcelLanguageNotSupportedException( nameof( language ), language, null );
        return GetSheet< T >( Language.None );
    }

    private sealed class LanguageNotSupportedPlaceholder : ExcelSheet
    {
        public static readonly ExcelSheet Instance = (ExcelSheet) RuntimeHelpers.GetUninitializedObject( typeof( LanguageNotSupportedPlaceholder ) );

        internal LanguageNotSupportedPlaceholder( ExcelModule module, ExcelHeaderFile headerFile, Language requestedLanguage, string sheetName )
            : base( module, headerFile, requestedLanguage, sheetName )
        { }
    }
}