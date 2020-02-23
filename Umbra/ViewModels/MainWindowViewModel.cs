using System;
using System.Reactive;
using System.Windows;
using ReactiveUI;
using Splat;

namespace Umbra.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private readonly Lumina.Lumina _lumina;

        public MainWindowViewModel( Lumina.Lumina lumina = null )
        {
            _lumina = lumina ?? Locator.Current.GetService< Lumina.Lumina >();

            DataPath = _lumina.DataPath.FullName;
        }

        public readonly ReactiveCommand< Unit, Unit > QuitCommand = ReactiveCommand.Create( EntryPoint.Shutdown );

        private string _dataPath;
        public string DataPath
        {
            get => _dataPath;
            set => this.RaiseAndSetIfChanged( ref _dataPath, value );
        }
    }
}