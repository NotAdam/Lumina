using Lumina.Data;

namespace Lumina
{
    public class ParsedFilePath
    {
        public string Repository { get; internal set; }
        
        public string Category { get; internal set; }
        
        /// <summary>
        /// Index hash
        /// </summary>
        public ulong IndexHash { get; internal set; }
        
        /// <summary>
        /// Index2 hash
        /// </summary>
        public uint Index2Hash { get; internal set; }

        public uint FolderHash => (uint)(IndexHash >> 32);

        public uint FileHash => (uint)IndexHash;
    }
}