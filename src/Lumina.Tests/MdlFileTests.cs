using System;
using System.Collections.Generic;
using Lumina.Data.Files;
using Xunit;

namespace Lumina.Tests;

public class MdlFileTests
{
    private static List< string > FindModels( GameData gameData, int count )
    {
        var paths = new List< string >();
        for( var i = 1; i <= 3000 && paths.Count < count; i++ )
        {
            var path = $"chara/monster/m{i:D4}/obj/body/b0001/model/m{i:D4}b0001.mdl";
            if( gameData.ContainsFile( path ) )
                paths.Add( path );
        }

        return paths;
    }

    // shipped models have been v6 since Endwalker
    [RequiresGameInstallationFact]
    public void ShippedModelsParse()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var paths = FindModels( gameData, 100 );

        Assert.NotEmpty( paths );
        foreach( var path in paths )
            Assert.NotNull( gameData.GetFile< MdlFile >( path ) );
    }

    [RequiresGameInstallationFact]
    public void BoneTablesResolveWithinTheBoneNameTable()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var tables = 0;

        foreach( var path in FindModels( gameData, 100 ) )
        {
            var file = gameData.GetFile< MdlFile >( path )!;
            for( var i = 0; i < file.ModelHeader.BoneTableCount; i++ )
            {
                var table = file.GetBoneTable( i );
                Assert.NotEmpty( table.ToArray() );
                foreach( var bone in table )
                    Assert.True( bone < file.ModelHeader.BoneCount );
                tables++;
            }
        }

        Assert.NotEqual( 0, tables );
    }

    [RequiresGameInstallationFact]
    public void BoneTableSpansMatchSeekBasedOffsets()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        foreach( var path in FindModels( gameData, 50 ) )
        {
            var file = gameData.GetFile< MdlFile >( path )!;
            if( file.BoneTableSpans.Length == 0 )
                continue;

            for( var i = 0; i < file.BoneTableSpans.Length; i++ )
            {
                var span = file.BoneTableSpans[ i ];
                var start = ( i * 4 + span.Offset * 4 - file.BoneTableSpans.Length * 4 ) / 2;

                Assert.Equal(
                    file.BoneTableIndices.AsSpan( start, span.Size ).ToArray(),
                    file.GetBoneTable( i ).ToArray() );
            }
        }
    }
}
