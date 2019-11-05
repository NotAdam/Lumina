using Lumina.Data;

namespace Lumina
{
    public class ParsedFilePath
    {
        public Repository Repository { get; internal set; }
        public string Category { get; internal set; }
        public ulong Hash { get; internal set; }
    }
}