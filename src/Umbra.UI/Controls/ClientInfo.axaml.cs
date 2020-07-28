using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Umbra.UI.Models;
using Umbra.UI.ViewModels.Controls;

namespace Umbra.UI.Controls
{
    public class ClientInfo : ReactiveUserControl< ClientInfoViewModel >
    {
        public ClientInfo()
        {
        }

        public ClientInfo( GameClient client )
        {
            DataContext = new ClientInfoViewModel( client.Path );

            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load( this );
        }
    }
}