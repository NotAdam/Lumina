using System.Reactive.Disposables;
using System.Windows.Controls;
using System.Windows.Data;
using ReactiveUI;
using Umbra.ViewModels.Explorer.Files;

namespace Umbra.Controls.Explorer.Files
{
    public partial class ExcelSheetPage : ReactiveUserControl< ExcelSheetPageViewModel >
    {
        public ExcelSheetPage( string sheetName, Lumina.Lumina lumina )
        {
            InitializeComponent();
            
            ViewModel = new ExcelSheetPageViewModel( sheetName, lumina );
            
            RawSheetDataGrid.Columns.Add( new DataGridTextColumn
            {
                Header = $"Key",
                Binding = new Binding("[0]")
            } );
            
            // build raw cols the DEGENERATE WAY
            // FUCK YEA WPF
            for( var i = 0; i < ViewModel.RawSheet.Columns.Length; i++ )
            {
                var sheetColumn = ViewModel.RawSheet.Columns[ i ];
                var dgCol = new DataGridTextColumn
                {
                    Header = $"{i}: {sheetColumn.Type.ToString()}",
                    // what the fuck?
                    Binding = new Binding($"[{i + 1}]")
                };

                RawSheetDataGrid.Columns.Add( dgCol );
            }

            this.WhenActivated( reg =>
            {
                this.OneWayBind(
                    ViewModel,
                    vm => vm.SheetName,
                    v => v.SheetName.Text
                ).DisposeWith( reg );

                // todo: this is FUCKED
                this.OneWayBind(
                    ViewModel,
                    vm => vm.RawData,
                    v => v.RawSheetDataGrid.ItemsSource
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.HeaderFileName,
                    v => v.HeaderFilePath.Text
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.Languages,
                    v => v.SheetLanguagesListView.ItemsSource
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.SheetColumns,
                    v => v.ColumnsDataGrid.ItemsSource
                ).DisposeWith( reg );

                this.OneWayBind(
                    ViewModel,
                    vm => vm.SheetPages,
                    v => v.DataPagesDataGrid.ItemsSource
                ).DisposeWith( reg );
            } );
        }
    }
}