using Lumina.Data.Files;

namespace Lumina.Extensions
{
    public static class LuminaExtensions
    {
        public static TexFile? GetIcon( this GameData gameData, uint iconId )
        {
            var path = $"ui/icon/{iconId / 1000 * 1000:000000}/{iconId:000000}.tex";

            return gameData.GetFile< TexFile >( path );
        }
        
        public static TexFile? GetHqIcon( this GameData gameData, uint iconId )
        {
            var path = $"ui/icon/{iconId / 1000 * 1000:000000}/{iconId:000000}_hr1.tex";

            return gameData.GetFile< TexFile >( path );
        }
    }
}