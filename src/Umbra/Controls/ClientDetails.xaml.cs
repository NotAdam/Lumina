using System.Reactive.Disposables;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Umbra.ViewModels;
using Umbra.Views;

namespace Umbra.Controls
{
    public partial class ClientDetails : ReactiveUserControl< ClientDetailsViewModel >
    {
        public ClientDetails()
        {
            InitializeComponent();

            this.WhenActivated( reg =>
            {
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenExplorer,
                    v => v.OpenExplorerButton
                ).DisposeWith( reg );
            } );
        }

        private void Control_OnMouseDoubleClick( object sender, MouseButtonEventArgs e )
        {
            OpenExplorer();
        }

        private void OpenExplorer()
        {
            if( ViewModel?.Path == null )
            {
                return;
            }

            var explorer = new ClientExplorer( ViewModel.Path );
            explorer.Show();
            explorer.Activate();
            explorer.Focus();
        }
    }
}