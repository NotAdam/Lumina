using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;
using Umbra.UI.Controls;
using Umbra.UI.Services;

namespace Umbra.UI.ViewModels.Controls
{
    public class ClientInfoViewModel : ViewModelBase
    {
        public ClientInfoViewModel()
        {
            _luminaProvider = Locator.Current.GetService<LuminaProviderService>();
        }

        private readonly LuminaProviderService _luminaProvider;

        public string _path;
        public string Path
        {
            get => _path;
            set => this.RaiseAndSetIfChanged( ref _path, value );
        }
    }
}
