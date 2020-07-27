using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using DynamicData.Binding;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Umbra.UI.Models;
using Umbra.UI.ViewModels;

namespace Umbra.UI.Views
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public ContentControl ContentMountRoot => this.FindControl<ContentControl>( "ContentMountRoot" );

        public MainWindow()
        {
            this.WhenActivated( disposable =>
            {
                this.WhenAnyValue( x => x.ViewModel.SelectedGameClient )
                    .Where( x => x != null )
                    .Do( GameClientSelected )
                    .Subscribe()
                    .DisposeWith( disposable );
            } );


            InitializeComponent();


#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load( this );
        }

        private void GameClientSelected( GameClient client )
        {
            var info = new Controls.ClientInfo( client );

            ContentMountRoot.Content = info;
        }
    }
}
