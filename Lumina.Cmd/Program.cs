using System;
using System.Threading.Tasks;
using CliFx;

namespace Lumina.Cmd
{
    public static class Program
    {
        public static async Task< int > Main() =>
            await new CliApplicationBuilder()
                .UseDescription( "A command line tool that exposes useful functionality in a more digestible and code-free way." )
                .AddCommandsFromThisAssembly()
                .Build()
                .RunAsync();
    }
}