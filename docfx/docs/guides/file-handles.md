# File Handles & Background Loading

Lumina provides a wrapper around file resources that allows you to defer file loads on to a background thread very easily.

## Setup

File handles get placed into a queue where they're then processed first-in, last-out. While you _can_ do this on the same thread, there's basically no point in doing this as there's no benefit.

A simple implementation is something like the following:
```cs
var lumina = new Lumina( "/opt/ffxiv/current/sqpack" );

var handleThread = new Thread( () =>
{
    while( true )
    {
        lumina.ProcessFileHandleQueue();
        Thread.Yield();
    }
}  );

handleThread.Start();

```

and then later in your shutdown routine:

```cs
handleThread.Abort();
```

## Using File Handles

Creating a new file handle is very similar to loading a file:

In an init method:
```cs
var iconHandle = lumina.GetFileHandle< TexFile >( "path/to/texture" );
```

Elsewhere in your code, e.g. a render method, you can consume handles like this:
```cs
if( iconHandle.HasValue )
{
    var icon = iconHandle.Value;

    // do stuff
}

// or

if( iconHandle.Value != null )
{
    // do stuff
}
```

There's nothing more to do with handles when consuming them, and you can throw away the handle and the underlying resources will get cleaned up too.