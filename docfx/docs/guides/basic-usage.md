# Setup & Basic Usage

## Adding the Package
Lumina is a nuget package. It can be installed like any other. You can install the latest release with the following:
```
dotnet add package Lumina
```

## Setting up Lumina
Lumina has some advanced options that can provide preferred behaviour in different circumstances, but generally speaking the only thing you are required to have is (part of) a game install. While not recommended for regular users, Lumina can and will operate fine on a partial game install depending on your use case.

To init Lumina, you need the absolute path of your FINAL FANTASY XIV install's `sqpack` folder. For example: `G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack`. Once you have that, initialisation is easy:

```cs
var lumina = new Lumina.Lumina( "G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack" );
```

It's worth noting at this point that constructing a new Lumina instance isn't exactly cheap - it's at this stage where Lumina will try to discover all the expansion data and other game related files available at the path provided. While this process will only take about 250ms or so, you should reuse the same instance where possible.

## Basic Usage

### Reading Raw Files
Lumina can read nearly all files in the game with no problem and will let you write them to disk, with the only exception being models. This is likely to change in the future but as is, models are not supported.

To read a file raw, you can just use `GetFile` with no specialisation. Saving that file to disk is also very simple.
```cs
var lumina = new Lumina.Lumina( "G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack" );

var file = lumina.GetFile( "exd/root.exl" );
file.SaveFile( "absolute/or/relative/path/root.exl" );
```

The above will load the file and write it to disk immediately. In the event of a file not existing, `GetFile` will return null.

### Reading Files (the good way)

While you can load files raw, where implemented, files can be loaded and parsed by Lumina and provide access to the file data in a structural manner. It works (nearly) the same as the example provided above.

```cs
var lumina = new Lumina.Lumina( "G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack" );

var lgb = lumina.GetFile< LgbFile >( "bg/ffxiv/sea_s1/twn/s1t1/level/bg.lgb" );

foreach( var layer in lgb.Layers )
{
    Console.WriteLine( $"layer: {layer.strName}" );
}
```

Similarly to raw files, these can also be written to disk as demonstrated above.

### Reading Excel Sheets

Excel is the data format used for storing relational data in FINAL FANTASY XIV. While Lumina abstracts away most of the detail and provides you with a clean interface for accessing the data, those interested can find more details about the file format [here](https://xiv.dev/game-data/file-formats/excel).

Firstly, the structures required to use this function live in a separate nuget package, `Lumina.Generated`. You will need to install this package separately to Lumina to access the generated structures. The generated structures provide lazily loaded references to other sheets which makes understanding and using the game data extremely easy, along with statically defined field names, so you can use all the reflection you want.

Once you've installed the `Lumina.Generated` package, reading sheets is akin to reading files.

```cs
var lumina = new Lumina.Lumina( "G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack" );

var itemSheet = lumina.GetExcelSheet< Item >();

// get a single row
var itemRow = itemSheet.GetRow( 101 );
Console.WriteLine( $"item name: {itemRow.Name}" );

// get all rows
var itemRows = itemSheet.GetRows();
foreach( var row in itemRows )
{
    Console.WriteLine( $"item name: {row.Name}" );
}
```

As briefly mentioned before, Lumina provides lazily loaded references to other sheets where a reference has been identified. These sheets are encapsulated in a `LazyRow< T >` which allows you to fetch the underlying value which was used to make the reference, along with loading the reference and accessing the data.

```cs
var lumina = new Lumina.Lumina( "G:/ffxiv/FINAL FANTASY XIV Online/game/sqpack" );

var itemSheet = lumina.GetExcelSheet< Item >();

var itemRow = itemSheet.GetRow( 101 );

// check if a value is set
if( itemRow.ClassJobUse.HasValue )
{
    var classJobUse = itemRow.ClassJobUse.Value;
    Console.WriteLine( $"classjobuse: {classJobUse.Name}" );
}

// alternatively, you can use null coalescing
Console.WriteLine( $"classjobuse: {itemRow.ClassJobUse.Value?.Name}" );
```

Lazily loaded rows have nearly 0 overhead outside of the first time Lumina sees a new sheet. For example, the first time you load an `Item` sheet, Lumina needs to fetch information about that sheet such as its structure and such and loads it into memory. This allows subsequent reads to happen extremely quickly as all the necessary data is loaded and pre-transformed once you want to read a row, making it ideal for scenarios that require high-performance.

You can also filter across entire collections of rows, lazily loaded rows and etc. with linq to quickly grab subsets of data.