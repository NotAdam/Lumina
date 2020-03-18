using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;

namespace Lumina.Cmd.Commands
{
    [Command( "filediff",
        Description = "Given a path list, this will diff files by size and then hash to see if they've changed. Requires 2 client installs with appropriate dats available in each." )]
    public class FileDiff : ICommand
    {
        [CommandOption( "oldpath", 'p', Description = "Path to the older client install location", IsRequired = true )]
        public string Path { get; set; }

        [CommandOption( "newpath", 'n', Description = "Path to the new client install location", IsRequired = true )]
        public string NewPath { get; set; }

        [CommandOption( "paths", 'l', Description = "pathlist to test", IsRequired = true )]
        public string PathsFile { get; set; } = "";


        public ValueTask ExecuteAsync( IConsole console )
        {
            var co = console.Output;
            var opts = new LuminaOptions
            {
                CacheFileResources = false
            };

            var ol = new Lumina( Path, opts );
            var nl = new Lumina( NewPath, opts );

            if( !File.Exists( PathsFile ) )
            {
                console.Error.WriteLine( "paths list file provided does not exist!" );
            }

            var paths = File.ReadAllLines( PathsFile );

            Parallel.ForEach( paths, path =>
            {
                var oldMeta = ol.GetFileMetadata( path );
                var newMeta = nl.GetFileMetadata( path );

                if( oldMeta == null || newMeta == null )
                {
                    return;
                }

                if( oldMeta.Value.RawFileSize != newMeta.Value.RawFileSize )
                {
                    co.WriteLine( $"size mismatch: {path}" );
                    return;
                }

                var oldFile = ol.GetFile( path );
                var newFile = nl.GetFile( path );

                var oHash = oldFile.GetFileHash();
                var nHash = newFile.GetFileHash();

                if( oHash != nHash )
                {
                    co.WriteLine( $"hash mismatch: {path}" );
                }
            } );

            return default;
        }
    }
}