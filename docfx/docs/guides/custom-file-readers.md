# Custom File Readers

Custom file readers are relatively simple in terms of what needs to be implemented for Lumina to load it. All custom file types must inherit from `Lumina.Data.FileResource` and override the `LoadFile` method. Once that is done, Lumina is capable of reading a file using your custom file type.

You can also override the behaviour of SaveFile in the event that you want to be able to write out files in a different format instead of its underlying raw data. As is, a custom file type must have a trivial constructor as there is no way to pass parameters to a constructor as of yet, and there doesn't seem to be a need for that either.

For a more comprehensive loading example, check the built in file implementations located here: https://github.com/NotAdam/Lumina/blob/master/src/Lumina/Data/Files/


```cs
private class CustomFileType : Data.FileResource
{
    public Dictionary< string, int > ExdMap;

    public int Version { get; private set; }

    public CustomFileType()
    {
        ExdMap = new Dictionary< string, int >();
    }

    public override void LoadFile()
    {
        Console.WriteLine( "loading customfiletype" );

        using var stream = new MemoryStream( Data, false );
        using var sr = new StreamReader( stream );

        // read version
        var header = sr.ReadLine().Split( ',' );
        if( header[ 0 ] != "EXLT" )
        {
            throw new Exception( "invalid file format or something :(" );
        }

        Version = int.Parse( header[ 1 ] );

        // read exd mappings
        string row;
        while( ( row = sr.ReadLine() ) != null )
        {
            var data = row.Split( ',' );
            var id = int.Parse( data[ 1 ] );

            ExdMap[ data[ 0 ] ] = id;
        }
    }

    public override void SaveFile( string path )
    {
        Console.WriteLine( $"saving file to path: {path}" );
        base.SaveFile( path );
    }
}
```