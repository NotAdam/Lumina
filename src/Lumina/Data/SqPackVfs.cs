using DotNext.Collections.Generic;
using Lumina.Data.Structs.SqPack;
using Lumina.Extensions;
using Lumina.Misc;
using System;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Lumina.Data.RepositoryInfo;

namespace Lumina.Data;

public sealed class SqPackVfs( GameData gameData ) : IDisposable
{
    public GameData GameData { get; } = gameData;

    public DirectoryInfo Path => GameData.DataPath;

    public delegate bool ResolveRsfDelegate( ulong indexHash, out ReadOnlyMemory< byte > resolvedData );

    // (Expansion, Category) + Hash -> DataFile, ChunkIdx, Offset
    private FrozenDictionary< int, HashLookup< SqPackValue > >? HashTable { get; set; }
    private FrozenDictionary< string, SqPackValue >? CollisionTable { get; set; }

    private ConcurrentDictionary< (SqPackKey Key, byte ChunkIdx, byte DatFile), MappedFile > OpenedFiles { get; } =
        [];

    public List< RepositoryInfo > Repositories { get; } = [];

    public async Task Initialize()
    {
        var sw = Stopwatch.StartNew();

        var tasks = Path.GetDirectories().Select( AddRepository ).ToList();

        var hashTable = new Dictionary< int, HashLookup< SqPackValue > >();
        var synonymData = new List< Dictionary< string, SqPackValue > >();
        while( tasks.Count != 0 )
        {
            var finishedTask = await Task.WhenAny( tasks ).ConfigureAwait( false );
            tasks.Remove( finishedTask );
            var (expansionId, hashTables, synonyms) = finishedTask.Result;

            foreach( var (category, table) in hashTables )
                hashTable.Add( (int)new SqPackKey( expansionId, category ), table );
            synonymData.AddRange( synonyms );
        }

        HashTable = hashTable.ToFrozenDictionary();
        CollisionTable = synonymData.SelectMany( x => x ).ToFrozenDictionary();

        sw.Stop();
        GameData.Options.Logger?.Information(
            $"Initialized {Repositories.Count} repositories in {sw.Elapsed.TotalMilliseconds:0.00}ms" );
    }

    private readonly record struct RepositoryData(
        byte ExpansionId,
        Dictionary< CategoryType, HashLookup< SqPackValue > > HashTables,
        List< Dictionary< string, SqPackValue > > Synonyms );

    private async Task< RepositoryData > AddRepository( DirectoryInfo repositoryPath )
    {
        var repo = new RepositoryInfo( repositoryPath );
        Repositories.Add( repo );

        var hashTable = new Dictionary< CategoryType, Dictionary< uint, SqPackValue > >();
        var synonymData = new List< Dictionary< string, SqPackValue > >();

        var bigEndian = GameData.Options.CurrentPlatform == PlatformType.PS3;
        var indexFiles = repo.GetIndexFiles( GameData.Options.CurrentPlatform ).ToList();
        var capacities = new Dictionary< CategoryType, int >();
        foreach( var indexFile in indexFiles )
            capacities[ indexFile.Category ] = capacities.GetValueOrDefault( indexFile.Category )
                                               + checked( (int)( indexFile.File.Length /
                                                                 Unsafe.SizeOf< SqPackIndexTablePair< uint > >() ) );

        var taskOrder = new Dictionary< CategoryType, Task< IndexData > >();
        foreach( var indexFile in indexFiles )
        {
            var key = indexFile.Category;
            if( !hashTable.TryGetValue( key, out var dict ) )
                hashTable[ key ] = dict = new( capacities[ key ] );
            if( taskOrder.TryGetValue( key, out var dependentTask ) )
                taskOrder[ key ] = dependentTask.ContinueWith(
                    t => {
                        t.GetAwaiter().GetResult();
                        return Task.Run( () => AddIndex( indexFile, dict, bigEndian ) );
                    },
                    TaskContinuationOptions.ExecuteSynchronously ).Unwrap();
            else
                taskOrder[ key ] = Task.Run( () => AddIndex( indexFile, dict, bigEndian ) );
        }

        var tasks = taskOrder.Values.ToList();

        while( tasks.Count != 0 )
        {
            var finishedTask = await Task.WhenAny( tasks ).ConfigureAwait( false );
            tasks.Remove( finishedTask );
            var (_, synonyms, _) = await finishedTask.ConfigureAwait( false );

            if( synonyms.Count != 0 )
                synonymData.Add( synonyms );
        }

        return new( repo.ExpansionId, hashTable.ToDictionary( x => x.Key, x => Build( x.Value ) ),
            synonymData );
    }

