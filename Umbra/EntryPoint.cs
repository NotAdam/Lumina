using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Config.Net;
using Lumina;
using Microsoft.Win32;
using ReactiveUI;
using Serilog;
using Serilog.Core;
using Splat;
using Splat.Serilog;

namespace Umbra
{
    public static class EntryPoint
    {
        [STAThread]
        public static void Main( string[] args )
        {
            var appDataPath = Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData );
            var umbraData = Path.Combine( appDataPath, "Umbra" );
            var dataDir = new DirectoryInfo( umbraData );

            if( !dataDir.Exists )
            {
                dataDir.Create();
            }

            var logsDir = dataDir.CreateSubdirectory( "logs" );

            // configure logging first
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Async( x => x.Console() )
                .WriteTo.Async( x => x.File(
                    Path.Combine( logsDir.FullName, "umbra_.log" ),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 14
                ) )
                .MinimumLevel.Information()
                .CreateLogger();

            Locator.CurrentMutable.UseSerilogFullLogger();

            // fix poco yells that rxui spits out, they're annoying and useless
            Locator.CurrentMutable.RegisterConstant( new RxUI.CustomObservableForProperty(), typeof( ICreatesObservableForProperty ) );

            var configFile = Path.Combine( dataDir.FullName, "config.json" );

            var settings = new ConfigurationBuilder< IUmbraSettings >()
                .UseJsonFile( configFile )
                .Build();

            Locator.CurrentMutable.RegisterConstant( settings, typeof( IUmbraSettings ) );

            if( settings.DataPath == null )
            {
                // attempt to guess a data path before asking someone to locate it
                settings.DataPath = GuessClientDataPath();

                // if we still haven't found something, make the user do it for us
                if( settings.DataPath == null )
                {
                    using( var dialog = new System.Windows.Forms.FolderBrowserDialog() )
                    {
                        var result = dialog.ShowDialog();
                    }
                }
            }

            Log.Information( "using game datapath: {DataPath}", settings.DataPath );

            // init lumina
            var luminaOptions = new LuminaOptions
            {
                CacheFileResources = true,
                DefaultExcelLanguage = settings.ExcelLanguage
            };

            var lumina = new Lumina.Lumina(
                args.Length > 0 ? args[ 0 ] : settings.DataPath,
                luminaOptions
            );

            foreach( var ver in settings.PreviousVersions )
            {
                Log.Information( "previous version: {@PrevVersion}", ver );
            }

            Locator.CurrentMutable.RegisterConstant( luminaOptions );
            Locator.CurrentMutable.RegisterConstant( lumina );

            Locator.CurrentMutable.RegisterViewsForViewModels( Assembly.GetCallingAssembly() );

            // bootstrap app
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static void Shutdown()
        {
            Log.CloseAndFlush();

            Environment.Exit( 0 );
        }

        private static string GuessClientDataPath()
        {
            var key = Registry.CurrentUser.OpenSubKey( @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched" );

            if( key == null )
            {
                return null;
            }

            var filtered = key.GetValueNames()
                .Where( x => x.Contains( "ffxiv_dx11.exe" ) || x.Contains( "ffxiv.exe" ) )
                .Select( x => new { Path = x, Value = key.GetValue( x ) } )
                .Where( x => File.Exists( x.Path ) )
                .OrderByDescending( x => x.Value );

            // todo: order by client version (if we can find it?) lol

            foreach( var entry in filtered )
            {
                Log.Information( "found potential client path candidate: {ClientPath}", entry.Path );

                var dir = Path.GetDirectoryName( entry.Path );
                var sqpack = new DirectoryInfo( Path.Combine( dir, "sqpack" ) );

                if( !sqpack.Exists )
                {
                    continue;
                }

                Log.Information( "found sqpack directory in candidate: {ClientPath} -> {DataPath}",
                    entry.Path, sqpack.FullName );
                return sqpack.FullName;
            }

            return null;
        }
    }
}