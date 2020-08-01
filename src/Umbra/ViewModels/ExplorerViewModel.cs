using ReactiveUI;
using Splat;
using Umbra.Services;

namespace Umbra.ViewModels
{
    public class ExplorerViewModel : ReactiveObject
    {
        public ExplorerViewModel()
        {
            
        }

        public ExplorerViewModel( string gamePath ) : this()
        {
            _gamePath = gamePath;

            _luminaProvider = Locator.Current.GetService< LuminaProviderService >();
            Lumina = _luminaProvider.GetInstance( gamePath );
        }

        private readonly LuminaProviderService _luminaProvider;
        
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
            get => $"Explorer - {_gamePath} - Umbra";
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