    private static HashLookup< SqPackValue > Build( Dictionary< uint, SqPackValue > entries )
    {
        var keys = GC.AllocateUninitializedArray< uint >( entries.Count );
        var values = GC.AllocateUninitializedArray< SqPackValue >( entries.Count );
        var i = 0;
        foreach( var (hash, value) in entries )
        {
            keys[ i ] = hash;
            values[ i ] = value;
            i++;
        }

        return new( keys, values );
    }

    private readonly record struct IndexData(
        Dictionary< uint, SqPackValue > Entries,
        Dictionary< string, SqPackValue > Synonyms,
        IndexFileInfo IndexFile );

    private static IndexData AddIndex( IndexFileInfo indexFile, Dictionary< uint, SqPackValue > entryTable,
        bool bigEndian )
    {
        using var index = new MappedFile( indexFile.File );
        index.Prefetch( 0, index.Size );

        var fileHeader = index.GetAt< SqPackHeader >( 0 );
        if( bigEndian )
            fileHeader = fileHeader.ReverseEndianness();

        var header = index.GetAt< SqPackIndexHeader >( fileHeader.Size );
        if( bigEndian )
            header = header.ReverseEndianness();

        // It can be added trivially, but there's no reason to do so since index2 already exists everywhere.
        if( header.IndexType == 0 )
        {
            var entries =
                index.GetByteSpanAt< SqPackIndexTablePair< ulong > >( header.IndexData.Offset, header.IndexData.Size );
            throw new NotSupportedException( "Index type 0 is not supported." );
        }
        else if( header.IndexType == 2 )
        {
            var entries =
                index.GetByteSpanAt< SqPackIndexTablePair< uint > >( header.IndexData.Offset, header.IndexData.Size );
            foreach( var entry in entries.Span )
            {
                // swapping here keeps the table and lookups endianness agnostic
                var hash = bigEndian ? BinaryPrimitives.ReverseEndianness( entry.Hash ) : entry.Hash;
                var data = bigEndian
                    ? new SqPackIndexTableEntry { Data = BinaryPrimitives.ReverseEndianness( entry.Data.Data ) }
                    : entry.Data;
                entryTable.TryAdd( hash, new( data, indexFile.ChunkIndex ) );
            }

            var synonyms =
                index.GetByteSpanAt< SqPackIndexSynonymEntry< uint > >( header.SynonymData.Offset,
                    header.SynonymData.Size );
            var synonymTable = new Dictionary< string, SqPackValue >( synonyms.Length );
            foreach( var entry in synonyms.Span )
            {
                var synonymHash = bigEndian ? BinaryPrimitives.ReverseEndianness( entry.Hash ) : entry.Hash;
                if( synonymHash == uint.MaxValue )
                    break;

                entryTable.Remove( synonymHash );

                var path = entry.Path;
                if( string.IsNullOrWhiteSpace( path ) )
                    throw new InvalidDataException( "Synonym entry has no path." );

                synonymTable.Add( path, new( bigEndian
                    ? new SqPackIndexTableEntry { Data = BinaryPrimitives.ReverseEndianness( entry.Data.Data ) }
                    : entry.Data, indexFile.ChunkIndex ) );
            }

            return new( entryTable, synonymTable, indexFile );
        }
        else
            throw new InvalidDataException( $"Unknown index type: {header.IndexType}" );
    }

