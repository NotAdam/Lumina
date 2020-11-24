using Lumina.Data.Files;

namespace Lumina.Extensions
{
    public static class LuminaExtensions
    {
        public static TexFile GetIcon( this Lumina lumina, int iconId )
        {
            var path = $"ui/icon/{iconId / 1000 * 1000:000000}/{iconId:000000}.tex";

            return lumina.GetFile< TexFile >( path );
        }
    }
}