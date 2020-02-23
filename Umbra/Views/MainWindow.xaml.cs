using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using Umbra.ViewModels;

namespace Umbra.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();

            this.WhenActivated( reg =>
            {
                // debug tab
                this.OneWayBind( ViewModel, x => x.DataPath, x => x.DataPathLabel.Content )
                    .DisposeWith( reg );
                
                this.OneWayBind( ViewModel, x => x.Repositories, x => x.RepositoriesLabel.Content )
                    .DisposeWith( reg );

                // menu commands
                this.BindCommand( ViewModel, x => x.QuitCommand, x => x.QuitButton )
                    .DisposeWith( reg );

                // debug commands
                this.BindCommand( ViewModel, x => x.ChangeThemeCommand, x => x.SwitchThemeButton )
                    .DisposeWith( reg );
            } );
        }
    }
}