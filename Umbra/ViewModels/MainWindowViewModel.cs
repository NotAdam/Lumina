using System;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Windows;
using ReactiveUI;
using Splat;

namespace Umbra.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private readonly Lumina.Lumina _lumina;

        public MainWindowViewModel( Lumina.Lumina lumina = null, IUmbraSettings settings = null )
        {
            _lumina = lumina ?? Locator.Current.GetService< Lumina.Lumina >();
            _settings = settings ?? Locator.Current.GetService< IUmbraSettings >();

            DataPath = _lumina.DataPath.FullName;

            var sb = new StringBuilder();
            foreach( var (key, repo) in _lumina.Repositories )
            {
                sb.AppendLine( repo.Name );
            }

            Repositories = sb.ToString();
        }

        public readonly ReactiveCommand< Unit, Unit > QuitCommand = ReactiveCommand.Create( EntryPoint.Shutdown );
        public readonly ReactiveCommand< Unit, Unit > ChangeThemeCommand = ReactiveCommand.Create( () =>
        {
            var app = (App)Application.Current;
            app.SwitchTheme();
        } );

        private string _dataPath;

        public string DataPath
        {
            get => _dataPath;
            set => this.RaiseAndSetIfChanged( ref _dataPath, value );
        }

        private string _repositories;
        public string Repositories
        {
            get => _repositories;
            set => this.RaiseAndSetIfChanged( ref _repositories, value );
        }

        private IUmbraSettings _settings;
        public IUmbraSettings Settings
        {
            get => _settings;
            set => this.RaiseAndSetIfChanged( ref _settings, value );
        }
    }
}