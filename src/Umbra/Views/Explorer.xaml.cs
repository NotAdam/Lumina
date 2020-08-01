using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using AvalonDock.Layout;
using ReactiveUI;
using Umbra.ViewModels;

namespace Umbra.Views
{
    public partial class Explorer : ReactiveWindow< ExplorerViewModel >
    {
        public Explorer( string path ) : this()
        {
            ViewModel = new ExplorerViewModel
            {
                GamePath = path
            };
        }

        public Explorer()
        {
            InitializeComponent();

            ViewModel ??= new ExplorerViewModel();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.Title,
                    v => v.Title
                ).DisposeWith( reg );
            } );
        }

        private void MenuItem_OnClick( object sender, RoutedEventArgs e )
        {
            AddTabContent( "new tab", new TextBlock { Text = "hello from new tab!" } );
        }

        public void AddTabContent( string title, object content )
        {
            var group = RootDocumentPaneGroup.Children.FirstOrDefault();
            if( group == null )
            {
                return;
            }
            
            var pane = group as LayoutDocumentPane;
            pane?.Children.Add( new LayoutDocument
            {
                Title = "new tab",
                Content = new TextBlock { Text = "hello from new tab!" }
            } );
        }
    }
}