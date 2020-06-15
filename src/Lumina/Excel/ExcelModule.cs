using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Excel.Exceptions;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly Lumina _lumina;

        /// <summary>
        /// Mapping between internal IDs used to index sheets loaded at startup to their name.
        /// </summary>
        /// <remarks>
        /// Not actually used for anything in lumina, but kept for reference
        /// </remarks>
        public readonly Dictionary< int, string > ImmutableIdToSheetMap;
        
        /// <summary>
        /// A list of all available sheets, pulled from root.exl
        /// </summary>
        public readonly List< string > SheetNames;

        private readonly Dictionary< Tuple< Language, string >, ExcelSheetImpl > _sheetCache;

        private readonly object _sheetCreateLock = new object();

        public ExcelModule( Lumina lumina )
        {
            _lumina = lumina;
            ImmutableIdToSheetMap = new Dictionary< int, string >();
            SheetNames = new List< string >();

            _sheetCache = new Dictionary< Tuple< Language, string >, ExcelSheetImpl >();

            // load all sheet names first
            var files = _lumina.GetFile< ExcelListFile >( "exd/root.exl" );

            Debug.WriteLine( $"got {files.ExdMap.Count} exlt entries" );

            foreach( var map in files.ExdMap )
            {
                SheetNames.Add( map.Key.ToLowerInvariant() );

                if( map.Value == -1 )
                {
                    continue;
                }

                ImmutableIdToSheetMap[ map.Value ] = map.Key;
            }
        }

        /// <summary>
        /// Generates a path to the header file, given a sheet name.
        /// </summary>
        /// <remarks>
        /// Sheet names must be in the same format as they're in root.exl. You can see all available sheets by iterating <see cref="SheetNames"/>.
        /// </remarks>
        /// <param name="name">A sheet name</param>
        /// <returns>An absolute path to an excel header file</returns>
        public string BuildExcelHeaderPath( string name )
        {
            return $"exd/{name}.exh";
        }

        /// <summary>
        /// Attempts to load the base excel sheet given it's implementing row parser
        /// </summary>
        /// <typeparam name="T">A class that implements <see cref="IExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T > GetSheet< T >() where T : IExcelRow
        {
            return GetSheet< T >( _lumina.Options.DefaultExcelLanguage );
        }

        /// <summary>
        /// Attempts to load the base excel sheet with a specific language
        /// </summary>
        /// <remarks>
        /// If the language requested doesn't exist for the file, this will silently be ignored and it will return a sheet with the default language: <see cref="Language.None"/>
        /// </remarks>
        /// <param name="language">The requested sheet language</param>
        /// <typeparam name="T">A class that implements <see cref="IExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T > GetSheet< T >( Language language ) where T : IExcelRow
        {
            var attr = typeof( T ).GetCustomAttribute< SheetAttribute >();

            if( attr == null )
            {
                return null;
            }

            lock( _sheetCreateLock )
            {
                return GetSheet< T >( attr.Name, language, attr.ColumnHash );
            }
        }

        /// <summary>
        /// Get a sheet by it's name with a given type.
        ///
        /// Useful for when a schema is shared (e.g. in the case of quest text sheets) as redefining loads of classes is wasteful.
        /// </summary>
        /// <param name="name">The name of a sheet</param>
        /// <typeparam name="T">A class that implements <see cref="IExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T > GetSheet< T >( string name ) where T : IExcelRow
        {
            lock( _sheetCreateLock )
            {
                return GetSheet< T >( name, _lumina.Options.DefaultExcelLanguage, null );
            }
        }

        private ExcelSheet< T > GetSheet< T >( string name, Language language, uint? expectedHash ) where T : IExcelRow
        {
            name = name.ToLowerInvariant();

            var idNoLanguage = Tuple.Create( Language.None, name );
            var id = Tuple.Create( language, name );

            // attempt to get non-localised sheet first, then attempt to fetch a localised sheet from the cache
            if( _sheetCache.TryGetValue( idNoLanguage, out var sheet ) )
            {
                return sheet as ExcelSheet< T >;
            }

            if( _sheetCache.TryGetValue( id, out sheet ) )
            {
                if( sheet is ExcelSheet< T > checkedSheet )
                {
                    return checkedSheet;
                }
            }

            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _lumina.GetFile< ExcelHeaderFile >( path );

            if( headerFile == null )
            {
                return null;
            }

            // validate checksum if enabled and we have a hash that we expect to find
            if( _lumina.Options.PanicOnSheetChecksumMismatch && expectedHash.HasValue )
            {
                var actualHash = headerFile.GetColumnsHash();
                if( actualHash != expectedHash )
                {
                    throw new ExcelSheetColumnChecksumMismatchException( name, expectedHash.Value, actualHash );
                }
            }

            var newSheet = (ExcelSheet< T >)Activator.CreateInstance( typeof( ExcelSheet< T > ), headerFile, name, language, _lumina );
            newSheet.GenerateFilePages();

            // kinda a shit hack but basically this enforces a single language for a sheet that has no localisation
            // because it's possible to then load a single sheet many times if someone isn't careful
            // so we rewrite the language field on the id so we can hit the cache in the event that this happens
            // nb: probably unlikely but I don't want to deal with it later
            var langs = newSheet.Languages;
            if( langs.Length == 1 && langs[ 0 ] == Language.None )
            {
                id = idNoLanguage;
            }

            _sheetCache[ id ] = newSheet;

            return newSheet;
        }

        /// <summary>
        /// Returns a raw accessor to an excel sheet allowing you to skip templated row access entirely.
        /// </summary>
        /// <param name="name">Name of the sheet to load</param>
        /// <param name="language">The requested language to load</param>
        /// <returns>A ExcelSheetImpl object, or null if the sheet name was not found.</returns>
        public ExcelSheetImpl GetSheetRaw( string name, Language language = Language.None )
        {
            // todo: duped code is a bit ass but zzz
            // todo: expose useful functions to ExcelSheetImpl like getrow(s) and so on
            if( !SheetNames.Contains( name.ToLowerInvariant() ) )
            {
                return null;
            }

            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _lumina.GetFile< ExcelHeaderFile >( path );

            var newSheet = (ExcelSheetImpl)Activator.CreateInstance( typeof( ExcelSheetImpl ), headerFile, name, language, _lumina );
            newSheet.GenerateFilePages();

            return newSheet;
        }
    }
}