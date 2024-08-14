using System;

namespace Lumina.Excel;

/// <summary>
/// An attribute attached to a schema/struct that represents a sheet in an excel file.
/// </summary>
/// <param name="name">The name of the sheet.</param>
/// <param name="columnHash">The column hash of the sheet; optionally used to check for schema and sheet changes.</param>
[AttributeUsage( AttributeTargets.Struct )]
public class SheetAttribute( string name, uint columnHash ) : Attribute
{
    /// <summary>
    /// The name of the sheet.
    /// </summary>
    public readonly string Name = name;

    /// <summary>
    /// Gets the column hash of the sheet; optionally used to check for schema and sheet changes.
    /// </summary>
    public readonly uint? ColumnHash = columnHash;

    /// <summary>
    /// Creates a new instance of the <see cref="SheetAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the sheet.</param>
    public SheetAttribute( string name ) : this( name, uint.MaxValue )
    {
        ColumnHash = null;
    }
}