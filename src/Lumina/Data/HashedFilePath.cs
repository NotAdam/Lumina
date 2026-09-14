using Lumina.Extensions;
using System;
using System.IO.Hashing;
using System.Text;
using static Lumina.Data.SqPackVfs;

namespace Lumina.Data;

/// <summary>
/// A game filesystem path, parsed into the parts needed to look it up, along with its hashes.
/// </summary>
/// <param name="ExpansionId">The expansion the file belongs to, where 0 is the base game.</param>
/// <param name="Category">The category the file belongs to.</param>
/// <param name="Hash">The v2 index hash of the file path.</param>
/// <param name="FolderSeparator">The index of the last <c>/</c> in <paramref name="Path"/>.</param>
/// <param name="Path">The path, lowercased and trimmed.</param>
public readonly record struct HashedFilePath(
    byte ExpansionId,
    CategoryType Category,
    uint Hash,
    int FolderSeparator,
    string Path )
{
    internal SqPackKey PackKey => new( ExpansionId, Category );

    /// <summary>
    /// The repository the file belongs to, e.g. <c>ffxiv</c>, <c>ex1</c>, <c>ex2</c>.
    /// </summary>
    public string Repository => ExpansionId == 0 ? "ffxiv" : $"ex{ExpansionId}";

    /// <summary>
    /// The v1 index hash of the file path.
    /// </summary>
    /// <remarks>
    /// This is the same hash that's used for resolving RSFs.
    /// </remarks>
    public ulong OldHash => (ulong)FolderHash << 32 | FileHash;

    /// <summary>
    /// The portion of <see cref="OldHash"/> that represents the folder.
    /// </summary>
    public uint FolderHash {
        get {
            Span< byte > pathBytes = stackalloc byte[240];
            var folderData = pathBytes[ ..Encoding.UTF8.GetBytes( Path.AsSpan( ..FolderSeparator ), pathBytes ) ];
            return ~Crc32.HashToUInt32( folderData );
        }
    }

    /// <summary>
    /// The portion of <see cref="OldHash"/> that represents the filename.
    /// </summary>
    public uint FileHash {
        get {
            Span< byte > pathBytes = stackalloc byte[240];
            var fileData = pathBytes[ ..Encoding.UTF8.GetBytes( Path.AsSpan( ( FolderSeparator + 1 ).. ), pathBytes ) ];
            return ~Crc32.HashToUInt32( fileData );
        }
    }

    /// <summary>
    /// Parses a game filesystem path, extracting the parts needed to look it up.
    /// </summary>
    /// <param name="path">A game filesystem path.</param>
    /// <returns>The parsed path.</returns>
    /// <exception cref="ArgumentException">Thrown when the path is empty or ends with a <c>/</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the path is too long or has no folder.</exception>
    public static HashedFilePath Create( string path )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace( path );
        if( path[ ^1 ] == '/' )
        {
            throw new ArgumentException( "Path cannot end with a '/'", nameof( path ) );
        }

        var trimmed = path.AsSpan().Trim();

        if( trimmed.Length > 240 )
            throw new ArgumentOutOfRangeException( nameof( path ), "Path is too long" );

        // lowercasing into a stack buffer = alloc-free
        Span< char > buffer = stackalloc char[240];
        var lowered = buffer[ ..trimmed.ToLowerInvariant( buffer ) ];

        var splitOne = lowered.IndexOf( '/' );
        ArgumentOutOfRangeException.ThrowIfNegative( splitOne, nameof( path ) );

        var categoryType = CategoryExtensions.GetCategoryType( lowered[ ..splitOne ] );

        // only an "exN" is a repository; anything else is a folder inside ffxiv
        byte expansionId = 0;
        var splitTwo = lowered[ ( splitOne + 1 ).. ].IndexOf( '/' );
        if( splitTwo != -1 )
        {
            var segment = lowered.Slice( splitOne + 1, splitTwo );
            if( segment.StartsWith( "ex" ) )
                _ = byte.TryParse( segment[ 2.. ], out expansionId );
        }

        Span< byte > pathBytes = stackalloc byte[240];
        var pathData = pathBytes[ ..Encoding.UTF8.GetBytes( lowered, pathBytes ) ];
        var hash = ~Crc32.HashToUInt32( pathData );

        var storedPath = lowered.SequenceEqual( path ) ? path : lowered.ToString();

        return new( expansionId, categoryType, hash, lowered.LastIndexOf( '/' ), storedPath );
    }
}
