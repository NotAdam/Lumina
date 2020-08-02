using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using AvalonDock.Layout;
using ReactiveUI;
using Umbra.Controls.Explorer;
using Umbra.ViewModels;

namespace Umbra.Views
{
    public partial class Explorer : ReactiveWindow< ExplorerViewModel >
    {
        public Explorer( string path )
        {
            InitializeComponent();

#if !DEBUG
            // hide debug menu in release builds so people don't do dumb shit
            DebugMenu.Visibility = Visibility.Collapsed;
#endif

            ViewModel = new ExplorerViewModel( path );
            ExcelSheetListAnchorable.Content = new ExcelSheetsList( ViewModel.Lumina );
            FileBrowserAnchorable.Content = new FileBrowser();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.Title,
                    v => v.Title
                ).DisposeWith( reg );


                // event handling
                MessageBus.Current.Listen< Events.RequestOpenExcelSheet >()
                    .Subscribe( RequestOpenExcelSheet )
                    .DisposeWith( reg );
            } );
        }

        private void AddTab_OnClick( object sender, RoutedEventArgs e )
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
                Title = title,
                Content = content
            } );
        }

        private void ThrowException_OnClick( object sender, RoutedEventArgs e )
        {
            throw new System.NotImplementedException();
        }

        private void RequestOpenExcelSheet( Events.RequestOpenExcelSheet e )
        {
            var sheetPage = new Controls.Explorer.Files.ExcelSheetPage( e.SheetName, ViewModel.Lumina );
            AddTabContent( $"Sheet: {e.SheetName}", sheetPage );
        }
    }
}