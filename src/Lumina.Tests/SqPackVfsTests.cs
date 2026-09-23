using System.IO;
using System.Linq;
using Lumina.Data;
using Xunit;

namespace Lumina.Tests;

public class SqPackVfsTests
{
    [RequiresGameInstallationFact]
    public void EveryIndexFileOnDiskIsDiscovered()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        foreach( var repo in gameData.Repositories )
        {
            var onDisk = Directory.GetFiles( repo.Path.FullName )
                .Count( f => f.EndsWith( ".index2" ) || ( f.EndsWith( ".index" ) && !File.Exists( f + "2" ) ) );

            Assert.Equal( onDisk, repo.GetIndexFiles( PlatformType.Win32 ).Count() );
        }
    }

    [RequiresGameInstallationFact]
    public void FilesResolveInNonZeroChunks()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        Assert.True( gameData.ContainsFile( "bg/ex1/01_roc_r2/twn/r2t1/level/bg.lgb" ) );
        Assert.True( gameData.ContainsFile( "bg/ex2/02_est_e3/fld/e3f3/level/bg.lgb" ) );
    }
}
