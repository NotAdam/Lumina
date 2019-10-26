using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Lumina.Data
{
    public class DatCategory
    {
        public DirectoryInfo BasePath { get; private set; }

        /// <summary>
        /// Returns the name of the current dat category
        /// </summary>
        public string Name => BasePath.Name;

        public string Version { get; private set; }

        public int ExpansionId { get; private set; }

        public static readonly Dictionary< string, int > CategoryNameToIdMap = new Dictionary< string, int >
        {
            {"common",          0x00},
            {"bgcommon",        0x01},
            {"bg",              0x02},
            {"cut",             0x03},
            {"chara",           0x04},
            {"shader",          0x05},
            {"ui",              0x06},
            {"sound",           0x07},
            {"vfx",             0x08},
            {"ui_script",       0x09},
            {"exd",             0x0A},
            {"game_script",     0x0B},
            {"music",           0x0C}
        };

        public static readonly Dictionary< int, string > CategoryIdToNameMap =
            CategoryNameToIdMap.ToDictionary( x => x.Value, x => x.Key );
        
        /// <summary>
        /// A collection of dats assoicated with the current category or expansion.
        /// </summary>
        public List< Dat > Dats { get; set; }

        public DatCategory( DirectoryInfo basePath )
        {
            BasePath = basePath;

            // calc expac id
            if( Name.StartsWith( "ex" ) )
            {
                try
                {
                    ExpansionId = int.Parse( Name.Substring( 2 ) );
                }
                catch( FormatException e )
                {
                    Trace.TraceWarning( "failed to parse expansionid, e: {0}", e.Message );
                    throw;
                }
            }
            
            ParseVersion();
            SetupIndexes();
        }

        /// <summary>
        /// Reads the current version associated with the category
        /// </summary>
        private void ParseVersion()
        {
            string versionPath = null;
            
            // haha what the fuck?
            if( Name == "ffxiv" )
            {
                var path = BasePath.Parent.Parent;
                versionPath = Path.Combine( path.FullName, "ffxivgame.ver" );
            }
            else
            {
                // (less) gross version fetch
                versionPath = Path.Combine( BasePath.FullName, Name + ".ver" );
            }
            
            if( File.Exists( versionPath ) )
            {
                Version = File.ReadAllText( versionPath );
            } 
        }

        /// <summary>
        /// Autodiscovers dats and a relevant index for them
        /// </summary>
        private void SetupIndexes()
        {
            Dats = new List< Dat >();
            foreach( var cat in CategoryNameToIdMap )
            {
                // discover indexes first
                // once we find an index, that index will have an associated dat (or dats) too
                // so we don't need to discover those here
                for( int chunk = 0; chunk < 255; chunk++ )
                {
                    var file = FindIndex( cat.Value, ExpansionId, chunk );

                    if( file == null || chunk == -1 )
                    {
                        break;
                    }
                    
                    var index = new Index( file );
                    var dat = new Dat( cat.Value, ExpansionId, chunk, Lumina.Options.CurrentPlatform, index );

                    Dats.Add( dat );
                }
            }
        }

        /// <summary>
        /// Builds a filename for a specific game dat
        /// 
        /// Copied shamelessly: https://github.com/SapphireServer/Sapphire/blob/master/deps/datReader/GameData.cpp#L133-L138
        /// </summary>
        /// <param name="cat">Dat category, see CategoryNameToIdMap</param>
        /// <param name="ex">Expansion id</param>
        /// <param name="chunk">Chunk id</param>
        /// <param name="platform">Current platform</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string BuildDatStr( int cat, int ex, int chunk, DatPlatform platform, string type )
        {
            return $"{cat:x02}{ex:x02}{chunk:x02}.{platform.ToString()}.{type}";
        }

        /// <summary>
        /// Brute force for an index or index2 file
        /// </summary>
        /// <param name="cat">Current category id</param>
        /// <param name="ex">Current expansion id</param>
        /// <param name="chunk">The chunk id</param>
        /// <returns>System.IO.FileInfo representing the index file found</returns>
        public FileInfo FindIndex( int cat, int ex, int chunk )
        {
            foreach( var type in new[] { "index", "index2" } )
            {
                var index = BuildDatStr( cat, ex, chunk, Lumina.Options.CurrentPlatform, type );
                var path = Path.Combine( BasePath.FullName, index );

                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    return fileInfo;
                }
            }
            
            return null;
        }
    }
}