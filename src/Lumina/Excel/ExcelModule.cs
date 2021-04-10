using System;
using System.Collections.Generic;
using System.Reflection;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Excel.Exceptions;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly GameData _gameData;

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

        private readonly Dictionary< Tuple< Language, ulong >, ExcelSheetImpl > _sheetCache;

        private readonly object _sheetCreateLock = new object();

        public ExcelModule( GameData gameData )
        {
            _gameData = gameData;
            ImmutableIdToSheetMap = new Dictionary< int, string >();
            SheetNames = new List< string >();

            _sheetCache = new Dictionary< Tuple< Language, ulong >, ExcelSheetImpl >();

            // load all sheet names first
            var files = _gameData.GetFile< ExcelListFile >( "exd/root.exl" );

            _gameData.Logger?.Information("got {ExltEntryCount} exlt entries", files.ExdMap.Count);

            foreach( var map in files.ExdMap )
            {
                SheetNames.Add( map.Key );

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
        public static string BuildExcelHeaderPath( string name )
        {
            return $"exd/{name}.exh";
        }

        /// <summary>
        /// Attempts to load the base excel sheet given it's implementing row parser
        /// </summary>
        /// <typeparam name="T">A class that implements <see cref="ExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T >? GetSheet< T >() where T : ExcelRow
        {
            return GetSheet< T >( _gameData.Options.DefaultExcelLanguage );
        }

        /// <summary>
        /// Attempts to load the base excel sheet with a specific language
        /// </summary>
        /// <remarks>
        /// If the language requested doesn't exist for the file, this will silently be ignored and it will return a sheet with the default language: <see cref="Language.None"/>
        /// </remarks>
        /// <param name="language">The requested sheet language</param>
        /// <typeparam name="T">A class that implements <see cref="ExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T >? GetSheet< T >( Language language ) where T : ExcelRow
        {
            var attr = typeof( T ).GetCustomAttribute< SheetAttribute >();

            if( attr == null )
            {
                return null;
            }

            return GetSheet< T >( attr.Name, language, attr.ColumnHash );
        }

        /// <summary>
        /// Get a sheet by it's name with a given type.
        ///
        /// Useful for when a schema is shared (e.g. in the case of quest text sheets) as redefining loads of classes is wasteful.
        /// </summary>
        /// <param name="name">The name of a sheet</param>
        /// <typeparam name="T">A class that implements <see cref="ExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T >? GetSheet< T >( string name ) where T : ExcelRow
        {
            return GetSheet< T >( name, _gameData.Options.DefaultExcelLanguage, null );
        }

        private ulong BuildTypeIdentifier( Type type )
        {
            return (ulong)type.Assembly.GetHashCode() << 32 | (uint)type.MetadataToken;
        }

        /// <summary>
        /// Remove a sheet from the cache completely and free any related resources
        /// </summary>
        /// <typeparam name="T">The sheet type</typeparam>
        public void RemoveSheetFromCache< T >() where T : ExcelRow
        {
            var tid = BuildTypeIdentifier( typeof( T ) );
            
            foreach( Language language in Enum.GetValues( typeof( Language ) ) )
            {
                var id = Tuple.Create( language, tid );

                _sheetCache.Remove( id );
            }
        }

        private ExcelSheet< T >? GetSheet< T >( string name, Language language, uint? expectedHash ) where T : ExcelRow
        {
            var tid = BuildTypeIdentifier( typeof( T ) );
            var idNoLanguage = Tuple.Create( Language.None, tid );
            var id = Tuple.Create( language, tid );

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
            lock( _sheetCreateLock )
            {
                return CreateNewSheet< T >( name, language, expectedHash, id, idNoLanguage );
            }
        }

        private ExcelSheet< T >? CreateNewSheet< T >(
            string name,
            Language language,
            uint? expectedHash,
            Tuple< Language, ulong > key,
            Tuple< Language, ulong > noLangKey
        ) where T : ExcelRow
        {
            _gameData.Logger?.Debug(
                "sheet {SheetName} not in cache - creating new sheet for language {Language}",
                name,
                language
            );
            
            var path = BuildExcelHeaderPath( name );
            var headerFile = _gameData.GetFile< ExcelHeaderFile >( path );

            if( headerFile == null )
            {
                return null;
            }

            // validate checksum if enabled and we have a hash that we expect to find
            if( expectedHash.HasValue )
            {
                var actualHash = headerFile.GetColumnsHash();
                if( actualHash != expectedHash )
                {
                    _gameData.Logger?.Warning(
                        "The sheet impl {SheetImplName} hash doesn't match the hash generated from the header. Expected: {ExpectedHash} actual: {ActualHash}",
                        typeof( T ).FullName,
                        expectedHash,
                        actualHash
                    );
                    
                    if( _gameData.Options.PanicOnSheetChecksumMismatch )
                    {
                        throw new ExcelSheetColumnChecksumMismatchException( name, expectedHash.Value, actualHash );
                    }
                }
            }

            var newSheet = (ExcelSheet< T >?)Activator.CreateInstance( typeof( ExcelSheet< T > ), headerFile, name, language, _gameData );
            newSheet!.GenerateFilePages();

            var id = key;

            // kinda a shit hack but basically this enforces a single language for a sheet that has no localisation
            // because it's possible to then load a single sheet many times if someone isn't careful
            // so we rewrite the language field on the id so we can hit the cache in the event that this happens
            // nb: probably unlikely but I don't want to deal with it later
            var langs = newSheet.Languages;
            if( langs.Length == 1 && langs[ 0 ] == Language.None )
            {
                id = noLangKey;
            }

            _sheetCache[ id ] = newSheet;

            return newSheet;
        }

        /// <summary>
        /// Returns a raw accessor to an excel sheet allowing you to skip templated row access entirely.
        /// </summary>
        /// <param name="name">Name of the sheet to load</param>
        /// <returns>A ExcelSheetImpl object, or null if the sheet name was not found.</returns>
        public ExcelSheetImpl? GetSheetRaw( string name )
        {
            return GetSheetRaw( name, _gameData.Options.DefaultExcelLanguage );
        }

        /// <summary>
        /// Returns a raw accessor to an excel sheet allowing you to skip templated row access entirely.
        /// </summary>
        /// <param name="name">Name of the sheet to load</param>
        /// <param name="language">The requested language to load</param>
        /// <returns>A ExcelSheetImpl object, or null if the sheet name was not found.</returns>
        public ExcelSheetImpl? GetSheetRaw( string name, Language language )
        {
            // todo: duped code is a bit ass but zzz
            // todo: expose useful functions to ExcelSheetImpl like getrow(s) and so on

            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _gameData.GetFile< ExcelHeaderFile >( path );

            if( headerFile == null )
            {
                return null;
            }

            var newSheet = new ExcelSheetImpl( headerFile, name, language, _gameData );
            newSheet.GenerateFilePages();

            return newSheet;
        }

        /// <summary>
        /// Checks whether a given <see cref="ExcelRow"/> decorated with a <see cref="SheetAttribute"/> has a column hash that matches a newly created hash
        /// of the column data from the <see cref="ExcelHeaderFile"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="ExcelRow"/> to check</typeparam>
        /// <returns>true if the hash matches</returns>
        /// <remarks>This function will return false if the <see cref="SheetAttribute"/> is missing or a column hash isn't specified in the attribute</remarks>
        public bool SheetHashMatchesColumnDefinition< T >() where T : ExcelRow
        {
            var type = typeof( T );
            var attr = type.GetCustomAttribute< SheetAttribute >();

            if( attr == null )
            {
                return false;
            }

            var path = BuildExcelHeaderPath( attr.Name );
            var headerFile = _gameData.GetFile< ExcelHeaderFile >( path );

            if( headerFile == null )
            {
                return false;
            }

            return attr.ColumnHash == headerFile.GetColumnsHash();
        }
    }
}