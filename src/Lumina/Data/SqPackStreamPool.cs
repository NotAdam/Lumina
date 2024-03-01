using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Extensions.ObjectPool;

namespace Lumina.Data;

/// <summary>A stream pool for use with <see cref="GameData.StreamPool"/>.</summary>
/// <remarks>
/// As creating a handle for a file on the filesystem takes much longer than seeking an already opened handle, reusing handles will help with the overall
/// performance, both single-threaded and multi-threaded.
/// </remarks>
public sealed class SqPackStreamPool : IDisposable
{
    private readonly ObjectPoolProvider _objectPoolProvider;
    private ConcurrentDictionary< SqPack, ObjectPool< SqPackStream > >? _pools = new();

    /// <summary>Initializes a new instance of <see cref="SqPackStreamPool"/> class.</summary>
    /// <param name="maximumRetained">The maximum number of streams to retain in the pool per file. If a non-positive number is given, the default value of
    /// <see cref="DefaultObjectPoolProvider"/> will be used.</param>
    public SqPackStreamPool( int maximumRetained = 0 )
    {
        var dopp = new DefaultObjectPoolProvider();
        if( maximumRetained > 0 )
            dopp.MaximumRetained = maximumRetained;
        _objectPoolProvider = dopp;
    }

    /// <summary>Initializes a new instance of <see cref="SqPackStreamPool"/> class.</summary>
    /// <param name="objectPoolProvider">The object pool provider to use.</param>
    public SqPackStreamPool( ObjectPoolProvider objectPoolProvider ) => _objectPoolProvider = objectPoolProvider;

    /// <inheritdoc/>
    public void Dispose()
    {
        if( Interlocked.Exchange( ref _pools, null ) is not { } pools )
            return;

        foreach( var pool in pools.Values )
            ( pool as IDisposable )?.Dispose();
        pools.Clear();
    }

    /// <summary>Rents a stream from the pool.</summary>
    /// <param name="dat">An instance of <see cref="SqPack"/> to get the stream of.</param>
    /// <returns>The rented stream.</returns>
    /// <remarks>If this pool has been disposed, a new instance of <see cref="SqPackStream"/> will be created instead.</remarks>
    internal StreamHolder RentScoped( SqPack dat )
    {
        if( _pools is not { } pools )
            return new( new SqPackStream( dat.File, dat.SqPackHeader.platformId ) );

        var pool = pools.GetOrAdd(
            dat,
            static ( key, owner ) => owner._objectPoolProvider.Create( new SqPackStreamObjectPoolProvider( owner, key ) ),
            this );
        return new( pool );
    }

    /// <summary>A struct facilitating the scoped borrowing from a pool.</summary>
    /// <remarks>Multithreaded usage is not supported.</remarks>
    internal struct StreamHolder : IDisposable
    {
        private readonly ObjectPool< SqPackStream >? _pool;
        private SqPackStream? _stream;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public StreamHolder( ObjectPool< SqPackStream > pool )
        {
            _pool = pool;
            _stream = pool.Get();
        }

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public StreamHolder( SqPackStream stream ) => _stream = stream;

        public SqPackStream Stream {
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            get => _stream ?? throw new ObjectDisposedException( nameof( StreamHolder ) );
        }

        public void Dispose()
        {
            if( _stream is null )
                return;
            if( _pool is null )
                _stream.Dispose();
            else
                _pool.Return( _stream );
            _stream = null;
        }
    }

    private class SqPackStreamObjectPoolProvider : IPooledObjectPolicy< SqPackStream >
    {
        private readonly SqPackStreamPool _owner;
        private readonly SqPack _sqpack;

        public SqPackStreamObjectPoolProvider( SqPackStreamPool owner, SqPack sqpack )
        {
            _owner = owner;
            _sqpack = sqpack;
        }

        public SqPackStream Create() => new( _sqpack.File, _sqpack.SqPackHeader.platformId );

        public bool Return( SqPackStream obj ) => _owner._pools is not null && obj.BaseStream.CanRead;
    }
}