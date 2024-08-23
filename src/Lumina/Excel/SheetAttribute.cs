using System;

namespace Lumina.Excel;

/// <summary>
/// An attribute attached to a schema/struct that represents a sheet in an excel file.
/// </summary>
[AttributeUsage( AttributeTargets.Struct )]
public sealed class SheetAttribute : Attribute
{
    /// <summary>
    /// The name of the sheet.
    /// </summary>
    /// <remarks>
    /// Can be <see langword="null"/> if the schema is not associated with a specific sheet (i.e. quest/dungeon/cutscene sheets).
    /// </remarks>
    public string? Name { get; }

    /// <summary>
    /// Gets the column hash of the sheet; optionally used to check for schema and sheet changes.
    /// </summary>
    public uint? ColumnHash { get; }

    /// <summary>
    /// Creates a new instance of the <see cref="SheetAttribute"/> class.
    /// </summary>
    public SheetAttribute()
    {
        Name = null;
        ColumnHash = null;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="SheetAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the sheet.</param>
    public SheetAttribute( string name )
    {
        Name = name;
        ColumnHash = null;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="SheetAttribute"/> class.
    /// </summary>
    /// <param name="columnHash">The column hash of the sheet; optionally used to check for schema and sheet changes.</param>
    public SheetAttribute( uint columnHash )
    {
        Name = null;
        ColumnHash = columnHash;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="SheetAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the sheet.</param>
    /// <param name="columnHash">The column hash of the sheet; optionally used to check for schema and sheet changes.</param>
    public SheetAttribute( string name, uint columnHash )
    {
        Name = name;
        ColumnHash = columnHash;
    }
}