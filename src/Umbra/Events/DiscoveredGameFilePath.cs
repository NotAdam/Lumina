namespace Umbra.Events
{
    public class DiscoveredGameFilePath
    {
        public DiscoveredGameFilePath( string fullPath )
        {
            FullPath = fullPath;
        }
        
        public string FullPath { get; set; }
    }
}