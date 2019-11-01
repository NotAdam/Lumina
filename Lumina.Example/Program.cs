using System;
using System.IO;
using System.Linq;

namespace Lumina.Example
{
    class Program
    {
        static void Main( string[] args )
        {
            var lumina = new Lumina( args[ 0 ] );

            var file = lumina.GetFile( "exd/root.exl" );

            file.SaveFile( "root.exl" );
        }
    }
}