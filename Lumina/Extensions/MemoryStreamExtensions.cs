using System.IO;

namespace Lumina.Extensions
{
    public static class MemoryStreamExtensions
    {
        public static void Write( this MemoryStream stream, byte[] data )
        {
            stream.Write( data, 0, data.Length );
        }
    }
}