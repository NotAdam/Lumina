using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using Lumina.Data;
using Lumina.Data.Files;
using Lumina.Data.Files.Excel;
using Pastel;

namespace Lumina.Cmd.Commands
{
    [Command( "file", Description = "Prints information about a file and provides other filesystem utils" )]
    public class FileInfo : ICommand
    {
        [CommandParameter( 0, Description = "path to game file" )]
        public string FilePath { get; set; }

        [CommandOption( "dataPath", 'p',
            Description = "Path to the client sqpack folder",
            IsRequired = true,
            EnvironmentVariableName = "LUMINA_CMD_CLIENT_PATH" )]
        public string DataPath { get; set; }

        private FileResource LoadResource( Lumina lumina, string path )
        {
            var ext = Path.GetExtension( path );

            switch( ext )
            {
                case ".exh":
                    return lumina.GetFile< ExcelHeaderFile >( path );

                case ".exd":
                    return lumina.GetFile< ExcelDataFile >( path );

                case ".exl":
                    return lumina.GetFile< ExcelListFile >( path );

                case ".imc":
                    return lumina.GetFile< ImcFile >( path );

                case ".lgb":
                    return lumina.GetFile< LgbFile >( path );

                case ".tex":
                    return lumina.GetFile< TexFile >( path );
            }

            return null;
        }

        public ValueTask ExecuteAsync( IConsole console )
        {
            var lumina = new Lumina( DataPath );

            var file = LoadResource( lumina, FilePath );

            var co = console.Output;

            co.WriteLine( $"File info ({file.GetType().FullName.Data()})" );
            co.WriteLine( $" path: {file.FilePath.Path.Data()}" );
            co.WriteLine( $" repo: {file.FilePath.Repository.Data()} cat: {file.FilePath.Category.Data()}" );
            co.WriteLine( $" size: {file.Data.Length.Data()}" );

            switch( file )
            {
                case LgbFile f:
                {
                    co.WriteLine( "Lgb Info:" );
                    co.WriteLine( $" layers: {f.Layers.Length.Data()}");

                    for( int i = 0; i < f.Layers.Length; i++ )
                    {
                        var layer = f.Layers[ i ];
                        co.WriteLine($" - layer {i.Data()} - {layer.Name.Data()}");
                    }
                    break;
                }
            }

            return default;
        }
    }
}