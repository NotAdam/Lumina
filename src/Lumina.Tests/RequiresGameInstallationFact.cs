using System;
using System.IO;
using Xunit;

namespace Lumina.Tests;

public sealed class RequiresGameInstallationFact : FactAttribute
{
    private static readonly string[] SearchPaths = [
        @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack",
        System.IO.Path.Combine(
            Environment.GetFolderPath( Environment.SpecialFolder.UserProfile ), ".xlcore", "ffxiv", "game", "sqpack" ),
    ];

    private static string? Path => Array.Find( SearchPaths, Directory.Exists );

    public RequiresGameInstallationFact()
    {
        if( Path == null )
            Skip = "Game installation is not found at the default path.";
    }

    public static GameData CreateGameData()
    {
        return new( Path!, new LuminaOptions()
        {
            PanicOnSheetChecksumMismatch = false,
        } );
    }
}