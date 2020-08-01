using System;

namespace Umbra.Models
{
    public class FilePathInfo
    {
        public Guid Id { get; set; }
        
        public ulong IndexHash { get; set; }
        
        public uint Index2Hash { get; set; }
        
        public string Path { get; set; }
    }
}