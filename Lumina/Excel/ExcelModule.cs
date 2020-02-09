using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Lumina.Data.Files.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly Lumina _Lumina;

        private readonly Dictionary< int, string > _ImmutableIdToSheetMap;
        private readonly List< string > _SheetNames;

        public readonly List< ExcelSheetImpl > Sheets;

        public readonly Dictionary< string, ExcelSheetImpl > SheetMap;

        public ExcelModule( Lumina lumina )
        {
            _Lumina = lumina;
            _ImmutableIdToSheetMap = new Dictionary< int, string >();
            _SheetNames = new List< string >();
            
            Sheets = new List< ExcelSheetImpl >();
            SheetMap = new Dictionary< string, ExcelSheetImpl >();
            
            // load all sheet names first
            var files = _Lumina.GetFile< ExcelListFile >( "exd/root.exl" );

            Debug.WriteLine( $"got {files.ExdMap.Count} exlt entries" );

            foreach( var map in files.ExdMap )
            {
                _SheetNames.Add( map.Key.ToLowerInvariant() );

                if( map.Value == -1 )
                {
                    continue;
                }

                _ImmutableIdToSheetMap[ map.Value ] = map.Key;
            }
        }

        public string BuildExcelHeaderPath( string path )
        {
            return $"exd/{path}.exh";
        }

        public ExcelSheet< T > GetSheet< T >() where T : IExcelRow
        {
            var attr = typeof( T ).GetCustomAttribute< SheetNameAttribute >();

            if( attr == null )
            {
                return null;
            }

            return GetSheet< T >( attr.Name );
        }

        public ExcelSheet< T > GetSheet< T >( string name ) where T : IExcelRow
        {
            if( SheetMap.TryGetValue( name, out var sheet ) )
            {
                return sheet as ExcelSheet< T >;
            }
            
            if( !_SheetNames.Contains( name.ToLowerInvariant() ) )
            {
                return null;
            }
            
            // create new sheet
            var path = BuildExcelHeaderPath( name );
            var headerFile = _Lumina.GetFile< ExcelHeaderFile >( path );

            var newSheet = (ExcelSheet< T >)Activator.CreateInstance( typeof( ExcelSheet< T > ), headerFile, name, _Lumina );

            Sheets.Add( newSheet );
            SheetMap[ name ] = newSheet;

            return newSheet;
        }
    }
}