using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Lumina.Data;
using Lumina.Data.Structs;
using Lumina.Excel;
using Lumina.Misc;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina
{
    public class GameData
    {
        /// <summary>
        /// The current data path that Lumina is using to load files.
        /// </summary>
        public DirectoryInfo DataPath { get; private set; }

        /// <summary>
        /// Provides access to each <see cref="Repository"/>, which contains the base game content or expansion content. Each folder inside the sqpack
        /// directory is a repository.
        /// </summary>
        public Dictionary< string, Repository > Repositories { get; private set; }

        /// <summary>
        /// Provides access to <see cref="LuminaOptions"/> at runtime. Most of these can be changed without issue without having to create a new instance.
        /// </summary>
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
        /// Provides access to the <see cref="FileHandleManager"/> which allows you to create new <see cref="FileHandle{T}"/>s which then allows you to
        /// easily defer file loading onto another thread.
        /// </summary>
        public FileHandleManager FileHandleManager { get; private set; }
        
        internal ILogger? Logger { get; private set; }
        
        /// <summary>
        /// Provides access to the current <see cref="GameData"/> object that was invoked on this thread (if any).
        /// </summary>
        public static ThreadLocal< GameData >? CurrentContext { get; private set; }

        /// <summary>
        /// Constructs a new Lumina object allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        public GameData( string dataPath, LuminaOptions? options = null! )
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
            FileHandleManager = new FileHandleManager( this );
        }

        /// <summary>
        /// Constructs a new Lumina object allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="logger">An <see cref="ILogger"/> implementation that Lumina can send log events to</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        public GameData( string dataPath, ILogger logger, LuminaOptions? options = null! ) : this(dataPath, options)
        {
            Logger = logger ?? throw new ArgumentNullException( nameof( logger ) );
        }

        /// <summary>
        /// Parses a game filesystem path and extracts information and hashes the path provided. 
        /// </summary>
        /// <param name="path">A game filesystem path</param>
        /// <returns>A <see cref="ParsedFilePath"/> which contains extracted info from the path, along with the hashes used to access the file index</returns>
        public static ParsedFilePath? ParseFilePath( string path )
        {
            if( string.IsNullOrWhiteSpace( path ) )
                return null;
            
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
                Repository = repo,
                Path = path
            };
        }

        /// <summary>
        /// Load a raw file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <returns>The base <see cref="FileResource"/> if it was found, or null if it wasn't found</returns>
        public FileResource? GetFile( string path )
        {
            return GetFile< FileResource >( path );
        }

        /// <summary>
        /// Load a defined file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load the raw file in to</typeparam>
        /// <returns>Returns the requested file if found, null if not</returns>
        public T? GetFile< T >( string path ) where T : FileResource
        {
            SetCurrentContext();
            
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
        /// Load a defined file given a filesystem path
        /// </summary>
        /// <param name="path">A relative or absolute path to the file to load</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load the raw file in to</typeparam>
        /// <returns>The requested file if found, null if not</returns>
        /// <exception cref="FileNotFoundException">The path given doesn't point to an existing file</exception>
        public T GetFileFromDisk< T >( string path ) where T : FileResource
        {
            SetCurrentContext();
            
            if( !File.Exists( path ) )
            {
                throw new FileNotFoundException( "the file at the specified path doesn't exist" );
            }

            var fileContent = File.ReadAllBytes( path );

            var file = Activator.CreateInstance< T >();
            file.Data = fileContent;
            // todo: this is kind of fucked, we should probably choose one or the other and not both
            file.FileStream = new MemoryStream( file.Data, false );
            file.Reader = new BinaryReader( file.FileStream );
            file.LoadFile();

            return file;
        }

        /// <summary>
        /// Returns file metadata pulled directly from the file header inside the SqPack
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <returns>A <see cref="SqPackFileInfo"/> if it was found, null if not</returns>
        public SqPackFileInfo? GetFileMetadata( string path )
        {
            var parsed = ParseFilePath( path );
            if( parsed == null )
            {
                return null;
            }
            
            if( Repositories.TryGetValue( parsed.Repository, out var repo ) )
            {
                return repo.GetFileMetadata( parsed.Category, parsed );
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

        /// <summary>
        /// Attempts to load the base excel sheet given it's implementing row parser
        /// </summary>
        /// <typeparam name="T">A class that implements <see cref="ExcelRow"/> to parse rows</typeparam>
        /// <returns>An <see cref="ExcelSheet{T}"/> if the sheet exists, null if it does not</returns>
        public ExcelSheet< T >? GetExcelSheet< T >() where T : ExcelRow
        {
            return Excel.GetSheet< T >();
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
        public ExcelSheet< T >? GetExcelSheet< T >( Language language ) where T : ExcelRow
        {
            return Excel.GetSheet< T >( language );
        }

        /// <summary>
        /// Creates a new handle to a game file but does not load it. You will need to call <see cref="ProcessFileHandleQueue"/> yourself for these handles
        /// to be loaded, on a different thread.
        /// </summary>
        /// <param name="path">The path to the file to load</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load</typeparam>
        /// <returns>A handle to the file to be loaded</returns>
        public FileHandle< T > GetFileHandle< T >( string path ) where T : FileResource
        {
            return FileHandleManager.CreateHandle< T >( path );
        }

        /// <summary>
        /// Processes enqueued file handles that haven't been loaded yet. Call this on a different thread to process handles.
        /// </summary>
        public void ProcessFileHandleQueue()
        {
            FileHandleManager.ProcessQueue();
        }

        internal void SetCurrentContext()
        {
            SetCurrentContext( this );
        }

        internal static void SetCurrentContext( GameData gameData )
        {
            CurrentContext = new(() => gameData);
        }
    }
}