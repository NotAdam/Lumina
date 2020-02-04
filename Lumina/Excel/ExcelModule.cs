using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Lumina.Data.Files.Excel;

namespace Lumina.Excel
{
    public class ExcelModule
    {
        private readonly Lumina _lumina;

        private Dictionary< string, ExcelHeaderFile > _headers;

#if !DEBUG
        private object _headerLock = new object();
#endif

        public ExcelModule( Lumina lumina )
        {
            _lumina = lumina;
            _headers = new Dictionary< string, ExcelHeaderFile >();
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
                var path = BuildExcelHeaderPath( map.Key );
            
                var headerFile = _lumina.GetFile< ExcelHeaderFile >( path );
#if !DEBUG
                lock( _headerLock )
#endif
                {
                    _headers.Add( path, headerFile );
                }
            }
#if !DEBUG
            );
#endif

            // foreach( var map in files.ExdMap )
            // {
            //     var path = BuildExcelHeaderPath( map.Key );
            //
            //     var headerFile = _lumina.GetFile< ExcelHeaderFile >( path );
            //     
            //     _headers.Add( path, headerFile );
            // }
            
            Debug.WriteLine($"processed {_headers.Count} excel headers");

            return true;
        }
    }
}