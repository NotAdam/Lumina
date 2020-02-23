using ReactiveUI;

namespace Umbra.ViewModels.Controls
{
    public class GenericListViewItemViewModel : ReactiveObject
    {
        public GenericListViewItemViewModel( string content = null, bool isNewItem = false )
        {
            _content = content;
        }
        
        private string _content;
        public string Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged( ref _content, value );
        }

        private bool _isNewItem;
        public bool IsNewItem
        {
            get => _isNewItem;
            set => this.RaiseAndSetIfChanged( ref _isNewItem, value );
        }
    }
}