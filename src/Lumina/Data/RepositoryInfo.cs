using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lumina.Extensions;

namespace Lumina.Data;

public sealed class RepositoryInfo
{
    public DirectoryInfo Path { get; }

    public string Name { get; }

    public byte ExpansionId { get; }

    private string? Version { get; set; }

    public RepositoryInfo( DirectoryInfo path )
    {
        if( !path.Exists )
            throw new DirectoryNotFoundException( $"Directory not found: {path.FullName}" );

        Path = path;

        Name = Path.Name;
        if( Name.StartsWith( "ex" ) )
        {
            if( !byte.TryParse( Name[2..], out var expansionId ) )
                throw new FormatException( $"Invalid repository directory name: {Name}" );

            ExpansionId = expansionId;
        }
        else if( Name == "ffxiv" )
            ExpansionId = 0;
        else
            throw new FormatException( $"Invalid repository directory name: {Name}" );
    }

    public async Task<string?> GetVersionAsync()
    {
        if( Version is { } version )
            return version;

        string? versionFile = null;
        if( ExpansionId == 0 )
        {
            if( Path.Parent?.Parent?.FullName is { } gamePath )
                versionFile = System.IO.Path.Combine( gamePath, "ffxivgame.ver" );
        }
        else
            versionFile = System.IO.Path.Combine( Path.FullName, $"{Name}.ver" );

        if( versionFile == null || !File.Exists( versionFile ) )
            return Version = null;

        return Version = await File.ReadAllTextAsync( versionFile ).ConfigureAwait( false );
    }

    public readonly record struct IndexFileInfo( FileInfo File, byte ExpansionId, byte ChunkIndex, CategoryType Category );

    public IEnumerable<IndexFileInfo> GetIndexFiles( PlatformType platform )
    {
        var files = Path.GetFiles( "*", new EnumerationOptions() ).ToDictionary( f => f.Name, f => f );
        var categories = (byte[])Enum.GetValuesAsUnderlyingType<CategoryType>();
        foreach( var cat in categories )
        {
            for( var chunkIdx = 0; chunkIdx < 256; ++chunkIdx )
            {
                var baseName = $"{cat:x02}{ExpansionId:x02}{chunkIdx:x02}.{platform.GetName()}";

                foreach( var idx in new[] { "index2", "index" } )
                {
                    if( files.TryGetValue( $"{baseName}.{idx}", out var file ) )
                    {
                        yield return new( file, ExpansionId, (byte)chunkIdx, (CategoryType)cat );
                        break;
                    }
                }
            }
        }
    }
}
