using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using Serilog;
using Splat;
using Splat.Serilog;
using Expression = System.Linq.Expressions.Expression;

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
                .WriteTo.RollingFile( "logs/umbra-{Date}.log", retainedFileCountLimit: 7, fileSizeLimitBytes: 52_428_800 )
                .CreateLogger();

            Locator.CurrentMutable.RegisterViewsForViewModels( Assembly.GetCallingAssembly() );
            Locator.CurrentMutable.RegisterConstant( new Services.LuminaProviderService() );
            
            Locator.CurrentMutable.Register(() => new CustomPropertyResolver(), typeof(ICreatesObservableForProperty));
            
            Locator.CurrentMutable.UseSerilogFullLogger();
        }
    }

    public class CustomPropertyResolver : ICreatesObservableForProperty
    {
        public int GetAffinityForObject( Type type, string propertyName, bool beforeChanged = false )
        {
            if( !typeof( FrameworkElement ).IsAssignableFrom( type ) )
                return 0;
            var fi = type.GetTypeInfo().GetFields( BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly )
                .FirstOrDefault( x => x.Name == propertyName );

            return fi != null ? 2 /* POCO affinity+1 */ : 0;
        }

        public IObservable< IObservedChange< object, object > >? GetNotificationForProperty( object sender, Expression expression, string propertyName, bool beforeChanged = false, bool suppressWarnings = false )
        {
            var foo = (FrameworkElement)sender;
            return Observable.Return( new ObservedChange< object, object >( sender, expression ), new DispatcherScheduler( foo.Dispatcher ) )
                .Concat( Observable.Never< IObservedChange< object, object > >() );
        }
    }
}