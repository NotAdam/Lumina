using System;
using System.IO;

namespace Lumina.SpaghettiUpdater
{
    public class Program
    {
        static void Main( string[] args )
        {
            var oldPath = args[ 0 ];
            var newPath = args[ 1 ];
            
            var sg = new SpaghettiUpdater( oldPath, newPath );

            Directory.CreateDirectory( "output" );
            
            foreach( var file in Directory.EnumerateFiles( "./Definitions/", "*.json" ) )
            {
                var name = Path.GetFileNameWithoutExtension( file );
                var result = sg.ProcessDefinition( name );
                
                if( string.IsNullOrEmpty(result) ) continue;
                var path = $"./output/{name}.json";
                File.WriteAllText( path, result );
            }
            
            Console.WriteLine();
            Console.WriteLine("Questionable sheets (may not have updated properly):");
            foreach( var s in sg.QuestionableSheets )
            {
                Console.WriteLine(s);
            }
        }
    }
}