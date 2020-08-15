using System.Reactive.Disposables;
using ReactiveUI;
using Umbra.ViewModels.Explorer;
using System;

namespace Umbra.Controls.Explorer
{
    public partial class FileBrowser : ReactiveUserControl< ViewModels.Explorer.FileBrowserViewModel >
    {
        public FileBrowser()
        {
            ViewModel = new FileBrowserViewModel();
            InitializeComponent();

            FileTreeView.ItemsSource = ViewModel.FileSystemNodes;

            this.WhenActivated( reg =>
            {
                this.BindCommand(
                    ViewModel,
                    vm => vm.DebugAddNode,
                    v => v.AddNodeBtn
                ).DisposeWith( reg );

                MessageBus.Current.Listen< Events.DiscoveredGameFilePath >()
                    .Subscribe( OnDiscoveredGameFilePath )
                    .DisposeWith( reg );
            } );
        }

        private void OnDiscoveredGameFilePath( Events.DiscoveredGameFilePath evt )
        {
            ViewModel?.AddFsNode( evt.FullPath );
        }
    }
}