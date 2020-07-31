using System.Reactive.Disposables;
using ReactiveUI;
using Umbra.ViewModels;

namespace Umbra.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow< MainWindowViewModel >
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();

            this.WhenActivated( reg =>
            {
                this.BindCommand(
                    ViewModel,
                    vm => vm.Quit,
                    v => v.QuitMenuItem
                ).DisposeWith( reg );

                this.BindCommand(
                    ViewModel,
                    vm => vm.AddClient,
                    v => v.AddNewClientButton
                ).DisposeWith( reg );

                this.BindCommand(
                    ViewModel,
                    vm => vm.RemoveSelectedClient,
                    v => v.RemoveSelectedClientButton
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.WindowTitle,
                    v => v.Title
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.GameClients,
                    v => v.GameClientListBox.ItemsSource
                ).DisposeWith( reg );

                this.Bind(
                    ViewModel,
                    vm => vm.SelectedGameClient,
                    v => v.GameClientListBox.SelectedItem
                ).DisposeWith( reg );
            } );
        }
    }
}