using System.Reactive.Disposables;
using ReactiveUI;
using Umbra.ViewModels.Explorer.Files;

namespace Umbra.Controls.Explorer.Files
{
    public partial class RawFile : ReactiveUserControl< RawFileViewModel >
    {
        public RawFile( string path, Lumina.Lumina lumina )
        {
            ViewModel = new RawFileViewModel( path, lumina );
            InitializeComponent();

            this.WhenActivated( reg =>
            {
                HexEditor.Stream = ViewModel.Resource.FileStream;

                this.OneWayBind(
                    ViewModel,
                    vm => vm.Path,
                    v => v.FileName.Text
                ).DisposeWith( reg );
            } );
        }
    }
}