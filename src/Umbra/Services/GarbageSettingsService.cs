using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Umbra.Services
{
    public class UmbraSettings
    {
        public List< Models.GameClient > Clients { get; set; }
    }
    
    // todo: replace this with something not shit
    public class GarbageSettingsService
    {
        public static readonly string ConfigName = "UmbraSettings.json";

        public UmbraSettings Settings { get; private set; }
        
        public GarbageSettingsService()
        {
            ReloadSettings();
        }

        public void ReloadSettings()
        {
            try
            {
                var content = File.ReadAllText( ConfigName );
                Settings = JsonConvert.DeserializeObject< UmbraSettings >( content );
            }
            catch( Exception e )
            {
                Settings = new UmbraSettings();
            }
            
            // init shit so we don't npe
            Settings.Clients ??= new List< Models.GameClient >();
        }

        public void SaveSettings()
        {
            var content = JsonConvert.SerializeObject( Settings );
            File.WriteAllText( ConfigName, content );
        }
    }
}