    internal readonly record struct SqPackKey( byte ExpansionId, CategoryType Category )
    {
        public SqPackKey( IndexFileInfo indexFile ) :
            this(
                indexFile.ExpansionId,
                indexFile.Category
            )
        {
        }

        public static explicit operator int( SqPackKey key ) =>
            ( key.ExpansionId << 8 ) | (byte)key.Category;

        public static explicit operator SqPackKey( int key ) =>
            new( (byte)( key >> 8 ), (CategoryType)( key & 0xFF ) );
    }

    private readonly record struct SqPackValue( SqPackIndexTableEntry Data, byte ChunkIdx );

    private MappedFile GetMappedFile( SqPackKey key, byte chunkIdx, byte datFile )
    {
        var cacheKey = ( key, chunkIdx, datFile );
        if( OpenedFiles.TryGetValue( cacheKey, out var opened ) )
            return opened;

        var directory = Repositories.First( x => x.ExpansionId == key.ExpansionId ).Path;
        var baseName =
            $"{(byte)key.Category:x02}{key.ExpansionId:x02}{chunkIdx:x02}.{GameData.Options.CurrentPlatform.GetName()}.dat{datFile}";
        var created = new MappedFile( System.IO.Path.Combine( directory.FullName, baseName ) );

        if( OpenedFiles.TryAdd( cacheKey, created ) )
            return created;

        created.Dispose();
        return OpenedFiles[ cacheKey ];
    }

    public bool ContainsFile( string path ) =>
        ContainsFile( HashedFilePath.Create( path ), path );

    public bool ContainsFile( in HashedFilePath hashedPath, string path )
    {
        if( HashTable is not { } hashTable || CollisionTable is not { } collisionTable )
            throw new InvalidOperationException( "VFS is not initialized." );

        if( hashTable.TryGetValue( (int)hashedPath.PackKey, out var entries ) )
        {
            if( entries.ContainsKey( hashedPath.Hash ) )
                return true;
        }

        return collisionTable.ContainsKey( path );
    }

    private SqPackValue? TryGetFileInfo( in HashedFilePath hashedPath, string path )
    {
        if( HashTable is not { } hashTable || CollisionTable is not { } collisionTable )
            throw new InvalidOperationException( "VFS is not initialized." );

        if( hashTable.TryGetValue( (int)hashedPath.PackKey, out var entries ) )
        {
            if( entries.TryGetValue( hashedPath.Hash, out var entry ) )
                return entry;
        }

        if( collisionTable.TryGetValue( path, out var collisionEntry ) )
            return collisionEntry;

        return null;
    }

    public SqPackStream? TryGetFileStream( string path ) =>
        TryGetFileStream( HashedFilePath.Create( path ), path );

    public SqPackStream? TryGetFileStream( in HashedFilePath hashedPath, string path )
    {
        if( TryGetFileInfo( in hashedPath, path ) is not { } value )
            return null;

        var file = GetMappedFile( hashedPath.PackKey, value.ChunkIdx, value.Data.DataFileIdx );
        return SqPackStream.Create( file, value.Data.Offset, GameData, in hashedPath );
    }

    public SqPackStream GetFileStream( string path ) =>
        GetFileStream( HashedFilePath.Create( path ), path );

    public SqPackStream GetFileStream( in HashedFilePath hashedPath, string path )
    {
        if( TryGetFileInfo( in hashedPath, path ) is not { } value )
            throw new FileNotFoundException( "File not found", path );

        var file = GetMappedFile( hashedPath.PackKey, value.ChunkIdx, value.Data.DataFileIdx );
        return SqPackStream.Create( file, value.Data.Offset, GameData, in hashedPath );
    }

    public void Dispose()
    {
        OpenedFiles.ForEach( f => f.Value.Dispose() );
        OpenedFiles.Clear();
    }
}
