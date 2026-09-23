using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Hashing;
using System.Text;
using Lumina.Data;
using Lumina.Data.Structs.SqPack;
using Lumina.Excel;
using Lumina.Excel.Exceptions;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina
{
    public class GameData : IDisposable
    {
        ~GameData() => Dispose( false );

        /// <summary>
        /// The current data path that Lumina is using to load files.
        /// </summary>
        public DirectoryInfo DataPath { get; }

        /// <summary>
        /// Provides access to each <see cref="RepositoryInfo"/>, which contains the base game content or expansion content. Each folder inside the sqpack
        /// directory is a repository.
        /// </summary>
        public List<RepositoryInfo> Repositories => Vfs.Repositories;

        /// <summary>
        /// Provides access to <see cref="LuminaOptions"/> at runtime. Most of these can be changed without issue without having to create a new instance.
        /// </summary>
        public LuminaOptions Options { get; }

        /// <summary>
        /// Reading PS3 dats on a LE machine means we need to convert endianness from BE where applicable
        /// </summary>
        [Obsolete( "Use property \"ConvertEndianness\" from \"LuminaBinaryReader\" instead" )]
        public bool ShouldConvertEndianness => Options.CurrentPlatform == PlatformType.PS3 && BitConverter.IsLittleEndian;

        /// <summary>
        /// The virtual filesystem that .dat data is loaded into.
        /// </summary>
        public SqPackVfs Vfs { get; }

        /// <summary>
        /// Provides access to EXD/EXH data, internally called Excel.
        ///
        /// Loaded by default on init unless you opt not to load it.
        /// </summary>
        public ExcelModule Excel { get; }
        
        /// <summary>
        /// Provides access to the <see cref="FileHandleManager"/> which allows you to create new <see cref="FileHandle{T}"/>s which then allows you to
        /// easily defer file loading onto another thread.
        /// </summary>
        public FileHandleManager FileHandleManager { get; }

        /// <summary>
        /// Provides access to the current <see cref="GameData"/> object that was invoked on this thread (if any).
        /// </summary>
        public static GameData? CurrentContext => currentContext;

        [ThreadStatic]
        private static GameData? currentContext;

        /// <summary>
        /// Constructs a new <see cref="GameData"/> allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <param name="ignoreDataPathName">If <see langword="true"/>, <paramref name="dataPath"/> is allowed to be named something other than "sqpack" without throwing an <see cref="ArgumentException"/>.</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="dataPath"/> does not point to a directory with the name "sqpack" and when <paramref name="ignoreDataPathName"/> is <see langword="false"/>.</exception>
        public GameData( string dataPath, LuminaOptions? options = null, bool ignoreDataPathName = false)
        {
            DataPath = new( dataPath );

            if( !DataPath.Exists )
            {
                throw new DirectoryNotFoundException($"Directory not found: {DataPath.FullName}");
            }
            
            if( !ignoreDataPathName && DataPath.Name != "sqpack" )
            {
                throw new ArgumentException( "Directory must be named 'sqpack'", nameof( dataPath ) );
            }

            Options = options ?? new();
            Vfs = new( this );

            Vfs.Initialize().GetAwaiter().GetResult();

            Excel = new( this );
            FileHandleManager = new( this );
        }

        private static LuminaOptions AddLoggerToOptions( ILogger logger, LuminaOptions? options )
        {
            options ??= new();
            options.Logger = logger;
            return options;
        }

        /// <summary>
        /// Constructs a new Lumina object allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="logger">An <see cref="ILogger"/> implementation that Lumina can send log events to</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        [Obsolete( "Use the LuminaOptions.Logger property" )]
        public GameData( string dataPath, ILogger logger, LuminaOptions? options = null ) : this( dataPath, AddLoggerToOptions(logger, options) )
        {
        }

        /// <summary>
        /// Parses a game filesystem path and extracts information and hashes the path provided. 
        /// </summary>
        /// <param name="path">A game filesystem path</param>
        /// <returns>A <see cref="HashedFilePath"/> which contains extracted info from the path, along with the hashes used to access the file index</returns>
        public static HashedFilePath? ParseFilePath( string path )
        {
            try
            {
                return HashedFilePath.Create( path );
            }
            catch( ArgumentException )
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        /// <summary>
        /// Load a raw file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <returns>The base <see cref="FileResource"/> if it was found, or null if it wasn't found</returns>
        public FileResource GetFile( string path )
        {
            return GetFile<FileResource>( path );
        }

        /// <summary>
        /// Load a defined file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load the raw file in to</typeparam>
        /// <returns>Returns the requested file if found, null if not</returns>
        public T GetFile<T>( string path ) where T : FileResource
        {
            var stream = Vfs.GetFileStream( path );

            SetCurrentContext();
            var file = Activator.CreateInstance< T >();

            file.Reader = new LuminaBinaryReader( stream, Options.CurrentPlatform );

            file.LoadFile();

            return file;
        }

        /// <summary>
        /// Load a raw file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <returns>The base <see cref="FileResource"/> if it was found, or <see langword="null"/> if it wasn't found</returns>
        public FileResource? TryGetFile( string path )
        {
            return TryGetFile<FileResource>( path );
        }

        /// <summary>
        /// Load a defined file given a game file path
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load the raw file in to</typeparam>
        /// <returns>Returns the requested file if found, <see langword="null"/> if not</returns>
        public T? TryGetFile<T> (string path) where T : FileResource
        {
            if( Vfs.TryGetFileStream( path ) is not { } stream )
                return null;

            SetCurrentContext();
            var file = Activator.CreateInstance<T>();

            file.Reader = new LuminaBinaryReader( stream, Options.CurrentPlatform );

            file.LoadFile();

            return file;
        }

        /// <summary>
        /// Load a defined file given a filesystem path
        /// </summary>
        /// <param name="path">A relative or absolute path to the file to load</param>
        /// <param name="origPath">The original file path in SqPack, required for reading some files (e.g. materials)</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to load the raw file in to</typeparam>
        /// <returns>The requested file if found, null if not</returns>
        /// <exception cref="FileNotFoundException">The path given doesn't point to an existing file</exception>
        public T GetFileFromDisk< T >( string path, string? origPath = null ) where T : FileResource
        {
            if( !File.Exists( path ) )
            {
                throw new FileNotFoundException( "the file at the specified path doesn't exist" );
            }

            var fileContent = File.ReadAllBytes( path );

            var file = Activator.CreateInstance< T >();
            if( origPath != null )
            {
                throw new NotImplementedException();
                //file.FilePath = new( )!;
            }
            file.Reader = new LuminaBinaryReader( fileContent, Options.CurrentPlatform );
            file.LoadFile();

            return file;
        }

        /// <summary>
        /// Returns file metadata pulled directly from the file header inside the SqPack
        /// </summary>
        /// <param name="path">A path to a file located inside the game's filesystem</param>
        /// <returns>A <see cref="SqPackFileHeader"/> if it was found, <see langword="null"/> if not</returns>
        public SqPackFileHeader? GetFileMetadata( string path )
        {
            using var stream = Vfs.TryGetFileStream( path );
            return stream?.Header;
        }

        /// <summary>
        /// Check if a file exists anywhere by checking whether the hash exists in any index
        /// </summary>
        /// <param name="path">The full path of the file</param>
        /// <returns>True if the file exists</returns>
        public bool ContainsFile( string path ) =>
            Vfs.ContainsFile( path );

        /// <summary>
        /// Returns the index variant of a file hash
        /// </summary>
        /// <param name="path">The full path of the file</param>
        /// <returns>A U64 containing a split hash of the folder and file CRC32s</returns>
        [Obsolete("V0 Path Hash", error: true)]
        public static ulong GetFileHash( string path )
        {
            var pathParts = path.Split( '/' );
            var filename = pathParts[ ^1 ];
            var folder = path[..path.LastIndexOf( '/' )];

            return (ulong)Crc32.HashToUInt32( Encoding.ASCII.GetBytes( folder ) ) << 32 | Crc32.HashToUInt32( Encoding.ASCII.GetBytes( filename ) );
        }

        /// <summary>Loads an <see cref="ExcelSheet{T}"/>. Returns <see langword="null"/> if the sheet does not exist, has an invalid column hash or unsupported variant, or was requested with an unsupported language.</summary>
        /// <param name="language">The requested sheet language. Leave <see langword="null"/> or empty to use the default language.</param>
        /// <param name="name">The requested explicit sheet name. Leave <see langword="null"/> to use <typeparamref name="T"/>'s sheet name. Explicit names are necessary for quest/dungeon/cutscene sheets.</param>
        /// <returns>An excel sheet corresponding to <typeparamref name="T"/> and <paramref name="language"/> that may be created anew or
        /// reused from a previous invocation of this method.</returns>
        /// <remarks>
        /// If the requested language doesn't exist for the file where <paramref name="language"/> is not <see cref="Language.None"/>, the
        /// language-neutral sheet using <see cref="Language.None"/> will be loaded instead. If the language-neutral sheet does not exist, then the function
        /// will return <see langword="null"/>.
        /// </remarks>
        /// <exception cref="SheetNameEmptyException">Sheet name was not specified neither via <typeparamref name="T"/>'s <see cref="SheetAttribute.Name"/> nor <paramref name="name"/>.</exception>
        /// <exception cref="SheetAttributeMissingException"><typeparamref name="T"/> does not have a valid <see cref="SheetAttribute"/>.</exception>
        public ExcelSheet< T >? GetExcelSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelRow< T >
        {
            try
            {
                return Excel.GetSheet< T >( language, name );
            }
            catch( Exception e ) when ( e is SheetNotFoundException or MismatchedColumnHashException or NotSupportedException or UnsupportedLanguageException )
            {
                return null;
            }
        }

        /// <summary>Loads a <see cref="SubrowExcelSheet{T}"/>. Returns <see langword="null"/> if the sheet does not exist, has an invalid column hash or unsupported variant, or was requested with an unsupported language.</summary>
        /// <inheritdoc cref="GetExcelSheet{T}(Nullable{Language}, string?)"/>
        public SubrowExcelSheet< T >? GetSubrowExcelSheet< T >( Language? language = null, string? name = null ) where T : struct, IExcelSubrow< T >
        {
            try
            {
                return Excel.GetSubrowSheet< T >( language, name );
            }
            catch( Exception e ) when ( e is SheetNotFoundException or MismatchedColumnHashException or NotSupportedException or UnsupportedLanguageException )
            {
                return null;
            }
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

        internal void SetCurrentContext() =>
            currentContext = this;

        /// <summary>Disposes this object.</summary>
        /// <param name="disposing">Whether this function is being called from <see cref="Dispose"/>.</param>
        protected virtual void Dispose( bool disposing )
        {
            if( disposing )
            {

            }
        }
    }
}
