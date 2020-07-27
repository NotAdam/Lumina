using Avalonia;
using Avalonia.Controls;
using DynamicData;
using Lumina;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Umbra.UI.Models;
using Umbra.UI.Services;

namespace Umbra.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _luminaProvider = Locator.Current.GetService<LuminaProviderService>();

            Quit = ReactiveCommand.Create( OnQuit );
            AddClient = ReactiveCommand.CreateFromTask<Window>( OnAddClient );
            RemoveSelectedClient = ReactiveCommand.CreateFromTask( OnRemoveSelectedClient );
            ClientSelected = ReactiveCommand.Create< GameClient >( OnClientSelected );

            GameClients = new ObservableCollection<GameClient>();
        }

#if DEBUG
        public string WindowTitle => "Umbra - Debug";
#else
        public string WindowTitle => "Umbra";
#endif

        private readonly LuminaProviderService _luminaProvider;
        
        public ReactiveCommand<Unit, Unit> Quit { get; set; }
        public ReactiveCommand<Window, Unit> AddClient { get; set; }
        public ReactiveCommand<Unit, Unit> RemoveSelectedClient { get; set; }
        public ReactiveCommand<GameClient, Unit> ClientSelected { get; set; }

        public ObservableCollection<GameClient> GameClients { get; set; }

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

        public void OnQuit()
        {
            Environment.Exit( 0 );
        }

        public async Task OnAddClient( Window parent )
        {
            var dialog = new OpenFileDialog();
            dialog.Filters.Add( new FileDialogFilter { Name = "Game Executables", Extensions = new List<string> { "exe" } } );
            dialog.Title = "Locate game installation";
            dialog.AllowMultiple = false;

            var result = await dialog.ShowAsync( parent );

            if( result.Length == 0 )
            {
                // wtf?
                return;
            }

            var path = Path.Join( Path.GetDirectoryName( result[0] ), "sqpack" );

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

            GameClients.Add( client );
        }

        public async Task OnRemoveSelectedClient()
        {
            if( SelectedGameClient == null )
            {
                return;
            }

            GameClients.Remove( SelectedGameClient );
        }

        public void OnClientSelected( GameClient client )
        {

        }
    }
}
