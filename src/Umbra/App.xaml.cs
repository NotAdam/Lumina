using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using Serilog;
using Splat;
using Splat.Serilog;

namespace Umbra
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Verbose()
                .WriteTo.Debug()
#else
                .MinimumLevel.Information()
#endif
                .WriteTo.Console()
                .WriteTo.RollingFile( "logs/umbra-{Date}.log", retainedFileCountLimit: 7, fileSizeLimitBytes: 52_428_800  )
                
                .CreateLogger();

            Locator.CurrentMutable.RegisterViewsForViewModels( Assembly.GetCallingAssembly() );
            Locator.CurrentMutable.RegisterConstant( new Services.LuminaProviderService() );
            Locator.CurrentMutable.UseSerilogFullLogger();
        }
    }
}