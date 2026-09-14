using Lumina.Data.Files;
using Lumina.Data.Files.Excel;

namespace Lumina.Benchmark;

internal static class Program
{
    static void Main( string[] args )
    {
        BenchmarkDotNet.Running.BenchmarkSwitcher.FromAssembly( typeof( Program ).Assembly ).Run( args );
        if( args.Length > 0 )
            return;

        GameData gd = CreateGameData();

        Console.WriteLine( $"{gd.GetFile<ExcelListFile>( "exd/root.exl" ).ExdMap["PreHandler"]}" );

        {
            using FileStream fs = File.OpenWrite( "rsf.tex" );
            gd.Vfs.GetFileStream( "chara/monster/m0914/obj/body/b0001/texture/v01_m0914b0001_norm.tex" ).CopyTo( fs );
        }
        var f = gd.GetFile<TexFile>( "chara/monster/m0914/obj/body/b0001/texture/v01_m0914b0001_norm.tex" );

        //gd.Vfs.GetFileStream( "chara/monster/m0914/obj/body/b0001/model/m0914b0001.mdl" ).CopyTo( fs );
        //gd.Vfs.GetFileStream( "chara/equipment/e0856/model/c0301e0856_top.mdl" ).CopyTo( fs );
        //gd.GetFile<MdlFile>( "chara/equipment/e0856/model/c0301e0856_top.mdl" );

        //gd.GetFile( "chara/equipment/e0856/model/c0301e0856_top.mdl" ).FileStream.CopyTo( fs );

        //var mdl = gd.GetFile<MdlFile>( "chara/monster/m0914/obj/body/b0001/model/m0914b0001.mdl" );
        //gd.GetFile<TexFile>( "chara/monster/m0914/obj/body/b0001/texture/v01_m0914b0001_norm.tex" );

        Console.ReadLine();
    }

    private static readonly string[] SearchPaths = [
        @"J:\Programs\Steam\steamapps\common\FINAL FANTASY XIV Online\game\sqpack",
        @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack",
        Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.UserProfile ), ".xlcore", "ffxiv", "game", "sqpack" ),
    ];

    public static GameData CreateGameData()
    {
        return new( Array.Find( SearchPaths, Directory.Exists ) ?? throw new DirectoryNotFoundException( "No game installation found" ),
            new LuminaOptions()
        {
            PanicOnSheetChecksumMismatch = false,
            RsfResolver = ResolveRsf
        } );
    }

    private static readonly Dictionary<string, string> Hashes = new()
    {
        {"4A6E0950759FAF62", "78DAECBD0F741BC7792FBA82A2F74C20BCEE79BD4AEEEB69BB3E6E18DB6461BCB6A6DD3A9157B593DC93484E558B4B301485612DDA4D484A560D504100108310" },
        {"873BE11A9111E456", "78DAECBD77581549F33F3A205914CC9810130650CC014E4F990051CC399204032A8A3912540444901C149120282A0846647A1050141511C49C13CABAE6BCAE72" }
    };

    private static bool ResolveRsf( ulong indexHash, out ReadOnlyMemory<byte> resolvedData )
    {
        if( Hashes.TryGetValue( indexHash.ToString( "X8" ), out var data ) )
        {
            resolvedData = Convert.FromHexString( data );
            return true;
        }
        else
        {
            resolvedData = ReadOnlyMemory<byte>.Empty;
            return false;
        }
    }
}
