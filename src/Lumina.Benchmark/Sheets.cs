using BenchmarkDotNet.Attributes;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Data;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
public class SheetsBench
{
    private GameData gameData;

    [GlobalSetup]
    public void Setup()
    {
        gameData = new GameData( @"J:\Programs\Steam\steamapps\common\FINAL FANTASY XIV Online\game\sqpack", new()
        {
            PanicOnSheetChecksumMismatch = false,
        } );
    }

    [Benchmark]
    public ulong TestAllSheets()
    {
        ulong ret = 0;
        foreach( var sheetName in gameData.Excel.SheetNames )
        {
            if( gameData.GetFile< ExcelHeaderFile >( $"exd/{sheetName}.exh" ) is not { } headerFile )
                continue;
            var lang = headerFile.Languages.Contains( Language.English ) ? Language.English : Language.None;
            switch( headerFile.Header.Variant )
            {
                case ExcelVariant.Default:
                    {
                        var sheet = gameData.Excel.GetSheet< Addon >( lang, sheetName );
                        ret += sheet.Count == 0 ? 0 : sheet.GetRowAt( sheet.Count - 1 ).RowId - sheet.GetRowAt( 0 ).RowId + 1 - (uint)sheet.Count;
                        break;
                    }
                case ExcelVariant.Subrows:
                    {
                        var sheet = gameData.Excel.GetSubrowSheet< QuestLinkMarker >( lang, sheetName );
                        ret += sheet.Count == 0 ? 0 : sheet.GetRowAt( sheet.Count - 1 ).RowId - sheet.GetRowAt( 0 ).RowId + 1 - (uint)sheet.Count ;
                        break;
                    }
            }
        }
        return ret;
    }
}
