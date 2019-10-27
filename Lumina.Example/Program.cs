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

            foreach( var repo in lumina.Repositories )
            {
                Console.WriteLine( "cat: {0}, v: {1}", repo.Value.RootDir.Name, repo.Value.Version );

                foreach( var dat in repo.Value.Categories )
                {
                    Console.WriteLine( "  Found dat: cat: {0:x02}, ex: {1}, chunk: {2}",
                        dat.Value.CategoryId,
                        dat.Value.Expansion,
                        dat.Value.Chunk );
                    Console.WriteLine( "    index: {0} -> platform: {1}, entries: {2}, datfiles: {3}",
                        dat.Value.SqPackIndex.File.Name,
                        dat.Value.SqPackIndex.SqPackHeader.platformId,
                        dat.Value.SqPackIndex.HashTableEntries.Count,
                        dat.Value.DatFiles.Count );

                    foreach( var datFile in dat.Value.DatFiles )
                    {
                        Console.WriteLine( "      file: {0}", datFile.Value.Name );
                    }
                }
            }

            foreach( var filePath in new[]
            {
                "exd/root.exl",
                "music/ffxiv/bgm_system_title.scd",
                "music/ex2/bgm_ex2_system_title.scd",
                "music/ex3/bgm_ex3_system_title.scd",
                "bg/ex3/01_nvt_n4/fld/n4fa/level/bg.lgb"
            } )
            {
                var file = lumina.GetFile( filePath );

                if( file == null )
                {
                    continue;
                }

                Console.WriteLine( "got file: {0} @ 0x{1:x} ({2:x}), dat: {3}", 
                    filePath, 
                    file.HashTableEntry.Offset,
                    file.HashTableEntry.data, 
                    file.HashTableEntry.DataFileId );
            }
        }
    }
}