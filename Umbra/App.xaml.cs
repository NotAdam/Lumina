using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Lumina;

namespace Umbra
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public readonly LuminaOptions LuminaOptions;
        
        public Lumina.Lumina Lumina { get; private set; }
        
        public App()
        {
            LuminaOptions = new LuminaOptions
            {
                CacheFileResources = false
            };
        }

        private void App_OnStartup( object sender, StartupEventArgs e )
        {
            var args = Environment.GetCommandLineArgs();

            string dataPath = null;
            if( args.Length > 1 )
            {
                dataPath = args[ 1 ];
            }

            if( dataPath == null )
            {
                MessageBox.Show( "No datapath provided! pls set one", "fuck", MessageBoxButton.OK, MessageBoxImage.Error );
                return;
            }
            
            Lumina = new Lumina.Lumina( dataPath );
        }
    }
}