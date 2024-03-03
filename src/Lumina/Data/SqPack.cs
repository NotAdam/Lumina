using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Lumina.Data.Attributes;
using Lumina.Data.Structs;

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
        public SqPackHeader SqPackHeader { get; private set; }

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

            using var sh = GetStreamHolder();
            SqPackHeader = sh.Stream.GetSqPackHeader();
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
            var cacheBehaviour = FileOptionsAttribute.FileCacheBehaviour.None;

            if( typeof( T ).GetCustomAttribute< FileOptionsAttribute >() is { } fileOpts )
                cacheBehaviour = fileOpts.CacheBehaviour;

            if( !_gameData.Options.CacheFileResources || cacheBehaviour == FileOptionsAttribute.FileCacheBehaviour.Never )
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
                : new( new SqPackStream( File, SqPackHeader.platformId ) );
    }
}