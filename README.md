# Lumina

[![Nuget](https://img.shields.io/nuget/v/Lumina)](https://www.nuget.org/packages/Lumina/)

Lumina is an (attempt) at creating a small, performant library for interacting with FINAL FANTASY XIV game data in a convenient manner.

## Usage

### Read File

Currently only regular files are supported, models and textures are coming soon™

    var lumina = new Lumina( "path/to/sqpack/folder" );

    var file = lumina.GetFile( "exd/root.exl" );

    File.WriteAllBytes( "root.exl", file.GetDataSection( 0 ) );