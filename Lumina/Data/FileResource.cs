using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Lumina.Data.Structs;

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

        /// <summary>
        /// Called once the files are read out from the dats. Used to further parse the file into usable data structures.
        /// </summary>
        public virtual void LoadFile()
        {
        }

        public virtual void SaveFile( string path )
        {
            File.WriteAllBytes( path, Data );
        }
    }
}