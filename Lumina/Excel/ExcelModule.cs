using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Lumina.Data.Files.Excel;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly Lumina _lumina;

        private readonly Dictionary< string, ExcelHeaderFile > _headers;

        private readonly Dictionary< int, ExcelSheet > _immutableIdToSheetMap;

        public readonly List< ExcelSheet > Sheets;

        public readonly Dictionary< string, ExcelSheet > SheetMap;

#if !DEBUG
        private object _headerLock = new object();
#endif

        public ExcelModule( Lumina lumina )
        {
            _lumina = lumina;
            _headers = new Dictionary< string, ExcelHeaderFile >();
            _immutableIdToSheetMap = new Dictionary< int, ExcelSheet >();
            
            Sheets = new List< ExcelSheet >();
            SheetMap = new Dictionary< string, ExcelSheet >();
        }

        public string BuildExcelHeaderPath( string path )
        {
            return $"exd/{path}.exh";
        }

        public bool Init()
        {
            // load all filepaths first
            var files = _lumina.GetFile< ExcelListFile >( "exd/root.exl" );
            
            Debug.WriteLine( $"got {files.ExdMap.Count} exlt entries" );
         
            // we go fast as fuck in release
#if DEBUG
            foreach( var map in files.ExdMap )
#else 
            // load each exh
            Parallel.ForEach( files.ExdMap, ( map ) =>
#endif
            {
                // don't preload misc excel entries, unlikely to hit them under normal conditions
                if( map.Value == -1 && !Lumina.Options.PreCacheAllExcelHeaders )
                {
                    continue;
                }
                
                PreloadExcelHeader( map.Key, map.Value );
            }
#if !DEBUG
            );
#endif

            Debug.WriteLine($"processed {_headers.Count} excel headers");

            return true;
        }

        protected void PreloadExcelHeader( string name, int immutableId = -1 )
        {
            var path = BuildExcelHeaderPath( name );
            var headerFile = _lumina.GetFile< ExcelHeaderFile >( path );

            var sheet = new ExcelSheet( headerFile, immutableId, name, _lumina );

            if( immutableId != -1 )
            {
                _immutableIdToSheetMap[ immutableId ] = sheet;
            }
            
            Sheets.Add( sheet );
            SheetMap[ name ] = sheet;

#if !DEBUG
                lock( _headerLock )
#endif
            {
                _headers.Add( path, headerFile );
            }
        }

        public T GetRow< T >( string name, uint row ) where T : IExcelRow
        {
            var sheet = GetSheet( name );

            return sheet.GetRow< T >( row );
        }

        public ExcelSheet GetSheet( string name )
        {
            // todo: attempt to load sheet if not found
            return SheetMap[ name ];
        }
    }
}