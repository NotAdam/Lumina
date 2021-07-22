using System;
using System.IO;
using System.Text;

namespace Lumina.Data
{
    /// <summary>
    /// The beginning of everything, a game file.
    /// </summary>
    public class FileResource
    {
        public FileResource()
        {
        }

        /// <summary>
        /// Information about the file from the game data, includes information copied from the file header such as size, block count and etc.
        /// </summary>
        public LuminaFileInfo FileInfo { get; internal set; }

        /// <summary>
        /// The raw file data as read from the game data.
        /// </summary>
        public byte[] Data { get; internal set; }

        /// <summary>
        /// A span of the file <see cref="Data"/>.
        /// </summary>
        public Span< byte > DataSpan => Data.AsSpan();

        /// <summary>
        /// A stream to access the file data. Should only be used for reading data, writing shouldn't be done directly to a <see cref="FileResource"/>
        /// </summary>
        public MemoryStream FileStream { get; internal set; }

        /// <summary>
        /// A pre-constructed <see cref="BinaryReader"/> to read the game file.
        /// </summary>
        /// <remarks>
        /// There are some extension methods to allow for nicer consumption of the <see cref="BinaryReader"/> in the <see cref="Lumina.Extensions"/> namespace.
        /// </remarks>
        public BinaryReader Reader { get; internal set; }

        /// <summary>
        /// The parsed file path that was created to load this file.
        /// </summary>
        public ParsedFilePath FilePath { get; internal set; }

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
            File.WriteAllBytes( path, Data );
        }

        /// <summary>
        /// Saves a file to disk as-is. This will copy the underlying byte stream to disk as is and will do zero conversion.
        /// </summary>
        /// <param name="path">The path to write the file to.</param>
        public void SaveFileRaw( string path )
        {
            File.WriteAllBytes( path, Data );
        }

        /// <summary>
        /// Calculate the SHA256 of the file.
        /// </summary>
        /// <returns>The SHA265 of the file.</returns>
        public string GetFileHash()
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            var hash = sha256.ComputeHash( Data );

            var sb = new StringBuilder();
            foreach( var b in hash )
            {
                sb.Append( $"{b:x2}" );
            }

            return sb.ToString();
        }
    }
}