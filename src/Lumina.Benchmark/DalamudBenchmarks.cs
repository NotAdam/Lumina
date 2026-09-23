using BenchmarkDotNet.Attributes;
using Lumina.Data.Files;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Benchmark;

[MemoryDiagnoser]
public class IconBenchmarks
{
    private GameData gameData = null!;
    private string[] icons = null!;
    private string[] missingIcons = null!;

    [GlobalSetup]
    public void Setup()
    {
        gameData = Program.CreateGameData();

        var found = new List< string >();
        var missing = new List< string >();
        for( uint i = 1; found.Count < 200 || missing.Count < 200; i++ )
        {
            var path = $"ui/icon/{i / 1000 * 1000:D6}/{i:D6}.tex";
            if( gameData.ContainsFile( path ) )
            {
                if( found.Count < 200 ) found.Add( path );
            }
            else if( missing.Count < 200 )
                missing.Add( path );
        }

        icons = [.. found];
        missingIcons = [.. missing];
    }

    [Benchmark]
    public int ProbeHit()
    {
        return icons.Count( path => gameData.ContainsFile( path ) );
    }

    [Benchmark]
    public int ProbeMiss()
    {
        return missingIcons.Count( path => gameData.ContainsFile( path ) );
    }

    [Benchmark]
    public long LoadTexFile()
    {
        long n = 0;
        foreach( var path in icons )
            n += gameData.GetFile< TexFile >( path ).Header.Width;
        return n;
    }

    [Benchmark]
    public long LoadAndDecode()
    {
        long n = 0;
        foreach( var path in icons )
            n += gameData.GetFile< TexFile >( path ).ImageData.Length;
        return n;
    }
}

[MemoryDiagnoser]
public class ExcelBenchmarks
{
    private GameData gameData = null!;

    [Params( "Item", "Level", "Action", "Quest" )]
    public string Sheet { get; set; } = "Item";

    [GlobalSetup]
    public void Setup() => gameData = Program.CreateGameData();

    [IterationSetup( Target = nameof( LoadSheetCold ) )]
    public void ResetModule() => gameData = Program.CreateGameData();

    [Benchmark]
    public int LoadSheetCold() => gameData.Excel.GetRawSheet( Sheet ).Count;

    [Benchmark]
    public long IterateSheet()
    {
        long n = 0;
        foreach( var row in gameData.Excel.GetSheet< RawRow >( null, Sheet ) )
            n += row.RowId;
        return n;
    }
}

[MemoryDiagnoser]
public class StartupBenchmarks
{
    [Benchmark]
    public int GameDataInit() => Program.CreateGameData().Excel.SheetNames.Count;
}

[MemoryDiagnoser]
public class ColumnReadBenchmarks
{
    private GameData gameData = null!;
    private ExcelSheet< RawRow > item = null!;

    [GlobalSetup]
    public void Setup()
    {
        gameData = Program.CreateGameData();
        item = gameData.Excel.GetSheet< RawRow >( null, "Item" );
    }

    // boxed, as HaselDebug's global search reads it
    [Benchmark( Baseline = true )]
    public long Boxed()
    {
        long n = 0;
        foreach( var row in item )
            for( var i = 0; i < row.Columns.Count; i++ )
                n += row.ReadColumn( i ) is null ? 0 : 1;
        return n;
    }

    // the same data read through the typed accessors, skipping the box
    [Benchmark]
    public long Typed()
    {
        long n = 0;
        foreach( var row in item )
        {
            foreach( var column in row.Columns )
            {
                n += column.Type switch
                {
                    ExcelColumnDataType.String => row.ReadString( column.Offset ).ByteLength,
                    ExcelColumnDataType.Bool => row.ReadBool( column.Offset ) ? 1 : 0,
                    ExcelColumnDataType.Int8 => row.ReadInt8( column.Offset ),
                    ExcelColumnDataType.UInt8 => row.ReadUInt8( column.Offset ),
                    ExcelColumnDataType.Int16 => row.ReadInt16( column.Offset ),
                    ExcelColumnDataType.UInt16 => row.ReadUInt16( column.Offset ),
                    ExcelColumnDataType.Int32 => row.ReadInt32( column.Offset ),
                    ExcelColumnDataType.UInt32 => row.ReadUInt32( column.Offset ),
                    ExcelColumnDataType.Float32 => (long)row.ReadFloat32( column.Offset ),
                    ExcelColumnDataType.Int64 => row.ReadInt64( column.Offset ),
                    ExcelColumnDataType.UInt64 => (long)row.ReadUInt64( column.Offset ),
                    _ => 0,
                };
            }
        }

        return n;
    }
}

// Penumbra/Meddle shape: bulk retrieval of model/material/texture bytes. Both ship their own
// parsers, so what they ask Lumina for is the decompressed file, not a parsed structure.
[MemoryDiagnoser]
public class ModelPipelineBenchmarks
{
    private GameData gameData = null!;
    private string[] models = null!;
    private string[] materials = null!;
    private string[] textures = null!;

    [GlobalSetup]
    public void Setup()
    {
        gameData = Program.CreateGameData();

        var mdl = new List< string >();
        var mtrl = new List< string >();
        var tex = new List< string >();

        for( var m = 1; m <= 2000 && mdl.Count < 50; m++ )
        {
            var model = $"chara/monster/m{m:D4}/obj/body/b0001/model/m{m:D4}b0001.mdl";
            if( !gameData.ContainsFile( model ) )
                continue;

            mdl.Add( model );

            var material = $"chara/monster/m{m:D4}/obj/body/b0001/material/v0001/mt_m{m:D4}b0001_a.mtrl";
            if( gameData.ContainsFile( material ) ) mtrl.Add( material );

            var texture = $"chara/monster/m{m:D4}/obj/body/b0001/texture/v01_m{m:D4}b0001_d.tex";
            if( gameData.ContainsFile( texture ) ) tex.Add( texture );
        }

        models = [.. mdl];
        materials = [.. mtrl];
        textures = [.. tex];
    }

    [Benchmark]
    public long ReadModelBytes() => ReadAll( models );

    [Benchmark]
    public long ReadMaterialBytes() => ReadAll( materials );

    [Benchmark]
    public long ReadTextureBytes() => ReadAll( textures );

    private long ReadAll( string[] paths )
    {
        long total = 0;
        foreach( var path in paths )
        {
            var stream = gameData.Vfs.GetFileStream( path );
            var buffer = GC.AllocateUninitializedArray< byte >( checked( (int)stream.Length ) );
            stream.ReadExactly( buffer );
            total += buffer.Length;
        }

        return total;
    }
}
