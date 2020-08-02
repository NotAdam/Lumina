using ReactiveUI;

namespace Umbra.ViewModels.Explorer.Files
{
    public class ExcelSheetPageViewModel : ReactiveObject
    {
        private string _sheetName;
        public string SheetName
        {
            get => _sheetName;
            set => this.RaiseAndSetIfChanged( ref _sheetName, value );
        }
    }
}