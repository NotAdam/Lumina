using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using DynamicData.Alias;
using ReactiveUI;

namespace Umbra.ViewModels.Explorer
{
    public class ExcelSheetsListViewModel : ReactiveObject
    {
        public ExcelSheetsListViewModel( Lumina.Lumina lumina ) : this()
        {
            _lumina = lumina;
        }

        public ExcelSheetsListViewModel()
        {
            _searchResults = this
                .WhenAnyValue( x => x.SearchNeedle )
                .Throttle( TimeSpan.FromMilliseconds( 100 ) )
                .Select( term => term?.Trim() )
                .DistinctUntilChanged()
                // .Where( term => !string.IsNullOrWhiteSpace( term ) )
                .SelectMany( SearchExcelSheetNames )
                .ObserveOn( RxApp.MainThreadScheduler )
                .ToProperty( this, x => x.SearchResults );
        }

        private readonly Lumina.Lumina _lumina;

        public IEnumerable< string > SheetPaths => _lumina?.Excel?.SheetNames;

        private readonly ObservableAsPropertyHelper< IEnumerable< string > > _searchResults;
        public IEnumerable< string > SearchResults => _searchResults.Value;

        private string _searchNeedle;
        public string SearchNeedle
        {
            get => _searchNeedle;
            set => this.RaiseAndSetIfChanged( ref _searchNeedle, value );
        }

        private async Task< IEnumerable< string > > SearchExcelSheetNames( string needle )
        {
            if( string.IsNullOrEmpty( needle ) )
            {
                return _lumina?.Excel?.SheetNames;
            }
            
            return _lumina?.Excel?.SheetNames.Where( s => s.Contains( needle, StringComparison.InvariantCultureIgnoreCase ) );
        }
    }
}