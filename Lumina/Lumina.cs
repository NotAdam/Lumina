using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data;
using Lumina.Data.Structs;
using Lumina.Excel;
using Lumina.Misc;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina
{
    public class Lumina
    {
        public DirectoryInfo DataPath { get; private set; }

        public Dictionary< string, Repository > Repositories { get; private set; }

        public LuminaOptions Options { get; private set; }

        /// <summary>
        /// Reading PS3 dats on a LE machine means we need to convert endianness from BE where applicable
        /// </summary>
        public bool ShouldConvertEndianness => Options.CurrentPlatform == PlatformId.PS3 && BitConverter.IsLittleEndian;
        
        /// <summary>
        /// Provides access to EXD/EXH data, internally called Excel.
        ///
        /// Loaded by default on init unless you opt not to load it. Can be loaded at a later time by calling Lumina.InitExcelModule or optionally
        /// constructing your own Excel.ExcelModule.
        /// </summary>
        public ExcelModule Excel { get; private set; }

        /// <summary>
        /// Constructs a new Lumina object allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        public Lumina( string dataPath, LuminaOptions options = null )
        {
            Options = options ?? new LuminaOptions();

            DataPath = new DirectoryInfo( dataPath );

            if( !DataPath.Exists )
            {
                throw new DirectoryNotFoundException( "DataPath provided is missing." );
            }
            
            if( DataPath.Name != "sqpack" )
            {
                throw new ArgumentException( "the data path arg must point to the sqpack directory", nameof( dataPath ) );
            }

            Repositories = new Dictionary< string, Repository >();
            foreach( var repo in DataPath.GetDirectories() )
            {
                Repositories[ repo.Name.ToLowerInvariant() ] = new Repository( repo, this );
            }

            Excel = new ExcelModule( this );
        }

        public static ParsedFilePath ParseFilePath( string path )
        {
            // validate path slightly
            if( path[ ^1 ] == '/' )
                return null;

            path = path.ToLowerInvariant().Trim();
            
            var pathParts = path.Split( '/' );
            var category = pathParts.First();

            var hash = GetFileHash( path );
            var hash2 = Crc32.Get( path );

            var repo = pathParts[ 1 ];
            // todo: supports up to ex9, so we've got another ~11 years before this breaks
            if( repo[ 0 ] != 'e' || repo[ 1 ] != 'x' || !char.IsDigit( repo[ 2 ] ) )
            {
                repo = "ffxiv";
            }

            return new ParsedFilePath
            {
                Category = category,
                IndexHash = hash,
                Index2Hash = hash2,
                Repository = repo
            };
        }

        public FileResource GetFile( string path )
        {
            return GetFile< FileResource >( path );
        }

        public T GetFile< T >( string path ) where T : FileResource
        {
            var parsed = ParseFilePath( path );
            if( parsed == null )
            {
                return null;
            }
            
            if( Repositories.TryGetValue( parsed.Repository, out var repo ) )
            {
                return repo.GetFile< T >( parsed.Category, parsed );
            }

            return null;
        }

        /// <summary>
        /// Check if a file exists anywhere by checking whether the hash exists in any index
        /// </summary>
        /// <param name="path">The full path of the file</param>
        /// <returns>True if the file exists</returns>
        public bool FileExists( string path )
        {
            var parsedPath = ParseFilePath( path );
            if( parsedPath == null )
                return false;

            if( Repositories.TryGetValue( parsedPath.Repository, out var repo ) )
            {
                return repo.FileExists( parsedPath.Category, parsedPath );
            }

            return false;
        }

        /// <summary>
        /// Returns the index variant of a file hash
        /// </summary>
        /// <param name="path">The full path of the file</param>
        /// <returns>A U64 containing a split hash of the folder and file CRC32s</returns>
        public static UInt64 GetFileHash( string path )
        {
            var pathParts = path.Split( '/' );
            var filename = pathParts[ ^1 ];
            var folder = path.Substring( 0, path.LastIndexOf( '/' ) );

            return (UInt64) Crc32.Get( folder ) << 32 | Crc32.Get( filename );
        }

        public ExcelSheet< T > GetExcelSheet< T >() where T : IExcelRow
        {
            return Excel.GetSheet< T >();
        }
    }
}