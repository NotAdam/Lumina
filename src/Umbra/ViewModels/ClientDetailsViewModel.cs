using System.Reactive;
using ReactiveUI;
using Umbra.Models;

namespace Umbra.ViewModels
{
    public class ClientDetailsViewModel : ReactiveObject
    {
        public ClientDetailsViewModel()
        {
            OpenExplorer = ReactiveCommand.Create(() => {});
        }

        public ReactiveCommand< Unit, Unit > OpenExplorer;
        
        public GameClient Client { get; set; }

        public string Path => Client.Path;

        public string Version => Client.Version;
    }
}