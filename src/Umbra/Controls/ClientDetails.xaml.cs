using System.Reactive.Disposables;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Umbra.ViewModels;

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

            var explorer = new Views.Explorer( ViewModel.Path );
            // todo: wtf? this still doesn't even fucking work right
            explorer.Show();
            explorer.Activate();
            explorer.Focus();
        }
    }
}