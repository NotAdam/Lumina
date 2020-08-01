using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using ReactiveUI;
using Splat;
using Umbra.Models;

namespace Umbra.ViewModels
{
    public class ClientBrowserViewModel : ReactiveObject
    {
        private readonly Services.LuminaProviderService _luminaProvider;
        
        public ClientBrowserViewModel()
        {
            _luminaProvider = Locator.Current.GetService< Services.LuminaProviderService >();
            
            Quit = ReactiveCommand.Create( OnQuit );
            AddClient = ReactiveCommand.CreateFromTask( OnAddClient );
            RemoveSelectedClient = ReactiveCommand.Create( OnRemoveSelectedClient );
            ClientSelected = ReactiveCommand.Create< GameClient >( OnClientSelected );
            ClientDoubleClicked = ReactiveCommand.Create< GameClient >( ( gc ) =>
            {
                MessageBox.Show( gc.Path );
            } );

            GameClients = new ObservableCollection< GameClient >();
        }

        public ReactiveCommand< Unit, Unit > Quit { get; set; }
        public ReactiveCommand< Unit, Unit > AddClient { get; set; }
        public ReactiveCommand< Unit, Unit > RemoveSelectedClient { get; set; }
        public ReactiveCommand< GameClient, Unit > ClientSelected { get; set; }
        
        public ReactiveCommand< GameClient, Unit > ClientDoubleClicked { get; set; }

        public ObservableCollection< GameClient > GameClients { get; set; }

        private GameClient _selectedGameClient;

        public GameClient SelectedGameClient
        {
            get => _selectedGameClient;
            set => this.RaiseAndSetIfChanged( ref _selectedGameClient, value );
        }

        private Lumina.Lumina _lumina;

        public Lumina.Lumina Lumina
        {
            get => _lumina;
            set => this.RaiseAndSetIfChanged( ref _lumina, value );
        }

        private void OnQuit()
        {
            Environment.Exit( 0 );
        }

        private async Task OnAddClient()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Game Client|ffxiv.exe;ffxiv_dx11.exe|All files (*.*)|*.*";
            dialog.Multiselect = false;
            dialog.Title = "Locate game client installation";

            if( dialog.ShowDialog() == false )
            {
                return;
            }
            
            var path = Path.Join( Path.GetDirectoryName( dialog.FileName ), "sqpack" );
            
            if( GameClients.Any( c => c.Path == path ) )
            {
                return;
            }
            
            // this is kind of shit but we can validate that a path is correct-ish
            Lumina = _luminaProvider.GetInstance( path );
            if( Lumina == null )
            {
                return;
            }
            
            var client = new GameClient
            {
                Path = path,
                Version = Lumina.Repositories.FirstOrDefault(r => r.Key == "ffxiv").Value?.Version
            };
            
            GameClients.Add( client );
        }

        private void OnRemoveSelectedClient()
        {
            if( SelectedGameClient == null )
            {
                return;
            }

            GameClients.Remove( SelectedGameClient );
        }

        private void OnClientSelected( GameClient client )
        {
        }
    }
}