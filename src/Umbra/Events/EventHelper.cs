using ReactiveUI;

namespace Umbra.Events
{
    public static class EventHelper
    {
        public static void DiscoverNewFile( string fullPath )
        {
            MessageBus.Current.SendMessage( new DiscoveredGameFilePath( fullPath ) );
        }
    }
}