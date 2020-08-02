using System.Reactive.Disposables;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Umbra.ViewModels.Explorer;

namespace Umbra.Controls.Explorer
{
    public partial class ExcelSheetsList : ReactiveUserControl< ExcelSheetsListViewModel >
    {
        public ExcelSheetsList( Lumina.Lumina lumina ) : this()
        {
            ViewModel = new ExcelSheetsListViewModel( lumina );
        }

        public ExcelSheetsList()
        {
            InitializeComponent();

            ViewModel ??= new ExcelSheetsListViewModel();

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

            MessageBus.Current.SendMessage( new Events.RequestOpenExcelSheet
            {
                SheetName = SheetList.SelectedItem as string
            } );
        }
    }
}