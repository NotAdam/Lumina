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

    private ConcurrentDictionary< (Type Type, Language Language), BaseExcelSheet > SheetCache { get; } = [];

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
    /// <exception cref="InvalidCastException">Sheet is not of the variant <see cref="ExcelVariant.Default"/>.</exception>
    /// <inheritdoc cref="GetSubrowSheet{T}(Nullable{Lumina.Data.Language})"/>
    public ExcelSheet< T > GetSheet< T >( Language? language = null ) where T : struct, IExcelRow< T > =>
        (ExcelSheet< T >) GetBaseSheet< T >( language );

    /// <summary>Loads an <see cref="SubrowExcelSheet{T}"/>.</summary>
    /// <remarks>
    /// <para>If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="UnsupportedLanguageException"/>.</para>
    /// </remarks>
    /// <exception cref="InvalidCastException">Sheet is not of the variant <see cref="ExcelVariant.Subrows"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet{T}(Nullable{Lumina.Data.Language})"/>
    public SubrowExcelSheet< T > GetSubrowSheet< T >( Language? language = null ) where T : struct, IExcelRow< T > =>
        (SubrowExcelSheet< T >) GetBaseSheet< T >( language );

    /// <returns>An excel sheet corresponding to <typeparamref name="T"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="UnsupportedLanguageException"/>.</para>
    /// <para>The returned instance of <see cref="BaseExcelSheet"/> should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="InvalidOperationException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <inheritdoc cref="GetBaseSheet(Type, Nullable{Lumina.Data.Language})"/>
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public BaseExcelSheet GetBaseSheet< T >( Language? language = null ) where T : struct, IExcelRow< T > =>
        GetBaseSheet( typeof( T ), language );

    /// <summary>Loads an <see cref="BaseExcelSheet"/>.</summary>
    /// <param name="rowType">Type of the rows in the sheet.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An excel sheet corresponding to <paramref name="rowType"/> and <paramref name="language"/> that may be created anew or
    /// reused from a previous invocation of this method.</returns>
    /// <remarks>
    /// <para>Only use this method if you need to create a sheet while using reflection.</para>
    /// <para>If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the language-neutral
    /// sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function will fail with
    /// <see cref="UnsupportedLanguageException"/>.</para>
    /// <para>The returned instance of <see cref="BaseExcelSheet"/> should be cast to <see cref="ExcelSheet{T}"/> or <see cref="SubrowExcelSheet{T}"/>
    /// before accessing its rows.</para>
    /// </remarks>
    /// <exception cref="InvalidOperationException"><paramref name="rowType"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException">Sheet does not exist.</exception>
    /// <exception cref="MismatchedColumnHashException">Sheet had a mismatched column hash.</exception>
    /// <exception cref="UnsupportedLanguageException">Sheet does not support <paramref name="language" /> nor <see cref="Language.None"/>.</exception>
    /// <exception cref="NotSupportedException">Sheet had an unsupported <see cref="ExcelVariant"/>.</exception>
    [RequiresDynamicCode( "Creating a generic sheet from a type requires reflection and dynamic code." )]
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public BaseExcelSheet GetBaseSheet( Type rowType, Language? language = null )
    {
        var sheet = SheetCache.GetOrAdd(
            ( rowType, language ?? Language ),
            static ( key, module ) => {
                MethodInfo m;
                try
                {
                    // As BaseExcelSheet.From<T> has a constraint that T : IExcelRow<T>, it is implicitly required that T is also a struct.
                    // MakeGenericMethod will check for constraints, and throw ArgumentException if constraints aren't met.
                    m = typeof( BaseExcelSheet )
                        .GetMethod(
                            nameof( BaseExcelSheet.From ),
                            BindingFlags.Static | BindingFlags.Public,
                            [typeof( ExcelModule ), typeof( Language )] )!
                        .MakeGenericMethod( key.Type );
                }
                catch( ArgumentException e )
                {
                    // Exception thrown here will propagate outside ConcurrentDictionary<>.GetOrAdd without touching the data stored inside dictionary.
                    throw new ArgumentException(
                        $"{key.Type.Name} must implement {typeof( IExcelRow<> ).Name.Split( '`', 2 )[ 0 ]}<{key.Type.Name}>.",
                        nameof( rowType ),
                        e );
                }

                try
                {
                    return m.Invoke( null, [module, key.Language] ) as BaseExcelSheet ?? throw new InvalidOperationException( "Something went wrong" );
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
            this );

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

    private sealed class InvalidSheet : BaseExcelSheet
    {
        public Exception Exception { get; private set; }

        // never actually called
        private InvalidSheet( ExcelModule module, ExcelHeaderFile headerFile, Language requestedLanguage, string sheetName ) : base( module, headerFile,
            requestedLanguage, sheetName )
        {
            Exception = null!;
        }

        public static InvalidSheet Create( Exception exception )
        {
            var ret = (InvalidSheet) RuntimeHelpers.GetUninitializedObject( typeof( InvalidSheet ) );
            ret.Exception = exception;
            return ret;
        }
    }
}