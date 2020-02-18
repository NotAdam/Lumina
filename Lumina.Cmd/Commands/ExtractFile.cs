using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;

namespace Lumina.Cmd.Commands
{
    [Command( "extractfile", Description = "Extract files as is from the game's filesystem" )]
    public class ExtractFile : ICommand
    {
        [CommandParameter( 0, Description = "path to game file" )]
        public string FilePath { get; set; }

        [CommandOption( "path", 'p',
            Description = "Path to the older client install location",
            IsRequired = true,
            EnvironmentVariableName = "LUMINA_CMD_CLIENT_PATH" )]
        public string Path { get; set; }

        public ValueTask ExecuteAsync( IConsole console )
        {
            var lumina = new Lumina( Path );

            var file = lumina.GetFile( FilePath );

            if( file == null )
            {
                console.Error.WriteLine( $"file not found: {FilePath}" );
            }
            else
            {
                System.IO.Directory.CreateDirectory( System.IO.Path.GetDirectoryName( FilePath ) );
                console.Output.WriteLine( $"wrote file to: {FilePath}" );
                file.SaveFile( FilePath );
            }

            return default;
        }
    }
}