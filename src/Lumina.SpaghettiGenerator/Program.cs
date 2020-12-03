using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data.Structs.Excel;
using Lumina.SpaghettiGenerator.CodeGen;
using Newtonsoft.Json;

namespace Lumina.SpaghettiGenerator
{
    public class Program
    {
        static void Main( string[] args )
        {
            var sg = new SpaghettiGenerator( args[ 0 ] );

            Directory.CreateDirectory( "output" );

            foreach( var file in Directory.EnumerateFiles( "./Definitions/", "*.json" ) )
            {
                var name = Path.GetFileNameWithoutExtension( file );
                Console.WriteLine( $"doing sheet: {name}" );

                var code = sg.ProcessDefinition( name );
                if( code == null )
                {
                    continue;
                }

                var path = $"./output/{name}.cs";
                File.WriteAllText( path, code );
            }
        }
    }
}