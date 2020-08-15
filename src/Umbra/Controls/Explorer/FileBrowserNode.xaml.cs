using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MahApps.Metro.IconPacks;
using ReactiveUI;
using Umbra.ViewModels.Explorer;
using Umbra.Views;

namespace Umbra.Controls.Explorer
{
    public partial class FileBrowserNode : ReactiveUserControl< FileBrowserNodeViewModel >
    {
        public FileBrowserNode()
        {
            InitializeComponent();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.Fragment,
                    v => v.FileName.Text
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.IconKind,
                    v => v.NodeIcon.Kind
                ).DisposeWith( reg );
                
            } );
        }

        private void Control_OnMouseDoubleClick( object sender, MouseButtonEventArgs e )
        {
            // don't care about anything that isn't a file basically
            if( ViewModel.Kind != FileBrowserNodeViewModel.NodeKind.GameFile )
            {
                return;
            }
            
            var window = Window.GetWindow( this ) as Workbench;
            window?.RequestOpenFile( ViewModel?.FullPath );
        }
    }
}