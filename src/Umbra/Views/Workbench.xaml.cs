using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using AvalonDock.Layout;
using DynamicData.Binding;
using ReactiveUI;
using Umbra.Controls.Explorer;
using Umbra.ViewModels;

namespace Umbra.Views
{
    public partial class Workbench : ReactiveWindow< WorkbenchViewModel >
    {
        public Workbench( string path )
        {
            InitializeComponent();

#if !DEBUG
            // hide debug menu in release builds so people don't do dumb shit
            DebugMenu.Visibility = Visibility.Collapsed;
#endif

            ViewModel = new WorkbenchViewModel( path );
            
            
            
            ExcelSheetListAnchorable.Content = new ExcelSheetsList( ViewModel.Lumina );
            FileBrowserAnchorable.Content = new FileBrowser();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.Title,
                    v => v.Title
                ).DisposeWith( reg );

                this.BindCommand(
                    ViewModel,
                    vm => vm.DiscoverGameFiles,
                    v => v.DiscoverFiles
                ).DisposeWith( reg );

            } );
        }

        private void AddTab_OnClick( object sender, RoutedEventArgs e )
        {
            AddTabContent( "new tab", new TextBlock { Text = "hello from new tab!" } );
        }

        public void AddTabContent( string title, object content, bool focusNewTab = true )
        {
            var group = RootDocumentPaneGroup.Children.FirstOrDefault();

            var pane = group as LayoutDocumentPane;
            if( pane == null )
            {
                return;
            }
            
            pane.Children.Add( new LayoutDocument
            {
                Title = title,
                Content = content
            } );

            // todo: can probably just move this to an observable instead, which would then work for any source of new tabs
            if( focusNewTab )
            {
                // this seems to work fine but feels mega dodgy
                pane.SelectedContentIndex = pane.ChildrenCount - 1;
            }
        }

        private void ThrowException_OnClick( object sender, RoutedEventArgs e )
        {
            throw new System.NotImplementedException();
        }

        public void RequestOpenExcelSheet( string sheetName )
        {
            var sheetPage = new Controls.Explorer.Files.ExcelSheetPage( sheetName, ViewModel.Lumina );
            AddTabContent( $"Sheet: {sheetName}", sheetPage );
        }

        public void RequestOpenFile( string filePath )
        {
            // ew
            var extension = filePath.Split( '.' )[ ^1 ];

            object view = extension switch
            {
                // todo: add & implement other file type viewers
                // "mdl" => null,
                _ => new Controls.Explorer.Files.RawFile( filePath, ViewModel.Lumina )
            };

            AddTabContent( filePath, view );
        }
    }
}