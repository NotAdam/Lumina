using System;
using System.Collections.Generic;
using System.Text;

namespace Umbra.UI.Services
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
            path = path.ToLowerInvariant();

            if( _instances.TryGetValue( path, out var instance ) )
            {
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

            _instances[ path ] = newInstance;

            return newInstance;
        }
    }
}