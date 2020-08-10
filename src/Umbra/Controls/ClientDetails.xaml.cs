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

                this.OneWayBind(
                    ViewModel,
                    vm => vm.Path,
                    v => v.Path.Text
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.Version,
                    v => v.Version.Text
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

            var explorer = new Views.Workbench( ViewModel.Path );
            // todo: wtf? this still doesn't even fucking work right
            explorer.Show();
            explorer.Activate();
            explorer.Focus();
        }
    }
}