using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace Lumina.Cmd.Commands
{
    [Command( "file extract", Description = "Extract files as is from the game's filesystem" )]
    public class FileExtract : ICommand
    {
        [CommandParameter( 0, Description = "path to game file" )]
        public string FilePath { get; set; }

        [CommandOption( "dataPath", 'p',
            Description = "Path to the client sqpack folder",
            IsRequired = true,
            EnvironmentVariable = "LUMINA_CMD_CLIENT_PATH" )]
        public string Path { get; set; }

        [CommandOption( "outputPath", 'o',
            Description = "Override the output path for a game file. Defaults to the internal file path" )]
        public string OutputPath { get; set; } = null;

        public ValueTask ExecuteAsync( IConsole console )
        {
            var lumina = new GameData( Path );

            var file = lumina.GetFile( FilePath );

            if( file == null )
            {
                console.Error.WriteLine( $"file not found: {FilePath}" );
            }
            else
            {
                var path = OutputPath ?? FilePath;

                System.IO.Directory.CreateDirectory( System.IO.Path.GetDirectoryName( path ) );
                console.Output.WriteLine( $"wrote file to: {path}" );
                file.SaveFile( path );
            }

            return default;
        }
    }
}