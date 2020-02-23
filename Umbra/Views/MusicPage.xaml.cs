using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;

namespace Umbra.Views
{
    public partial class MusicPage
    {
        public MusicPage()
        {
            InitializeComponent();
            ViewModel = new ViewModels.MusicPageViewModel();

            this.WhenActivated( reg =>
            {
                this.Bind( ViewModel, x => x.SearchFilter, x => x.SearchFilter.Text )
                    .DisposeWith( reg );

                this.OneWayBind( ViewModel, x => x.SearchResults, x => x.SearchResults.ItemsSource )
                    .DisposeWith( reg );
            } );
        }
    }
}