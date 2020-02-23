using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lumina.Data;
using Lumina.Excel.Sheets;
using ReactiveUI;
using Splat;
using Umbra.Controls;
using Umbra.ViewModels.Controls;

namespace Umbra.ViewModels
{
    public class MusicPageViewModel : ReactiveObject
    {
        private readonly Lumina.Lumina _lumina;
        private List< BGM > _bgms;

        public MusicPageViewModel( Lumina.Lumina lumina = null )
        {
            _lumina = lumina ?? Locator.Current.GetService< Lumina.Lumina >();

            _bgms = _lumina.GetExcelSheet< BGM >().GetRows().Where( b => _lumina.FileExists( b.File ) ).ToList();

            _searchResults = this
                .WhenAnyValue( x => x.SearchFilter )
                .Throttle( TimeSpan.FromMilliseconds( 250 ) )
                .Select( filter => filter?.Trim().ToLowerInvariant() )
                .DistinctUntilChanged()
                .SelectMany( SearchFilesAsync )
                .ObserveOn( RxApp.MainThreadScheduler )
                .ToProperty( this, x => x.SearchResults, SearchFiles() );
        }

        private string _searchFilter;

        public string SearchFilter
        {
            get => _searchFilter;
            set => this.RaiseAndSetIfChanged( ref _searchFilter, value );
        }

        private readonly ObservableAsPropertyHelper< IEnumerable< GenericListViewItemViewModel > > _searchResults;
        public IEnumerable< GenericListViewItemViewModel > SearchResults => _searchResults.Value;

        private IEnumerable< GenericListViewItemViewModel > SearchFiles( string term = null )
        {
            if( string.IsNullOrWhiteSpace( term ) )
            {
                return _bgms.Select( b => new GenericListViewItemViewModel( b.File ) );
            }

            return _bgms
                .Where( b => b.File.ToLowerInvariant().Contains( term ) )
                .Select( b => new GenericListViewItemViewModel( b.File ) );
        }

        private async Task< IEnumerable< GenericListViewItemViewModel > > SearchFilesAsync( string term, CancellationToken token )
        {
            return await Task.Run( () => SearchFiles( term ), token );
        }
    }
}