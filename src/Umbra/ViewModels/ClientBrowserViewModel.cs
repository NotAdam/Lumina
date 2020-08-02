using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows;
using DynamicData;
using Microsoft.Win32;
using ReactiveUI;
using Splat;
using Umbra.Models;

namespace Umbra.ViewModels
{
    public class ClientBrowserViewModel : ReactiveObject
    {
        private readonly Services.LuminaProviderService _luminaProvider;
        private readonly Services.GarbageSettingsService _settings;

        public ClientBrowserViewModel()
        {
            _luminaProvider = Locator.Current.GetService< Services.LuminaProviderService >();
            _settings = Locator.Current.GetService< Services.GarbageSettingsService >();

            Quit = ReactiveCommand.Create( OnQuit );
            AddClient = ReactiveCommand.Create( OnAddClient );
            RemoveSelectedClient = ReactiveCommand.Create( OnRemoveSelectedClient );
            ClientSelected = ReactiveCommand.Create< GameClient >( OnClientSelected );

            GameClients = new ObservableCollection< ClientDetailsViewModel >();
            // todo: this is shit but i don't care
            GameClients.AddRange( _settings.Settings.Clients.Select( c => new ClientDetailsViewModel { Client = c } ) );
        }

        public ReactiveCommand< Unit, Unit > Quit { get; set; }
        public ReactiveCommand< Unit, Unit > AddClient { get; set; }
        public ReactiveCommand< Unit, Unit > RemoveSelectedClient { get; set; }
        public ReactiveCommand< GameClient, Unit > ClientSelected { get; set; }

        public ObservableCollection< ClientDetailsViewModel > GameClients { get; set; }

        private ClientDetailsViewModel _selectedGameClient;

        public ClientDetailsViewModel SelectedGameClient
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

        private void OnAddClient()
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
                Version = Lumina.Repositories.FirstOrDefault( r => r.Key == "ffxiv" ).Value?.Version
            };

            GameClients.Add( new ClientDetailsViewModel { Client = client } );
            _settings.Settings.Clients.Add( client );
            _settings.SaveSettings();
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