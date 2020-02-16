using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly Lumina _Lumina;

        public readonly Dictionary< int, string > ImmutableIdToSheetMap;
        public readonly List< string > SheetNames;

        public readonly List< ExcelSheetImpl > Sheets;

        public readonly Dictionary< Tuple< Language, string >, ExcelSheetImpl > SheetCache;

        public ExcelModule( Lumina lumina )
        {
            _Lumina = lumina;
            ImmutableIdToSheetMap = new Dictionary< int, string >();
            SheetNames = new List< string >();
            
            Sheets = new List< ExcelSheetImpl >();
            SheetCache = new Dictionary< Tuple< Language, string >, ExcelSheetImpl >();
            
            // load all sheet names first
            var files = _Lumina.GetFile< ExcelListFile >( "exd/root.exl" );

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

        public string BuildExcelHeaderPath( string path )
        {
            return $"exd/{path}.exh";
        }

        public ExcelSheet< T > GetSheet< T >() where T : IExcelRow
        {
            return GetSheet< T >( _Lumina.Options.DefaultExcelLanguage );
        }
        
        public ExcelSheet< T > GetSheet< T >( Language language ) where T : IExcelRow
        {
            var attr = typeof( T ).GetCustomAttribute< SheetNameAttribute >();

            if( attr == null )
            {
                return null;
            }

            return GetSheet< T >( attr.Name, language );
        }

        public ExcelSheet< T > GetSheet< T >( string name ) where T : IExcelRow
        {
            return GetSheet< T >( name, _Lumina.Options.DefaultExcelLanguage );
        }

        public ExcelSheet< T > GetSheet< T >( string name, Language language ) where T : IExcelRow
        {
            name = name.ToLowerInvariant();
            
            var idNoLanguage = Tuple.Create( Language.None, name );
            var id = Tuple.Create( language, name );
            
            // attempt to get non-localised sheet first, then attempt to fetch a localised sheet from the cache
            if( SheetCache.TryGetValue( idNoLanguage, out var sheet ) )
            {
                return sheet as ExcelSheet< T >;
            }
            if( SheetCache.TryGetValue( id, out sheet ) )
            {
                return sheet as ExcelSheet< T >;
            }

            if( !SheetNames.Contains( name ) )
            {
                return null;
            }
            
            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _Lumina.GetFile< ExcelHeaderFile >( path );

            var newSheet = (ExcelSheet< T >)Activator.CreateInstance( typeof( ExcelSheet< T > ), headerFile, name, language, _Lumina );
            newSheet.GenerateFileSegments();

            // kinda a shit hack but basically this enforces a single language for a sheet that has no localisation
            // because it's possible to then load a single sheet many times if someone isn't careful
            // so we rewrite the language field on the id so we can hit the cache in the event that this happens
            // nb: probably unlikely but I don't want to deal with it later
            var langs = newSheet.Languages;
            if( langs.Length == 1 && langs[ 0 ] == Language.None )
            {
                id = idNoLanguage;
            }

            Sheets.Add( newSheet );
            SheetCache[ id ] = newSheet;

            return newSheet;
        }

        /// <summary>
        /// Returns a raw accessor to an excel sheet allowing you to skip templated row access entirely.
        /// </summary>
        /// <param name="name">Name of the sheet to load</param>
        /// <returns>A ExcelSheetImpl object, or null if the sheet name was not found.</returns>
        internal ExcelSheetImpl GetSheetRaw( string name )
        {
            // todo: duped code is a bit ass but zzz
            // todo: expose useful functions to ExcelSheetImpl like getrow(s) and so on
            if( !SheetNames.Contains( name.ToLowerInvariant() ) )
            {
                return null;
            }
            
            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _Lumina.GetFile< ExcelHeaderFile >( path );

            var newSheet = (ExcelSheetImpl)Activator.CreateInstance( typeof( ExcelSheetImpl ), headerFile, name, _Lumina );
            newSheet.GenerateFileSegments();

            return newSheet;
        }
    }
}