using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Lumina.Extensions
{
    public static class RsvExtensions
    {
        public static List< string > GetEmbeddedRsvResources( this Assembly assembly )
        {
            return assembly.GetManifestResourceNames().Where( x => x.EndsWith( ".rsv" ) ).ToList();
        }

        public static void RegisterRsvFiles( this Assembly assembly, GameData gameData )
        {
            var rsv = gameData.Excel.RsvProvider;

            foreach( var file in GetEmbeddedRsvResources( assembly ) )
            {
                gameData.Logger?.Information( "Loading RSV: {RsvFileName}", file );

                using var s = assembly.GetManifestResourceStream( file );
                using var sr = new StreamReader( s! );

                var data = sr.ReadToEnd();

                rsv.ParseData( data );
            }
        }
    }
}