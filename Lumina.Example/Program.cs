using System;

namespace Lumina.Example
{
    class Program
    {
        static void Main( string[] args )
        {
            var lumina = new Lumina( args[ 0 ] );

            foreach( var cat in lumina.Categories )
            {
                Console.WriteLine( "cat: {0}, v: {1}", cat.BasePath.Name, cat.Version );

                foreach( var dat in cat.Dats )
                {
                    Console.WriteLine( "\tFound dat: cat: {0:x02}, ex: {1}, chunk: {2}", dat.Category, dat.Expansion, dat.Chunk );
                    Console.WriteLine("\t  index: {0}", dat.Index.IndexFile.Name );
                }
            }
        }
    }
}