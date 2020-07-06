# Supported File Types

This page will provide a brief overview of the types of files that Lumina can read. For more information about specific implementation details, consult the source code or the [dev wiki file formats page](https://xiv.dev/game-data/file-formats).

## Excel Files
`*.exd`, `*.exh` and `root.exl` is readable. This is mostly abstracted away by the `ExcelModule` but you can load files manually if you wish with `ExcelDataFile`, `ExcelHeaderFile` and `ExcelListFile` respectively.

## Layer

* `*.lgb` files can be read by using `lumina.GetFile< LgbFile >( <path> )`.
* `*.sgb` files can't be read (yet).

## Textures

Primitive and basic support (e.g. no lod levels) but can be read with `lumina.GetFile< TexFile >( <path> )`.
