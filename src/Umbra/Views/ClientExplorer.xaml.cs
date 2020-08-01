using System.Reactive.Disposables;
using ReactiveUI;
using Umbra.ViewModels;

namespace Umbra.Views
{
    public partial class ClientExplorer : ReactiveWindow< ClientExplorerViewModel >
    {
        public ClientExplorer( string path ) : this()
        {
            ViewModel = new ClientExplorerViewModel
            {
                GamePath = path
            };
        }
        
        public ClientExplorer()
        {
            InitializeComponent();

            ViewModel ??= new ClientExplorerViewModel();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.Title,
                    v => v.Title
                ).DisposeWith( reg );
            } );
        }
    }
}