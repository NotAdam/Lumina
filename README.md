# Lumina

[![Nuget](https://img.shields.io/nuget/v/Lumina)](https://www.nuget.org/packages/Lumina/)

Lumina is an (attempt) at creating a small, performant library for interacting with FINAL FANTASY XIV game data in a convenient manner.

## Usage

See the `Lumina.Example` project for more comprehensive examples on loading files and creating custom data types.


    var lumina = new Lumina( "path/to/sqpack/folder" );

    var file = lumina.GetFile( "exd/root.exl" );

    file.SaveFile( "root.exl" );