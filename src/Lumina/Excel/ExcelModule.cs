using Lumina.Data;
using Lumina.Data.Files.Excel;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Lumina.Excel;

/// <summary>
/// Represents a module for working with excel sheets for a <see cref="Lumina.GameData"/> instance.
/// </summary>
public class ExcelModule
{
    internal GameData GameData { get; }

    internal Language Language => GameData.Options.DefaultExcelLanguage;

    private ConcurrentDictionary<(Type sheetType, Language requestedLanguage), IExcelSheet> SheetCache { get; } = [];

    /// <summary>
    /// Get the names of all available sheets, parsed from root.exl.
    /// </summary>
    public IReadOnlyCollection<string> SheetNames { get; }

    /// <summary>
    /// Create a new ExcelModule. This will do all the initial discovery of sheets from the EXL but not load any sheets.
    /// </summary>
    /// <param name="gameData">The <see cref="Lumina.GameData"/> instance to load sheets from</param>
    /// <exception cref="FileNotFoundException">Thrown when the root.exl file cannot be found - make sure that a 0a dat is available.</exception>
    public ExcelModule( GameData gameData )
    {
        GameData = gameData;

        var files = GameData.GetFile<ExcelListFile>( "exd/root.exl" ) ??
            throw new FileNotFoundException( "Unable to load exd/root.exl!" );

        GameData.Logger?.Information( "got {ExltEntryCount} exlt entries", files.ExdMap.Count );

        SheetNames = [.. files.ExdMap.Keys];
    }

    /// <summary>
    /// Loads an <see cref="ExcelSheet{T}"/>, optionally with a specific language.
    /// </summary>
    /// <remarks>
    /// If the requested language doesn't exist for the file, this will silently be ignored and it will return a sheet with the default language: <see cref="Language.None"/>.
    /// </remarks>
    /// <typeparam name="T">A struct that implements <see cref="IExcelRow{T}"/> to parse rows.</typeparam>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists</returns>
    /// <exception cref="InvalidOperationException">Thrown when <typeparamref name="T"/> is not decorated with a <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    public ExcelSheet<T> GetSheet<T>( Language? language = null ) where T : struct, IExcelRow<T>
    {
        language ??= Language;

        return (ExcelSheet<T>)SheetCache.GetOrAdd( (typeof( T ), language.Value), _ => new ExcelSheet<T>( this, language.Value ) );
    }

    /// <summary>
    /// Loads an <see cref="ExcelSheet{T}"/> from a reflected <see cref="Type"/>, optionally with a specific language.
    /// </summary>
    /// <remarks>
    /// Only use this method if you need to create a sheet while using reflection.
    /// 
    /// If the requested language doesn't exist for the file, this will silently be ignored and it will return a sheet with the default language: <see cref="Language.None"/>.
    /// </remarks>
    /// <param name="rowType">A <see cref="Type"/> that implements <see cref="IExcelRow{T}"/> to parse rows.</param>
    /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
    /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists.</returns>
    /// <exception cref="InvalidOperationException">Thrown when <paramref name="rowType"/> is not decorated with a <see cref="SheetAttribute"/>.</exception>
    /// <exception cref="ArgumentException">Sheet does not exist or if the column hash has a mismatch.</exception>
    [RequiresDynamicCode( "Creating a generic sheet from a type requires reflection and dynamic code." )]
    [EditorBrowsable( EditorBrowsableState.Advanced )]
    public IExcelSheet GetSheetGeneric( Type rowType, Language? language = null )
    {
        if( !rowType.IsValueType )
            throw new ArgumentException( "rowType must be a struct", nameof( rowType ) );

        if( !rowType.IsAssignableTo( typeof( IExcelRow<> ).MakeGenericType( rowType ) ) )
        {
            throw new ArgumentException( "rowType implement IExcelRow<T>", nameof( rowType ) );
        }

        language ??= Language;

        return SheetCache.GetOrAdd( (rowType, language.Value), _ => (IExcelSheet)Activator.CreateInstance( typeof( ExcelSheet<> ).MakeGenericType( rowType ), this, language.Value )! );
    }
}