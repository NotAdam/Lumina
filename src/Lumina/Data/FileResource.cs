using Lumina.Data.Structs.SqPack;
using System;
using System.IO;
using System.Security.Cryptography;

namespace Lumina.Data
{
    /// <summary>
    /// The beginning of everything, a game file.
    /// </summary>
    public class FileResource
    {
        public FileResource()
        {
            data = new( () => {
                var data = new byte[Reader!.BaseStream.Length];
                var pos = Reader.BaseStream.Position;
                Reader.BaseStream.Position = 0;
                Reader.BaseStream.ReadExactly( data );
                Reader.BaseStream.Position = pos;
                return data;
            } );
        }

        /// <summary>
        /// Parses a file from its raw, decompressed bytes.
        /// </summary>
        /// <remarks>
        /// Consumers that already hold a file's contents, such as tools reading modified files from disk,
        /// would otherwise have to initialize a whole <see cref="GameData"/> to parse them.
        /// </remarks>
        /// <param name="data">The raw, decompressed contents of the file.</param>
        /// <param name="platform">The platform the file was made for.</param>
        /// <typeparam name="T">The type of <see cref="FileResource"/> to parse as.</typeparam>
        /// <returns>The parsed file.</returns>
        public static T FromBytes< T >( ReadOnlyMemory< byte > data, PlatformType platform = PlatformType.Win32 )
            where T : FileResource, new()
        {
            var file = new T { Reader = new LuminaBinaryReader( data, platform ) };
            file.LoadFile();
            return file;
        }

        /// <summary>
        /// Information about the file from the game data, includes information copied from the file header such as size, block count and etc.
        /// </summary>
        [Obsolete( "Use SqPackStream.Header, and cast to SqPackStream subtypes for more informational headers." )]
        public SqPackFileHeader? FileInfo => SqPackStream?.Header;

        /// <summary>
        /// The raw file data as read from the game data.
        /// </summary>
        [Obsolete( "Refrain from using byte accessors and use the underlying stream." )]
        public byte[] Data => data.Value;

        private readonly Lazy< byte[] > data;

        /// <summary>
        /// A span of the file <see cref="Data"/>.
        /// </summary>
        [Obsolete( "Refrain from using byte accessors and use the underlying stream." )]
        public Span< byte > DataSpan => Data.AsSpan();

        /// <summary>
        /// A stream to access the file data. Should only be used for reading data, writing shouldn't be done directly to a <see cref="FileResource"/>
        /// </summary>
        [Obsolete( "Use \"Reader.BaseStream\" instead." )]
        public Stream? FileStream => Reader.BaseStream;

        /// <summary>
        /// A stream to access the file data. If this resource is from a raw file instead of an SqPack, this will be <see langword="null"/>.
        /// </summary>
        public SqPackStream? SqPackStream => Reader.BaseStream as SqPackStream;

        /// <summary>
        /// A pre-constructed <see cref="LuminaBinaryReader"/> to read the game file.
        /// </summary>
        /// <remarks>
        /// There are some extension methods to allow for nicer consumption of the <see cref="LuminaBinaryReader"/> in the <see cref="Lumina.Extensions"/> namespace.
        /// </remarks>
        public LuminaBinaryReader Reader { get; internal set; }

        /// <summary>
        /// The parsed file path that was created to load this file, if it was loaded from a path.
        /// </summary>
        public HashedFilePath? FilePath { get; internal set; }

        /// <summary>
        /// Called once the files are read out from the dats and <see cref="Data"/> has been populated.
        /// </summary>
        /// <remarks>
        /// This should be used to further parse the file into usable data structures (if necessary).
        /// </remarks>
        public virtual void LoadFile()
        {
            // this function is intentionally left blank
        }

        /// <summary>
        /// Saves a file to disk to the given path.
        /// </summary>
        /// <param name="path">The path to write the file to.</param>
        public virtual void SaveFile( string path )
        {
            var pos = Reader.Position;
            Reader.Position = 0;
            using( var file = File.Open( path, FileMode.Create, FileAccess.Write ) )
                Reader.BaseStream.CopyTo( file );
            Reader.Position = pos;
        }

        /// <summary>
        /// Saves a file to disk as-is. This will copy the underlying byte stream to disk as is and will do zero conversion.
        /// </summary>
        /// <param name="path">The path to write the file to.</param>
        public void SaveFileRaw( string path )
        {
            var pos = Reader.Position;
            Reader.Position = 0;
            using( var file = File.Open( path, FileMode.Create, FileAccess.Write ) )
                Reader.BaseStream.CopyTo( file );
            Reader.Position = pos;
        }

        /// <summary>
        /// Calculate the SHA256 of the file.
        /// </summary>
        /// <returns>The SHA265 of the file.</returns>
        public string GetFileHash()
        {
            var pos = Reader.Position;
            Reader.Position = 0;
            var hash = SHA256.HashData( Reader.BaseStream );
            Reader.Position = pos;

            return Convert.ToHexString( hash ).ToLowerInvariant();
        }
    }
}