using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using Expression = System.Linq.Expressions.Expression;

namespace Umbra.RxUI
{
    /// <summary>
    /// It's just the code from RxUI but with the yells removed
    ///
    /// see: https://github.com/reactiveui/ReactiveUI/blob/master/src/ReactiveUI/ObservableForProperty/POCOObservableForProperty.cs
    /// </summary>
    internal class CustomObservableForProperty : ICreatesObservableForProperty
    {
        public int GetAffinityForObject( Type type, string propertyName, bool beforeChanged = false )
        {
            return 1;
        }

        public IObservable< IObservedChange< object, object > > GetNotificationForProperty(
            object sender,
            Expression expression,
            string propertyName,
            bool beforeChanged = false,
            bool suppressWarnings = false )
        {
            if( sender == null )
            {
                throw new ArgumentNullException( nameof( sender ) );
            }

            return Observable.Return( new ObservedChange< object, object >( sender, expression ), RxApp.MainThreadScheduler )
                .Concat( Observable.Never< IObservedChange< object, object > >() );
        }
    }
}