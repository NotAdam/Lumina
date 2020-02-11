using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;
using Lumina.Data.Structs;
using Microsoft.VisualBasic.CompilerServices;

namespace Lumina.Data
{
    public class Repository
    {
        private readonly Lumina _Lumina;
        public DirectoryInfo RootDir { get; private set; }

        /// <summary>
        /// Returns the name of the current dat category
        /// </summary>
        public string Name => RootDir.Name;

        public string Version { get; private set; }

        public int ExpansionId { get; private set; }

        public static readonly Dictionary< string, byte > CategoryNameToIdMap = new Dictionary< string, byte >
        {
            { "common", 0x00 },
            { "bgcommon", 0x01 },
            { "bg", 0x02 },
            { "cut", 0x03 },
            { "chara", 0x04 },
            { "shader", 0x05 },
            { "ui", 0x06 },
            { "sound", 0x07 },
            { "vfx", 0x08 },
            { "ui_script", 0x09 },
            { "exd", 0x0A },
            { "game_script", 0x0B },
            { "music", 0x0C },
            { "sqpack_test", 0x12 },
            { "debug", 0x13 },
        };

        public static readonly Dictionary< byte, string > CategoryIdToNameMap =
            CategoryNameToIdMap.ToDictionary( x => x.Value, x => x.Key );

        /// <summary>
        /// A collection of dats assoicated with the current repository.
        /// </summary>
        public Dictionary< byte, List< Category > > Categories { get; set; }

        internal Repository( DirectoryInfo rootDir, Lumina lumina )
        {
            _Lumina = lumina;
            RootDir = rootDir;

            GetExpansionId();
            ParseVersion();
            SetupIndexes();
        }

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public T GetFile< T >( string cat, ParsedFilePath path ) where T : FileResource
        {
            if( CategoryNameToIdMap.TryGetValue( cat, out var catId ) )
            {
                return GetFile< T >( catId, path );
            }

            return null;
        }

        public T GetFile< T >( byte cat, ParsedFilePath path ) where T : FileResource
        {
            if( Categories.TryGetValue( cat, out var categories ) )
            {
                foreach( var category in categories )
                {
                    var file = category.GetFile< T >( path );
                    if( file != null )
                        return file;
                }
            }

            return null;
        }

        private void GetExpansionId()
        {
            if( !Name.StartsWith( "ex" ) )
            {
                return;
            }

            try
            {
                ExpansionId = int.Parse( Name.Substring( 2 ) );
            }
            catch( FormatException e )
            {
                Trace.TraceWarning( "failed to parse expansionid, e: {0}", e.Message );
            }
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
                var path = RootDir.Parent.Parent;
                versionPath = Path.Combine( path.FullName, "ffxivgame.ver" );
            }
            else
            {
                // (less) gross version fetch
                versionPath = Path.Combine( RootDir.FullName, Name + ".ver" );
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
            Categories = new Dictionary< byte, List< Category > >();
            foreach( var cat in CategoryNameToIdMap )
            {
                var catList = Categories[ cat.Value ] = new List< Category >();
                // discover indexes first
                // once we find an index, that index will have an associated dat (or dats) too
                // so we don't need to discover those here
                for( int chunk = 0; chunk < 255; chunk++ )
                {
                    var indexFiles = FindIndexes( cat.Value, ExpansionId, chunk );

                    if( indexFiles.Count == 0 )
                    {
                        continue;
                    }

                    var indexes = new List< SqPackIndex >();

                    foreach( var fileInfo in indexFiles )
                    {
                        indexes.Add( new SqPackIndex( fileInfo, _Lumina ) );
                    }

                    var dat = new Category( 
                        cat.Value,
                        ExpansionId,
                        chunk,
                        _Lumina.Options.CurrentPlatform,
                        indexes,
                        RootDir,
                        _Lumina );

                    catList.Add( dat );
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
        public static string BuildDatStr( byte cat, int ex, int chunk, Structs.PlatformId platform, string type )
        {
            return $"{cat:x02}{ex:x02}{chunk:x02}.{platform.ToString().ToLowerInvariant()}.{type}";
        }

        /// <summary>
        /// Brute force for index and index2 files
        /// </summary>
        /// <param name="cat">Current category id</param>
        /// <param name="ex">Current expansion id</param>
        /// <param name="chunk">The chunk id</param>
        /// <returns>System.IO.FileInfo representing the index file found</returns>
        public List< FileInfo > FindIndexes( byte cat, int ex, int chunk )
        {
            var files = new List< FileInfo >();
            
            foreach( var type in new[] { "index", "index2" } )
            {
                var index = BuildDatStr( cat, ex, chunk, _Lumina.Options.CurrentPlatform, type );
                var path = Path.Combine( RootDir.FullName, index );

                var fileInfo = new FileInfo( path );

                if( fileInfo.Exists )
                {
                    files.Add( fileInfo );
                }
            }

            return files;
        }

        public bool FileExists( string catName, ParsedFilePath path )
        {
            if( !CategoryNameToIdMap.TryGetValue( catName, out var catId ) )
            {
                return false;
            }
            
            var categories = Categories[ catId ];

            foreach( var cat in categories )
            {
                // nb: keep these as separate checks because it'll run both otherwise which is a bit pointless
                if( cat.FileExists( path.IndexHash ) )
                    return true;

                if( cat.FileExists( path.Index2Hash ) )
                    return true;
            }

            return false;
        }
    }
}