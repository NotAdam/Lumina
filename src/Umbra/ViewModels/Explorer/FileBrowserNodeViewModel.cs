using System.Collections.ObjectModel;
using MahApps.Metro.IconPacks;
using ReactiveUI;
using Umbra.ViewModels.Explorer;

namespace Umbra.ViewModels.Explorer
{
    public class FileBrowserNodeViewModel : ReactiveObject
    {
        public enum NodeKind
        {
            Folder,
            File,
        }
        
        public FileBrowserNodeViewModel()
        {
            Children = new ObservableCollection< FileBrowserNodeViewModel >();
        }

        // the current node's path fragment
        public string Fragment { get; set; }

        // the full path that we're at currently so we don't need to keep track of a parent node
        // eg. if we double click on a file node, we can open a file with no fuckery
        public string FullPath { get; set; }

        public NodeKind Kind { get; set; }

        private PackIconFontAwesomeKind _iconKind;
        public PackIconFontAwesomeKind IconKind
        {
            get => _iconKind;
            set => this.RaiseAndSetIfChanged(ref _iconKind, value);
        }
        

        public ObservableCollection< FileBrowserNodeViewModel > Children { get; set; }

        // hack for the hierarchical bullshit fuckery
        public FileBrowserNodeViewModel CurrentNode => this;
    }
}