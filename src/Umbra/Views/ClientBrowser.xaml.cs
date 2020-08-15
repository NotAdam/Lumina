using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AdonisUI;
using Microsoft.Win32;
using ReactiveUI;
using Serilog;
using Umbra.Models;
using Umbra.ViewModels;

namespace Umbra.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow< ClientBrowserViewModel >
    {
        static readonly Key[] secret = 
        {
            Key.Up, Key.Up, Key.Down, Key.Down, Key.Left, Key.Right, Key.Left, Key.Right, Key.B, Key.A
        };

        private bool _activatedDarkTheme = false;

        public MainWindow()
        {
            InitializeComponent();
            
            var themeKey = Registry.CurrentUser.OpenSubKey( @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize" );
            if( themeKey != null )
            {
                var themePref = themeKey.GetValue(
                    "AppsUseLightTheme",
                    1
                );

                Log.Debug( "use light theme: {AppsUseLightTheme}", themePref );

                if( (int)themePref != 0 )
                {
                    return;
                }
                
                Log.Verbose("adding darktheme resource dictionary");
                
                AdonisUI.ResourceLocator.SetColorScheme( Application.Current.Resources, ResourceLocator.DarkColorScheme );
            }
            
            ViewModel = new ClientBrowserViewModel();

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
                    vm => vm.AddClient,
                    v => v.AddClientCtxMenu
                ).DisposeWith( reg );

                this.BindCommand(
                    ViewModel,
                    vm => vm.RemoveSelectedClient,
                    v => v.RemoveSelectedClientButton
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

                // this.Events().KeyUp
                //     .Select( x => x.Key )
                //     .Window( 10 )
                //     .SelectMany( x => x.SequenceEqual( secret ) )
                //     .Where( x => x && !_activatedDarkTheme )
                //     .Do( x => EnableDarkTheme() )
                //     .Subscribe( x => { } )
                //     .DisposeWith( reg );
            } );
        }
    }
}