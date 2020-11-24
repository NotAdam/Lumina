using System;
using System.IO;
using System.Text;

namespace Lumina.Data
{
    public class FileResource
    {
        public FileResource()
        {
        }

        public LuminaFileInfo FileInfo { get; internal set; }

        public byte[] Data { get; internal set; }

        public Span< byte > DataSpan => Data.AsSpan();

        public MemoryStream FileStream { get; internal set; }

        public BinaryReader Reader { get; internal set; }

        public ParsedFilePath FilePath { get; internal set; }

        /// <summary>
        /// Called once the files are read out from the dats. Used to further parse the file into usable data structures.
        /// </summary>
        public virtual void LoadFile()
        {
            // this function is intentionally left blank
        }

        public virtual void SaveFile( string path )
        {
            File.WriteAllBytes( path, Data );
        }

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