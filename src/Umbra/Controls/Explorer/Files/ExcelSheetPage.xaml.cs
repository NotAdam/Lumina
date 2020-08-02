using System.Windows.Controls;
using ReactiveUI;
using Umbra.ViewModels.Explorer.Files;

namespace Umbra.Controls.Explorer.Files
{
    public partial class ExcelSheetPage : ReactivePage< ExcelSheetPageViewModel >
    {
        public ExcelSheetPage()
        {
            InitializeComponent();
        }
    }
}