using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class SqPackInflateException : Exception
    {
        public SqPackInflateException( string message ) : base( message )
        {
        }
    }

    public class SqPack
    {
        private readonly Lumina _lumina;

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

        public SqPackHeader SqPackHeader { get; private set; }

        /// <summary>
        /// PC and PS4 are LE, PS3 is BE
        /// </summary>
        public bool ShouldConvertEndianness
        {
            // todo: what about reading LE files on BE device? do we even care?
            get => BitConverter.IsLittleEndian && SqPackHeader.platformId == PlatformId.PS3 ||
                   !BitConverter.IsLittleEndian && SqPackHeader.platformId != PlatformId.PS3;
        }

        protected readonly Dictionary< long, WeakReference< FileResource > > FileCache;
        
        protected readonly object CacheLock = new object();

        internal SqPack( FileInfo file, Lumina lumina )
        {
            if( file == null )
            {
                throw new ArgumentNullException( nameof( file ) );
            }
            
            if( !file.Exists )
            {
                throw new FileNotFoundException( $"SqPack file {file.FullName} could not be found." );
            }

            _lumina = lumina;

            // always init the cache just in case the should cache setting is changed later
            FileCache = new Dictionary< long, WeakReference< FileResource > >();

            File = file;

            using var ss = new SqPackStream( File );

            SqPackHeader = ss.GetSqPackHeader();
        }

        protected T? GetCachedFile< T >( long offset ) where T : FileResource
        {
            if( !FileCache.TryGetValue( offset, out var weakRef ) )
            {
                return null;
            }

            if( !weakRef.TryGetTarget( out var cachedFile ) )
            {
                return null;
            }

            // only return from cache if target type matches
            // otherwise we'll force a cache miss and parse it as per usual
            if( cachedFile is T obj )
                return obj;

            return null;
        }

        public SqPackFileInfo GetFileMetadata( long offset )
        {
            using var ss = new SqPackStream( File );

            return ss.GetFileMetadata( offset );
        }

        public T ReadFile< T >( long offset ) where T : FileResource
        {
            if( !_lumina.Options.CacheFileResources )
            {
                using var ss = new SqPackStream( File );
                return ss.ReadFile<T>( offset );
            }
            
            
            lock( CacheLock )
            {
                var obj = GetCachedFile< T >( offset );

                if( obj != null )
                {
                    return obj;
                }

                using var ss = new SqPackStream( File );
                var file = ss.ReadFile< T >( offset );
                
                FileCache[ offset ] = new WeakReference< FileResource >( file );

                return file;
            }
        }
    }
}