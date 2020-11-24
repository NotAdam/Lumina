using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files;

namespace Lumina.Extensions
{
    public static class LuminaExtensions
    {
        /// <summary>
        /// Get an icon by its ID
        /// </summary>
        /// <param name="lumina">The lumina instance</param>
        /// <param name="iconId">The icon ID</param>
        /// <returns>A <see cref="TexFile"/> containing the image data, or null if it wasn't found</returns>
        public static TexFile GetIcon( this Lumina lumina, int iconId )
        {
            var path = $"ui/icon/{iconId / 1000 * 1000:000000}/{iconId:000000}.tex";

            return lumina.GetFile< TexFile >( path );
        }

        /// <summary>
        /// Iterates every file across all loaded dats synchronously. Note that this is quite slow, you'll want to steal this code and multithread it if
        /// you want to do any serious scanning.
        /// </summary>
        /// <param name="lumina"></param>
        /// <returns></returns>
        public static IEnumerable< FileResource > IterateAllFiles( this Lumina lumina )
        {
            foreach( var repo in lumina.Repositories )
            {
                foreach( var cat in repo.Value.Categories.SelectMany( x => x.Value ) )
                {
                    foreach( var entry in cat.IndexHashTableEntries )
                    {
                        var index = entry.Value;
                        var dat = cat.DatFiles[ index.DataFileId ];

                        yield return dat.ReadFile< FileResource >( index.Offset );
                    }
                }
            }
        }
    }
}