using Lumina.Data.Files;

namespace Lumina.Extensions
{
    public static class LuminaExtensions
    {
        public static TexFile? GetIcon( this GameData gameData, int iconId )
        {
            var path = $"ui/icon/{iconId / 1000 * 1000:000000}/{iconId:000000}.tex";

            return gameData.GetFile< TexFile >( path );
        }
    }
}