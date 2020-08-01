using ReactiveUI;

namespace Umbra.ViewModels
{
    public class ExplorerViewModel : ReactiveObject
    {
        private string _gamePath;

        public string GamePath
        {
            get => _gamePath;
            set => this.RaiseAndSetIfChanged( ref _gamePath, value );
        }

        public string Title
        {
            get => $"Explorer - {_gamePath} - Umbra";
        }
    }
}