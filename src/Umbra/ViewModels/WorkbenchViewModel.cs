using System.Reactive;
using ReactiveUI;
using Splat;
using Umbra.Services;

namespace Umbra.ViewModels
{
    public class WorkbenchViewModel : ReactiveObject
    {
        public WorkbenchViewModel( string gamePath )
        {
            _gamePath = gamePath;

            _luminaProvider = Locator.Current.GetService< LuminaProviderService >();
            _discoveryService = Locator.Current.GetService< GameFileDiscoveryService >();
            Lumina = _luminaProvider.GetInstance( gamePath );

            DiscoverGameFiles = ReactiveCommand.Create( () => _discoveryService.StartFileDiscovery( _lumina ) );
        }

        private readonly LuminaProviderService _luminaProvider;
        private readonly GameFileDiscoveryService _discoveryService;

        public readonly ReactiveCommand< Unit, Unit > DiscoverGameFiles;
        
        private string _gamePath;
        public string GamePath
        {
            get => _gamePath;
            set
            {
                this.RaiseAndSetIfChanged( ref _gamePath, value );
            }
        }

        public string Title
        {
            get => $"Workbench - {_gamePath} - Umbra";
        }

        private Lumina.Lumina _lumina;
        public Lumina.Lumina Lumina
        {
            get => _lumina;
            set
            {
                this.RaiseAndSetIfChanged( ref _lumina, value );
            }
        }
    }
}