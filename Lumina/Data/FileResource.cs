using System;
using System.Collections.Generic;
using System.IO;
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

        public virtual void LoadFile()
        {
        }

        public byte[] GetDataSection( byte sectionId )
        {
            var stream = DataSections[ sectionId ];

            return stream.ToArray();
        }
    }
}