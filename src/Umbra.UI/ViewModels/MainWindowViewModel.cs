using Lumina;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;

namespace Umbra.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            QuitCommand = ReactiveCommand.Create( OnQuitCommand );

            _lumina = Locator.Current.GetService<Lumina.Lumina>();
        }

#if DEBUG
        public string WindowTitle => "Umbra - Debug";
#else
        public string WindowTitle => "Umbra";
#endif

        private readonly Lumina.Lumina _lumina;

        public ReactiveCommand<Unit, Unit> QuitCommand { get; set; }

        public string DataPath => _lumina.DataPath.FullName;

        public string GameVer => _lumina.Repositories.FirstOrDefault( r => r.Key == "ffxiv" ).Value?.Version;

        public void OnQuitCommand()
        {
            Environment.Exit( 0 );
        }
    }
}
