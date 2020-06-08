using System;
using System.Threading.Tasks;
using CliFx;

namespace Lumina.Cmd
{
    public static class Program
    {
        public static async Task< int > Main()
        {
            Pastel.ConsoleExtensions.Enable();
            
            return await new CliApplicationBuilder()
                .UseDescription( "A command line tool that probably does useful things." )
                .AddCommandsFromThisAssembly()
                .Build()
                .RunAsync();
        }

    }
}