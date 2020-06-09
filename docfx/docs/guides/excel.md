# Advanced Excel

## Creating your own sheet readers
Similarly to the FileResource system, the Excel implementation works similarly with an extensible interface allowing custom sheet implementations. Custom implementations can be useful when you only want a subset of data out of a specific sheet or are implementing something missing (contributions welcome!).

In a nutshell, a custom sheet must be decorated with the `Sheet` attribute and implement `IExcelRow` which requires you to add a couple properties and a method.

```cs
[Sheet( "Condition" )]
public class Condition : IExcelRow
{
    public int Index;
    public uint LogMessageId;
    public LazyRow< LogMessage > LogMessage;

    public uint RowId { get; set; }
    public uint SubRowId { get; set; }
    
    public void PopulateData( RowParser parser, Lumina lumina )
    {
        RowId = parser.Row;
        SubRowId = parser.SubRow;

        Index = parser.ReadColumn< int >( 0 );
        
        LogMessageId = parser.ReadColumn< uint >( 2 );
        LogMessage = new LazyRow< LogMessage >( lumina, LogMessageId );
    }
}
```

```cs
[Sheet( "LogMessage" )]
public class LogMessage : IExcelRow
{
    public string Text;

    public uint RowId { get; set; }
    public uint SubRowId { get; set; }

    public void PopulateData( RowParser parser, Lumina lumina )
    {
        RowId = parser.Row;
        SubRowId = parser.SubRow;

        Text = parser.ReadColumn< string >( 4 );
    }
}
```

Few things to note:
* A sheet attribute is required as it lets you create specialised sheets with different class names but still read from the same sheet implicitly, saving you from providing the sheet name in the `GetSheet` function every time
* To make things simpler, everything must have a `SubRowId` even if the sheet you're reading from doesn't have them. Simply put, this makes the interface simpler without all kinds of complexity when it comes to reading sheets and implementing them
* `LazyRow< T >` allows for lazy loading of direct references to other sheets, provided that they're implemented somewhere as an `IExcelRow`, more on that below

## LazyRow

`LazyRow` is a lazy sheet loader. There's not much to know about this other than it makes life easy as you can implement foreign key references without any real backing code. The `SpaghettiGenerator` will spit these out in place of any links from the SaintCoinach schema, but its simple enough to use elsewhere too.

You don't need to store the row ID in the sheet class itself if you don't want to, and the generator doesn't. You can always access the backing row ID by fetching it from the `Row` property on the `LazyRow` instance.