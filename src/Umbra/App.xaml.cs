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
using System.Windows.Threading;
using ReactiveUI;
using Sentry;
using Serilog;
using Serilog.Events;
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
#if !DEBUG
            // SentrySdk.Init( "https://709a11b977be4285b57870d3e77112fc@o428589.ingest.sentry.io/5374159" );
            //
            // DispatcherUnhandledException += ( o, e ) =>
            // {
            //     SentrySdk.CaptureException( e.Exception );
            // };
            // TaskScheduler.UnobservedTaskException += ( o, e ) =>
            // {
            //     SentrySdk.CaptureException( e.Exception );
            // };
            // AppDomain.CurrentDomain.UnhandledException += ( o, e ) =>
            // {
            //     SentrySdk.CaptureException( (Exception)e.ExceptionObject );
            // };
#endif

            // setup logger
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Verbose()
                .WriteTo.Debug()
#else
                .MinimumLevel.Information()
                // .WriteTo.Sentry( o =>
                // {
                //     o.MinimumBreadcrumbLevel = LogEventLevel.Debug;
                //     o.MinimumEventLevel = LogEventLevel.Warning;
                // } )
#endif
                .WriteTo.Console()
                .WriteTo.RollingFile( "logs/umbra-{Date}.log", retainedFileCountLimit: 7, fileSizeLimitBytes: 52_428_800 )
                .CreateLogger();

            RegisterViewsForViewModels( Locator.CurrentMutable, Assembly.GetCallingAssembly() );
            Locator.CurrentMutable.RegisterConstant( new Services.LuminaProviderService() );

            Locator.CurrentMutable.Register( () => new CustomPropertyResolver(), typeof( ICreatesObservableForProperty ) );

            Locator.CurrentMutable.UseSerilogFullLogger();
        }


        public static void RegisterViewsForViewModels( IMutableDependencyResolver resolver, Assembly assembly )
        {
            if( resolver == null )
            {
                throw new ArgumentNullException( nameof( resolver ) );
            }

            if( assembly == null )
            {
                throw new ArgumentNullException( nameof( assembly ) );
            }

            // for each type that implements IViewFor
            foreach( var ti in assembly.DefinedTypes
                .Where( ti => ti.ImplementedInterfaces.Contains( typeof( IViewFor ) ) && !ti.IsAbstract ) )
            {
                // grab the first _implemented_ interface that also implements IViewFor, this should be the expected IViewFor<>
                var ivf = ti.ImplementedInterfaces.FirstOrDefault( t => t.GetTypeInfo().ImplementedInterfaces.Contains( typeof( IViewFor ) ) );

                // need to check for null because some classes may implement IViewFor but not IViewFor<T> - we don't care about those
                if( ivf != null )
                {
                    // my kingdom for c# 6!
                    var contractSource = ti.GetCustomAttribute< ViewContractAttribute >();
                    var contract = contractSource != null ? contractSource.Contract : string.Empty;

                    RegisterType( resolver, ti, ivf, contract );
                }
            }
        }

        private static void RegisterType( IMutableDependencyResolver resolver, TypeInfo ti, Type serviceType, string contract )
        {
            var factory = TypeFactory( ti );
            if( factory == null )
            {
                Log.Debug( "Ignoring view registration for {ViewModel} as it's consuming view does not have a parameterless constructor", ti.FullName );
                return;
            }

            Log.Debug( "Registering view for {ViewModel}", ti.FullName );

            if( ti.GetCustomAttribute< SingleInstanceViewAttribute >() != null )
            {
                resolver.RegisterLazySingleton( factory, serviceType, contract );
            }
            else
            {
                resolver.Register( factory, serviceType, contract );
            }
        }

        private static Func< object > TypeFactory( TypeInfo typeInfo )
        {
            var parameterlessConstructor = typeInfo
                .DeclaredConstructors
                .FirstOrDefault( ci => ci.IsPublic && !ci.GetParameters().Any() );
            if( parameterlessConstructor == null )
            {
                // throw new Exception($"Failed to register type {typeInfo.FullName} because it's missing a parameterless constructor.");

                // this fixes stupid behaviour where controls that don't have a parameterless constructor can't be activated but it kills the entire thing
                // instead of just ignoring the offending viewmodels

                // fuck that
                return null;
            }

            return Expression.Lambda< Func< object > >( Expression.New( parameterlessConstructor ) ).Compile();
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

        public IObservable< IObservedChange< object, object > >? GetNotificationForProperty( object sender, Expression expression, string propertyName,
            bool beforeChanged = false, bool suppressWarnings = false )
        {
            var foo = (FrameworkElement)sender;
            return Observable.Return( new ObservedChange< object, object >( sender, expression ), new DispatcherScheduler( foo.Dispatcher ) )
                .Concat( Observable.Never< IObservedChange< object, object > >() );
        }
    }
}