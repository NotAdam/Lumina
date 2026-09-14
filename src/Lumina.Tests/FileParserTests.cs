using System;
using System.Linq;
using Lumina.Data.Files;
using Xunit;

namespace Lumina.Tests;

public class FileParserTests
{
    [RequiresGameInstallationFact]
    public void SkeletonsParseAcrossHeaderVersions()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        var versions = new System.Collections.Generic.HashSet< SklbFile.SklbVersion >();
        var parsed = 0;

        for( var i = 1; i <= 300; i++ )
        {
            var path = $"chara/monster/m{i:D4}/skeleton/base/b0001/skl_m{i:D4}b0001.sklb";
            if( !gameData.ContainsFile( path ) )
                continue;

            var file = gameData.GetFile< SklbFile >( path )!;
            versions.Add( file.Version );
            Assert.NotEmpty( file.Skeleton );
            parsed++;
        }

        Assert.NotEqual( 0, parsed );
        Assert.True( versions.Count > 1 );
    }

    [RequiresGameInstallationFact]
    public void BoneDeformerNamesAreRealBones()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var file = gameData.GetFile< PbdFile >( "chara/xls/boneDeformer/human.pbd" )!;

        Assert.NotEmpty( file.Deformers );
        Assert.Equal( file.Deformers.Length, file.Nodes.Length );

        var deformer = file.Deformers.First( d => d.BoneMatrices.Length > 0 );
        Assert.Contains( "n_root", deformer.BoneNames );
        Assert.Contains( "n_hara", deformer.BoneNames );
        Assert.Contains( "j_kosi", deformer.BoneNames );

        foreach( var d in file.Deformers )
        {
            Assert.Equal( d.BoneNames.Length, d.BoneMatrices.Length );
            foreach( var name in d.BoneNames )
                Assert.All( name, c => Assert.InRange( c, (char)0x20, (char)0x7E ) );
        }
    }

    [RequiresGameInstallationFact]
    public void ShaderPackageHeaderIsSelfConsistent()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();
        var file = gameData.GetFile< ShpkFile >( "shader/sm5/shpk/character.shpk" )!;

        Assert.Equal( file.Reader.BaseStream.Length, file.TotalSize );
        Assert.Equal( "DX11", file.DirectXVersion );
        Assert.True( file.BlobsOffset <= file.StringsOffset );
        Assert.True( file.StringsOffset <= file.TotalSize );
        Assert.NotEqual( 0u, file.VertexShaderCount );
        Assert.NotEqual( 0u, file.PixelShaderCount );
    }

    [RequiresGameInstallationFact]
    public void FilesParseFromLooseBytes()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        var stream = gameData.Vfs.GetFileStream( "chara/xls/boneDeformer/human.pbd" );
        var bytes = new byte[stream.Length];
        stream.ReadExactly( bytes );

        var fromBytes = Lumina.Data.FileResource.FromBytes< PbdFile >( bytes );
        var fromGameData = gameData.GetFile< PbdFile >( "chara/xls/boneDeformer/human.pbd" )!;

        Assert.Equal( fromGameData.Deformers.Length, fromBytes.Deformers.Length );
        Assert.Equal( fromGameData.Deformers[ 1 ].BoneNames, fromBytes.Deformers[ 1 ].BoneNames );
    }
}
