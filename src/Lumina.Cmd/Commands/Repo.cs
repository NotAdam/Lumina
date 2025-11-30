using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Lumina.Data;

namespace Lumina.Cmd.Commands
{
    [Command( "repo" )]
    public class Repo : ICommand
    {
        [CommandOption( "dataPath", 'p',
            Description = "Path to the client sqpack folder",
            IsRequired = true,
            EnvironmentVariable = "LUMINA_CMD_CLIENT_PATH" )]
        public string DataPath { get; set; }

        public ValueTask ExecuteAsync( IConsole console )
        {
            var lumina = new GameData( DataPath );

            var totalFiles = 0;

            foreach( var repo in lumina.Repositories.Select( r => r.Value ) )
            {
                console.Output.WriteLine( $"Repository: {repo.Name.Data()}" );
                console.Output.WriteLine( $"Version: {repo.Version.Data()}" );

                var repoFileCount = 0;

                foreach( var cat in repo.Categories )
                {
                    if( cat.Value.Count == 0 )
                        continue;

                    var name = Repository.CategoryIdToNameMap[ cat.Key ];

                    console.Output.WriteLine( $" Category: {name.Data()}" );

                    var fileCount = 0;

                    foreach( var dat in cat.Value )
                    {
                        console.Output.WriteLine( $"  - dat: {dat.Chunk.Data()} files: {dat.IndexHashTableEntries.Count}" );
                        fileCount += dat.IndexHashTableEntries.Count;
                    }

                    totalFiles += fileCount;
                    repoFileCount += fileCount;
                }

                console.Output.WriteLine( $"repo filecount: {repoFileCount.Data()}" );
            }

            console.Output.WriteLine();
            console.Output.WriteLine( $"total filecount: {totalFiles.Data()}" );

            return default;
        }
    }
}