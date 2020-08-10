using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Umbra.Events;
using Umbra.ViewModels.Explorer;
using Umbra.Views;

namespace Umbra.Controls.Explorer
{
    public partial class ExcelSheetsList : ReactiveUserControl< ExcelSheetsListViewModel >
    {
        public ExcelSheetsList( Lumina.Lumina lumina )
        {
            ViewModel = new ExcelSheetsListViewModel( lumina );
            
            InitializeComponent();

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.SearchResults,
                    v => v.SheetList.ItemsSource
                ).DisposeWith( reg );

                this.Bind(
                    ViewModel,
                    vm => vm.SearchNeedle,
                    v => v.SearchInput.Text
                ).DisposeWith( reg );
            } );
        }

        private void SheetList_OnMouseDoubleClick( object sender, MouseButtonEventArgs e )
        {
            if( SheetList.SelectedItem == null )
            {
                return;
            }

            var parent = Window.GetWindow( this );
            if( parent == null )
            {
                return;
            }
            
            if( parent is Workbench wb )
            {
                wb.RequestOpenExcelSheet( SheetList.SelectedItem as string );
            }
        }
    }
}