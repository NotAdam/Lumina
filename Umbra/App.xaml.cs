using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Lumina;

namespace Umbra
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void SwitchTheme()
        {
            if( Resources.MergedDictionaries.Any() )
            {
                
                
                // todo: probably need to fix this so you don't nuke other dictionaries
                Resources.MergedDictionaries.Clear();
                return;
            }

            // add wip dark theme
            var uri = new Uri( "Theming/Umbra.Dark.xaml", UriKind.Relative );
            Resources.MergedDictionaries.Add( new ResourceDictionary { Source = uri } );
        }
    }
}