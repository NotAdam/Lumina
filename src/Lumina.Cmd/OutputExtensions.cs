using System.Drawing;
using System.Globalization;
using Pastel;

namespace Lumina.Cmd
{
    public static class OutputExtensions
    {
        public static Color StringColour = Color.CornflowerBlue;
        public static Color NumberColour = Color.PaleGreen;
        public static Color WarnColour = Color.DarkOrange;
        public static Color ErrorColour = Color.Red;
        
        public static string Data( this string str )
        {
            return str.Pastel( StringColour );
        }

        public static string Warn( this string str )
        {
            return str.Pastel( WarnColour );
        }
        
        public static string Error( this string str )
        {
            return str.Pastel( ErrorColour );
        }

        public static string Data( this int i )
        {
            return i.ToString().Pastel( NumberColour );
        }

        public static string Data( this float i )
        {
            return i.ToString( CultureInfo.InvariantCulture ).Pastel( NumberColour );
        }
    }
}