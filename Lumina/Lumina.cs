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

        public static LuminaOptions Options { get; private set; }

        /// <summary>
        /// Reading PS3 dats on a LE machine means we need to convert endianness from BE where applicable
        /// </summary>
        public static bool ShouldConvertEndianness => Options.CurrentPlatform == PlatformId.PS3 && BitConverter.IsLittleEndian;
        
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
            Contract.Requires( dataPath != null );
            Contract.Ensures( Options != null );
            Contract.Ensures( Repositories != null );

            Options = options ?? new LuminaOptions();

            DataPath = new DirectoryInfo( dataPath );

            if( !DataPath.Exists )
            {
                throw new DirectoryNotFoundException( "DataPath provided is missing." );
            }

            Repositories = new Dictionary< string, Repository >();
            foreach( var repo in DataPath.GetDirectories() )
            {
                Repositories[ repo.Name.ToLowerInvariant() ] = new Repository( repo );
            }

            if( Options.LoadExcelModuleOnInit )
            {
                InitExcelModule();
            }
        }

        public static ParsedFilePath ParseFilePath( string path )
        {
            var pathParts = path.Split( '/' );
            var category = pathParts.First();

            var hash = GetFileHash( path );

            var repoName = pathParts[ 1 ].StartsWith( "ex" ) ? pathParts[ 1 ] : "ffxiv";

            return new ParsedFilePath
            {
                Category = category,
                Hash = hash,
                Repository = repoName
            };
        }

        public FileResource GetFile( string path )
        {
            return GetFile< FileResource >( path );
        }

        public T GetFile< T >( string path ) where T : FileResource
        {
            var parsed = ParseFilePath( path );
            var repo = Repositories[ parsed.Repository ];

            return repo.GetFile< T >( parsed.Category, parsed.Hash );
        }

        public bool FileExists( string path )
        {
            var parsed = ParseFilePath( path );
            var repo = Repositories[ parsed.Repository ];
            
            return repo.FileExists( parsed.Category, parsed.Hash );
        }

        public static UInt64 GetFileHash( string path )
        {
            var pathParts = path.Split( '/' );
            var filename = pathParts.Last();
            var folder = path.Substring( 0, path.LastIndexOf( '/' ) );

            return (UInt64) Crc32.Get( folder ) << 32 | Crc32.Get( filename );
        }

        public bool InitExcelModule()
        {
            Excel = new ExcelModule( this );
            
            return Excel.Init();
        }
    }
}