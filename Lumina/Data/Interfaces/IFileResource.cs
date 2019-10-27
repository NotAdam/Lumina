using System.Collections.Generic;
using System.IO;
using Lumina.Data.Structs;

namespace Lumina.Data.Interfaces
{
    public interface IFileResource
    {
        FileType FileType { get; set; }
        
        uint FileSize { get; set; }
        
        void LoadFile( Dictionary< byte, byte[] > data );
    }
}