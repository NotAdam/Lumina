using System;

namespace Lumina.Excel;

/// <summary>
/// An attribute attached to a schema/struct that represents a sheet in an excel file.
/// </summary>
/// <param name="name">The name of the sheet</param>
/// <param name="columnHash">The column hash of the sheet; optionally used to check for schema and sheet changes</param>
[AttributeUsage( AttributeTargets.Struct )]
public class SheetAttribute( string name, uint? columnHash = null ) : Attribute
{
    /// <summary>
    /// The sheet name
    /// </summary>
    public readonly string Name = name;

    /// <summary>
    /// A column hash - used to warn when a sheet structure has changed
    /// </summary>
    public readonly uint? ColumnHash = columnHash;
}