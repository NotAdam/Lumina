using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Lumina.Data.Attributes;
using Lumina.Data.Structs;
using Microsoft.Win32.SafeHandles;

namespace Lumina.Data
{
    public class SqPackInflateException : Exception
    {
        public SqPackInflateException( string message ) : base( message )
        { }
    }

    /// <summary>Represents a .dat file of a sqpack file group.</summary>
    public class SqPack
    {
        private readonly GameData _gameData;
        private readonly ConcurrentDictionary< long, WeakReference< FileResource > > _cache;
        private readonly object _handleLock = new();
        private SafeFileHandle? _handle;
        private long _length;

        /// <summary>
        /// Where the actual file is located on disk
        /// </summary>
        public FileInfo File { get; }

        /// <summary>
        /// Returns the name of the SqPack file
        /// </summary>
        public string Name => File.Name;

        /// <summary>
        /// Returns the full path to the SqPack file
        /// </summary>
        public string FullName => File.FullName;

        /// <summary>
        /// Gets the file header of this SqPack file.
        /// </summary>
        public SqPackHeader SqPackHeader { get; }

        /// <summary>
        /// PC and PS4 are LE, PS3 is BE
        /// </summary>
        [Obsolete( "Use property \"ConvertEndianness\" from \"LuminaBinaryReader\" instead" )]
        public bool ShouldConvertEndianness {
            // todo: what about reading LE files on BE device? do we even care?
            get => BitConverter.IsLittleEndian && SqPackHeader.platformId == PlatformId.PS3 ||
                !BitConverter.IsLittleEndian && SqPackHeader.platformId != PlatformId.PS3;
        }

        /// <summary>Unused field.</summary>
        [Obsolete( "Not used." )] protected readonly Dictionary< long, WeakReference< FileResource > > FileCache = new();

        /// <summary>Unused field.</summary>
        [Obsolete( "Not used." )] protected readonly object CacheLock = new();

        internal SqPack( FileInfo file, GameData gameData )
        {
            if( !file.Exists )
            {
                throw new FileNotFoundException( $"SqPack file {file.FullName} could not be found." );
            }

            _gameData = gameData;

            // always init the cache just in case the should cache setting is changed later
            _cache = new();

            File = file;

            try
            {
                // todo: platform is read from header so should probably clean this up, but w/e for now
                using var stream = new SqPackStream( OpenSharedStream(), PlatformId.Win32 );
                SqPackHeader = stream.GetSqPackHeader();
            }
            catch
            {
                CloseHandle();
                throw;
            }
        }

        /// <summary>Opens a stream over the file handle shared by all readers of this file.</summary>
        /// <remarks>Disposing the stream does not close the shared handle.</remarks>
        internal SharedHandleStream OpenSharedStream()
        {
            var handle = Volatile.Read( ref _handle );
            if( handle is null || handle.IsClosed )
            {
                lock( _handleLock )
                {
                    handle = _handle;
                    if( handle is null || handle.IsClosed )
                    {
                        handle = System.IO.File.OpenHandle( File.FullName, FileMode.Open, FileAccess.Read,
                            FileShare.ReadWrite | FileShare.Delete, FileOptions.RandomAccess );
                        _length = RandomAccess.GetLength( handle );
                        Volatile.Write( ref _handle, handle );
                    }
                }
            }

            return new( handle, _length );
        }

        /// <summary>Closes the shared file handle. It is reopened on the next read.</summary>
        internal void CloseHandle()
        {
            lock( _handleLock )
            {
                _handle?.Dispose();
                _handle = null;
            }
        }

        /// <summary>Gets the file metadata of a file at the given offset.</summary>
        /// <param name="offset">The byte offset of a file in this SqPack .dat file.</param>
        /// <returns>The corresponding file metadata.</returns>
        /// <remarks>No verification is performed on whether <paramref name="offset"/> points to a valid file metadata.</remarks>
        public SqPackFileInfo GetFileMetadata( long offset )
        {
            using var sh = GetStreamHolder();
            return sh.Stream.GetFileMetadata( offset );
        }

        /// <summary>Reads the file at the given offset.</summary>
        /// <param name="offset">The byte offset of a file in this SqPack .dat file.</param>
        /// <typeparam name="T">The file resource type.</typeparam>
        /// <returns>The corresponding file resource.</returns>
        public T ReadFile< T >( long offset ) where T : FileResource
        {
            if( !_gameData.Options.CacheFileResources || CacheOptions< T >.Behaviour == FileOptionsAttribute.FileCacheBehaviour.Never )
            {
                using var rsh = GetStreamHolder();
                return rsh.Stream.ReadFile< T >( offset );
            }

            // WeakReference ctor accepts null.
            var weakRef = _cache.GetOrAdd( offset, static _ => new( null! ) );
            if( weakRef.TryGetTarget( out var valueUntyped ) && valueUntyped is T value )
                return value;

            lock( weakRef )
            {
                if( weakRef.TryGetTarget( out valueUntyped ) && valueUntyped is T value2 )
                    return value2;

                using var sh = GetStreamHolder();
                var f = sh.Stream.ReadFile< T >( offset );
                weakRef.SetTarget( f );
                return f;
            }
        }

        /// <summary>Gets the file, if the cached instance of <see cref="FileResource"/> can be cast as <typeparamref name="T"/>.</summary>
        /// <param name="offset">The byte offset of a file in this SqPack .dat file.</param>
        /// <typeparam name="T">The file resource type.</typeparam>
        /// <returns>The corresponding file resource, or <c>null</c> if the file was not cached.</returns>
        protected T? GetCachedFile< T >( long offset ) where T : FileResource =>
            _cache.TryGetValue( offset, out var cached ) && cached.TryGetTarget( out var valueUntyped ) ? valueUntyped as T : null;

        /// <summary>Rents a stream from the pool if stream pooling is enabled, or creates a new stream.</summary>
        /// <returns>A stream holder that will either return the stream to the pool or close the stream.</returns>
        private SqPackStreamPool.StreamHolder GetStreamHolder() =>
            _gameData.StreamPool is { } streamPool
                ? streamPool.RentScoped( this )
                : new( CreateStream() );

        /// <summary>Create a stream to read this file, using the shared file handle</summary>
        internal SqPackStream CreateStream() => new( OpenSharedStream(), SqPackHeader.platformId );

        /// <summary>Per-type cache of <see cref="FileOptionsAttribute"/>, avoiding a reflection lookup on every read.</summary>
        private static class CacheOptions< T > where T : FileResource
        {
            public static readonly FileOptionsAttribute.FileCacheBehaviour Behaviour =
                typeof( T ).GetCustomAttribute< FileOptionsAttribute >()?.CacheBehaviour ?? FileOptionsAttribute.FileCacheBehaviour.None;
        }
    }
}