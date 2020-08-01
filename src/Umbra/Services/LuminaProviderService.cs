using System;
using System.Collections.Generic;
using System.Text;
using Serilog;
using Splat;

namespace Umbra.Services
{
    public class LuminaProviderService
    {
        private readonly Dictionary< string, Lumina.Lumina > _instances;

        public LuminaProviderService()
        {
            _instances = new Dictionary< string, Lumina.Lumina >();
        }

        public Lumina.Lumina GetInstance( string path )
        {
            var key = path.ToLowerInvariant();

            if( _instances.TryGetValue( key, out var instance ) )
            {
                Log.Verbose( "found existing lumina instance for path: {GamePath}", key );
                return instance;
            }

            Lumina.Lumina newInstance;

            try
            {
                newInstance = new Lumina.Lumina( path, new Lumina.LuminaOptions
                {
                    CacheFileResources = false
                } );
            }
            catch( Exception )
            {
                return null;
            }

            Log.Verbose( "created new lumina instance for path: {GamePath}", key );
            _instances[ key ] = newInstance;

            return newInstance;
        }
    }
}