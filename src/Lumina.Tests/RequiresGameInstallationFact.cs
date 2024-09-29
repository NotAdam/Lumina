using System.IO;
using Xunit;

namespace Lumina.Tests;

public sealed class RequiresGameInstallationFact : FactAttribute
{
    private const string Path = @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack";

    public RequiresGameInstallationFact()
    {
        if( !Directory.Exists( Path ) )
            Skip = "Game installation is not found at the default path.";
    }

    public static GameData CreateGameData()
    {
        return new( Path, new()
        {
            PanicOnSheetChecksumMismatch = false,
        } );
    }
}