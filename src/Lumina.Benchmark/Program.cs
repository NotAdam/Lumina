namespace Lumina.Benchmark;

internal static class Program
{
    static void Main( string[] args )
    {
        BenchmarkDotNet.Running.BenchmarkSwitcher.FromAssembly( typeof( Program ).Assembly ).Run( args );
    }

    public static GameData CreateGameData()
    {
        return new( @"J:\Programs\Steam\steamapps\common\FINAL FANTASY XIV Online\game\sqpack", new()
        {
            PanicOnSheetChecksumMismatch = false,
        } );
    }
}
