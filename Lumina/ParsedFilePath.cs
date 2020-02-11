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
        public ulong Hash { get; internal set; }
        
        /// <summary>
        /// Index2 hash
        /// </summary>
        public uint Hash2 { get; internal set; }
    }
}