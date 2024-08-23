namespace Lumina.Benchmark;

internal static class Program
{
    static void Main( string[] args )
    {
        BenchmarkDotNet.Running.BenchmarkSwitcher.FromAssembly( typeof( Program ).Assembly ).Run( args );
    }
}
