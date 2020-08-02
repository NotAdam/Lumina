using System.Windows.Controls;
using ReactiveUI;

namespace Umbra.Controls.Explorer
{
    public partial class FileBrowser : ReactiveUserControl< ViewModels.Explorer.FileBrowserViewModel >
    {
        public FileBrowser()
        {
            InitializeComponent();
        }
    }
}