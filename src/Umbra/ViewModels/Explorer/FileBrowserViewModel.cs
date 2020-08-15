using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using MahApps.Metro.IconPacks;
using ReactiveUI;
using Umbra.Models;

namespace Umbra.ViewModels.Explorer
{
    using FsNodeCollection = ObservableCollection< FileBrowserNodeViewModel >;

    public class FileBrowserViewModel : ReactiveObject
    {
        public FileBrowserViewModel()
        {
            FileSystemNodes.Add( DebugCreateTree() );

            DebugAddNode = ReactiveCommand.Create( () =>
            {
                // FileSystemNodes.Add( DebugCreateTree() );
                AddFsNode("bg/ex3/01_nvt_n4/twn/n4t1/bgparts/n4t1_a1_chr03.mdl" );
                AddFsNode("music/ex2/bgm_ex2_system_title.scd" );
                AddFsNode("chara/weapon/w0501/obj/body/b0018/vfx/texture/uv_cryst_128s.atex" );
                AddFsNode("sound/vfx/ability/se_vfx_abi_berserk_c.scd");
            } );
        }

        public ReactiveCommand< Unit, Unit > DebugAddNode;
        
        public FsNodeCollection FileSystemNodes = new FsNodeCollection();

        public void AddFsNode( string path )
        {
            // figure out the basic shit first
            var fragments = path.Split( '/' );
            var currentFragment = fragments[ ^1 ];

            var parent = GetOrCreateParentFolderNode( fragments );
            
            // check if we have a child with the current node already
            if( parent.Any( n => n.Fragment.Equals( currentFragment, StringComparison.InvariantCultureIgnoreCase ) ) )
            {
                // already have it, don't care
                return;
            }

            // add the new node now
            var newNode = new FileBrowserNodeViewModel
            {
                Fragment = currentFragment,
                FullPath = BuildFullPathForFragments( fragments, fragments.Length ),
            };

            // todo: probably a file but a shit way of checking lmao
            if( currentFragment.Contains( "." ) )
            {
                newNode.Kind = FileBrowserNodeViewModel.NodeKind.File;
                newNode.IconKind = PackIconFontAwesomeKind.FileSolid;
            }
            
            parent.Add( newNode );
        }

        private FsNodeCollection GetOrCreateParentFolderNode( string[] fragments )
        {
            FsNodeCollection head = FileSystemNodes;

            for( int i = 0; i < fragments.Length - 1; i++ )
            {
                var current = fragments[ i ];
                
                var node = FindApplicableNode( head, current );
                if( node == null )
                {
                    // create new node
                    var newNode = new FileBrowserNodeViewModel
                    {
                        Fragment = current,
                        FullPath = BuildFullPathForFragments( fragments, i ),
                        IconKind = PackIconFontAwesomeKind.FolderSolid
                    };
                    
                    head.Add( newNode );
                    head = newNode.Children;
                }
                else
                {
                    // we found some shit, fuck yea
                    head = node.Children;
                }
            }
            
            // at this point we should have the correct collection, minus the last fragment (which is the file itself)
            return head;
        }

        private string BuildFullPathForFragments( string[] fragments, int pos )
        {
            var frags = fragments.Take( pos + 1 );
            return string.Join( '/', frags );
        }

        private FileBrowserNodeViewModel FindApplicableNode( FsNodeCollection collection, string fragment )
        {
            foreach( var node in collection )
            {
                if( node.Fragment.Equals( fragment, StringComparison.InvariantCultureIgnoreCase ) )
                {
                    return node;
                }
            }

            return null;
        }


        private FileBrowserNodeViewModel DebugCreateTree(string rootName = "bg")
        {
            var node1 = new FileBrowserNodeViewModel
            {
                Fragment = rootName,
                FullPath = rootName,
                Kind = FileBrowserNodeViewModel.NodeKind.Folder
            };

            var node11 = new FileBrowserNodeViewModel
            {
                Fragment = "ffxiv",
                FullPath = "bg/ffxiv",
                Kind = FileBrowserNodeViewModel.NodeKind.Folder
            };
            
            var node12 = new FileBrowserNodeViewModel
            {
                Fragment = "ex1",
                FullPath = "bg/ex1",
                Kind = FileBrowserNodeViewModel.NodeKind.Folder
            };
            
            var node13 = new FileBrowserNodeViewModel
            {
                Fragment = "ex2",
                FullPath = "bg/ex2",
                Kind = FileBrowserNodeViewModel.NodeKind.Folder
            };

            node1.Children = new ObservableCollection< FileBrowserNodeViewModel > { node11, node12, node13 };

            return node1;
        }
    }
}