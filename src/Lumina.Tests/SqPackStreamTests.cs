using System;
using Lumina.Data;
using System.Linq;
using Xunit;

namespace Lumina.Tests;

public class SqPackStreamTests
{
    [RequiresGameInstallationFact]
    public void SeekedReadsMatchSequentialReads()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        string[] files = [
            "ui/icon/000000/000001.tex",
            "chara/equipment/e0000/model/c0101e0000_top.mdl",
            "bg/ffxiv/sea_s1/twn/s1t1/level/bg.lgb",
            "exd/root.exl",
        ];

        foreach( var file in files )
        {
            var stream = gameData.GetFile( file ).Reader.BaseStream;

            stream.Position = 0;
            var sequential = new byte[ stream.Length ];
            stream.ReadExactly( sequential );

            const int chunk = 997;
            var random = new Random( 1234 );
            var seeked = new byte[ stream.Length ];
            var chunks = Enumerable.Range( 0, (int)( ( stream.Length + chunk - 1 ) / chunk ) )
                .OrderBy( _ => random.Next() );

            foreach( var i in chunks )
            {
                var offset = (long)i * chunk;
                stream.Position = offset;
                stream.ReadExactly( seeked.AsSpan( (int)offset, (int)Math.Min( chunk, stream.Length - offset ) ) );
            }

            Assert.Equal( sequential, seeked );
        }
    }

    [RequiresGameInstallationFact]
    public void ProbingForMappedMemoryLeavesTheCursorAlone()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var stream = (SqPackStream)gameData.GetFile( "bg/ffxiv/sea_s1/twn/s1t1/level/bg.lgb" ).Reader.BaseStream;

        stream.Position = 40_000;
        var expected = new byte[512];
        stream.ReadExactly( expected );
        var resumed = stream.Position;

        stream.Position = 40_000;
        stream.ReadExactly( new byte[512] );
        stream.TryGetMappedMemory( 900_000, 256 );

        Assert.Equal( resumed, stream.Position );

        var afterProbe = new byte[512];
        stream.ReadExactly( afterProbe );

        stream.Position = resumed;
        var reference = new byte[512];
        stream.ReadExactly( reference );

        Assert.Equal( reference, afterProbe );
    }

    [RequiresGameInstallationFact]
    public void OpenFilesOutliveTheGameData()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var stream = gameData.GetFile( "exd/root.exl" ).Reader.BaseStream;

        stream.Position = 0;
        var expected = new byte[ stream.Length ];
        stream.ReadExactly( expected );

        gameData.Dispose();

        stream.Position = 0;
        var afterDispose = new byte[ stream.Length ];
        stream.ReadExactly( afterDispose );

        Assert.Equal( expected, afterDispose );
    }
}
