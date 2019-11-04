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
            DataSections = new Dictionary< byte, MemoryStream >();
        }
        
        public SqPackFileInfo FileInfo { get; internal set; }

        internal uint BaseOffset { get; set; }

        public Dictionary< byte, MemoryStream > DataSections { get; internal set; }
        
        public byte[] Data { get; internal set; }

        public Span<byte> DataSpan => Data.AsSpan();

        /// <summary>
        /// Called once the files are read out from the dats. Used to further parse the file into usable data structures.
        /// </summary>
        public virtual void LoadFile()
        {
        }

        public byte[] GetDataSection( byte sectionId )
        {
            var stream = DataSections[ sectionId ];

            return stream.ToArray();
        }

        public void SaveFile( string path, byte section = 0 )
        {
            var data = GetDataSection( section );

            File.WriteAllBytes( path, data );
        }
    }
}