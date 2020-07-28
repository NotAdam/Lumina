using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umbra.UI.Controls;
using Umbra.UI.Services;

namespace Umbra.UI.ViewModels.Controls
{
    public class ClientInfoViewModel : ViewModelBase
    {
        public ClientInfoViewModel()
        {
            // this is purposefully left blank so the designer doesn't shit out
        }

        public ClientInfoViewModel( string path )
        {
            _luminaProvider = Locator.Current.GetService< LuminaProviderService >();
            _lumina = _luminaProvider.GetInstance( path );

            Path = path;
        }

        private readonly LuminaProviderService _luminaProvider;
        private readonly Lumina.Lumina _lumina;

        private string _path;
        public string Path
        {
            get => _path;
            set => this.RaiseAndSetIfChanged( ref _path, value );
        }

        public string GameVersion => _lumina?.Repositories
            .FirstOrDefault( r => r.Key == "ffxiv" )
            .Value?.Version;

        public List< string > Expansions => _lumina?.Repositories
            .Where( r => r.Key != "ffxiv" )
            .Select( r => $"{r.Key} ({r.Value.Version})" )
            .ToList();
    }
}