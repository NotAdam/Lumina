using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;
using Umbra.ViewModels.Controls;

namespace Umbra.Controls
{
    public partial class GenericListViewItem
    {
        public GenericListViewItem()
        {
            InitializeComponent();
            ViewModel = new GenericListViewItemViewModel();

            this.WhenActivated( reg =>
            {
                this.OneWayBind( ViewModel, x => x.Content, x => x.TextContent.Text )
                    .DisposeWith( reg );
            } );
        }
    }
}