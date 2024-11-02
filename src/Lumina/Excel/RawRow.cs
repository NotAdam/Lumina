using Lumina.Data.Structs.Excel;
using Lumina.Text.ReadOnly;
using System;
using System.Collections.Generic;

namespace Lumina.Excel;

/// <summary>
/// An <see cref="IExcelRow{T}"/> type for explicitly reading data from an <see cref="ExcelPage"/>.
/// </summary>
/// <remarks>
/// This type is designed to be used to read from arbitrary columns and offsets.
/// </remarks>
[Sheet]
public readonly struct RawRow( ExcelPage page, uint offset, uint row ) : IExcelRow<RawRow>
{
    /// <summary>
    /// The associated <see cref="ExcelPage"/> of the row.
    /// </summary>
    public ExcelPage Page => page;

    /// <summary>
    /// Offset to the referenced row in the <see cref="Page"/>.
    /// </summary>
    public uint Offset => offset;

    /// <inheritdoc/>
    public uint RowId => row;

    /// <inheritdoc cref="RawExcelSheet.Columns"/>
    public IReadOnlyList< ExcelColumnDefinition > Columns =>
        page.Sheet.Columns;

    /// <inheritdoc cref="RawExcelSheet.GetColumnOffset"/>
    public ushort GetColumnOffset( int columnIdx ) =>
        page.Sheet.GetColumnOffset( columnIdx );

    /// <summary>
    /// Reads the value of the specified column.
    /// </summary>
    /// <param name="columnIdx"></param>
    /// <returns>Returns the value as a boxed <see langword="object"/>.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the column is of an unknown type.</exception>
    public object ReadColumn( int columnIdx )
    {
        var column = page.Sheet.Columns[columnIdx];
        return column.Type switch
        {
            ExcelColumnDataType.String => ReadString( column.Offset ),
            ExcelColumnDataType.Bool => ReadBool( column.Offset ),
            ExcelColumnDataType.Int8 => ReadInt8( column.Offset ),
            ExcelColumnDataType.UInt8 => ReadUInt8( column.Offset ),
            ExcelColumnDataType.Int16 => ReadInt16( column.Offset ),
            ExcelColumnDataType.UInt16 => ReadUInt16( column.Offset ),
            ExcelColumnDataType.Int32 => ReadInt32( column.Offset ),
            ExcelColumnDataType.UInt32 => ReadUInt32( column.Offset ),
            ExcelColumnDataType.Float32 => ReadFloat32( column.Offset ),
            ExcelColumnDataType.Int64 => ReadInt64( column.Offset ),
            ExcelColumnDataType.UInt64 => ReadUInt64( column.Offset ),
            >= ExcelColumnDataType.PackedBool0 and <= ExcelColumnDataType.PackedBool7 =>
                page.ReadPackedBool( column.Offset, (byte)( column.Type - ExcelColumnDataType.PackedBool0 ) ),
            _ => throw new InvalidOperationException( $"Unknown column type {column.Type}" )
        };
    }

    /// <summary>
    /// Reads a <see cref="ReadOnlySeString"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadString(nuint, nuint)"/>
    public ReadOnlySeString ReadString( nuint offset ) =>
        page.ReadString( Offset + offset, Offset );

    /// <summary>
    /// Reads a <see cref="bool"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadBool(nuint)"/>
    public bool ReadBool( nuint offset ) =>
        page.ReadBool( Offset + offset );

    /// <summary>
    /// Reads a <see cref="sbyte"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadInt8(nuint)"/>
    public sbyte ReadInt8( nuint offset ) =>
        page.ReadInt8( Offset + offset );

    /// <summary>
    /// Reads a <see cref="byte"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadUInt8(nuint)"/>
    public byte ReadUInt8( nuint offset ) =>
        page.ReadUInt8( Offset + offset );

    /// <summary>
    /// Reads a <see cref="short"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadInt16(nuint)"/>
    public short ReadInt16( nuint offset ) =>
        page.ReadInt16( Offset + offset );


    /// <summary>
    /// Reads a <see cref="ushort"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadUInt16(nuint)"/>
    public ushort ReadUInt16( nuint offset ) =>
        page.ReadUInt16( Offset + offset );

    /// <summary>
    /// Reads a <see cref="int"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadInt32(nuint)"/>
    public int ReadInt32( nuint offset ) =>
        page.ReadInt32( Offset + offset );

    /// <summary>
    /// Reads a <see cref="uint"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadUInt32(nuint)"/>
    public uint ReadUInt32( nuint offset ) =>
        page.ReadUInt32( Offset + offset );

    /// <summary>
    /// Reads a <see cref="float"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadFloat32(nuint)"/>
    public float ReadFloat32( nuint offset ) =>
        page.ReadFloat32( Offset + offset );

    /// <summary>
    /// Reads a <see cref="long"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadInt64(nuint)"/>
    public long ReadInt64( nuint offset ) =>
        page.ReadInt64( Offset + offset );

    /// <summary>
    /// Reads a <see cref="ulong"/> at <paramref name="offset"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <inheritdoc cref="ExcelPage.ReadUInt64(nuint)"/>
    public ulong ReadUInt64( nuint offset ) =>
        page.ReadUInt64( Offset + offset );

    /// <summary>
    /// Reads a <see cref="bool"/> at <paramref name="offset"/> at bit offset <paramref name="bit"/>.
    /// </summary>
    /// <param name="offset">Offset of the field inside the row.</param>
    /// <param name="bit">Bit offset of the field inside the byte. (0 - 7)</param>
    /// <inheritdoc cref="ExcelPage.ReadPackedBool(nuint, byte)"/>
    public bool ReadPackedBool( nuint offset, byte bit ) =>
        page.ReadPackedBool( Offset + offset, bit );

    /// <summary>
    /// Reads a <see cref="ReadOnlySeString"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadString(nuint)"/>
    public ReadOnlySeString ReadStringColumn( int columnIdx ) =>
        ReadString( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="bool"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadBool(nuint)"/>
    public bool ReadBoolColumn( int columnIdx ) =>
        ReadBool( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="sbyte"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadInt8(nuint)"/>
    public sbyte ReadInt8Column( int columnIdx ) =>
        ReadInt8( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="byte"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadUInt8(nuint)"/>
    public byte ReadUInt8Column( int columnIdx ) =>
        ReadUInt8( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="short"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadInt16(nuint)"/>
    public short ReadInt16Column( int columnIdx ) =>
        ReadInt16( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="ushort"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadUInt16(nuint)"/>
    public ushort ReadUInt16Column( int columnIdx ) =>
        ReadUInt16( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="int"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadInt32(nuint)"/>
    public int ReadInt32Column( int columnIdx ) =>
        ReadInt32( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="uint"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadUInt32(nuint)"/>
    public uint ReadUInt32Column( int columnIdx ) =>
        ReadUInt32( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="float"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadFloat32(nuint)"/>
    public float ReadFloat32Column( int columnIdx ) =>
        ReadFloat32( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="long"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadInt64(nuint)"/>
    public long ReadInt64Column( int columnIdx ) =>
        ReadInt64( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="ulong"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <inheritdoc cref="ReadUInt64(nuint)"/>
    public ulong ReadUInt64Column( int columnIdx ) =>
        ReadUInt64( GetColumnOffset( columnIdx ) );

    /// <summary>
    /// Reads a <see cref="bool"/> at <paramref name="columnIdx"/> at an arbitrary bit offset <paramref name="bit"/>.
    /// </summary>
    /// <param name="columnIdx">The index of the column.</param>
    /// <param name="bit">Bit offset of the field inside the byte. (0 - 7)</param>
    /// <inheritdoc cref="ReadPackedBool(nuint, byte)"/>
    public bool ReadPackedBoolColumn( int columnIdx, byte bit ) =>
        ReadPackedBool( GetColumnOffset( columnIdx ), bit );

    /// <summary>
    /// Reads a <see cref="bool"/> at <paramref name="columnIdx"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the column not of a packed bool type.</exception>
    /// <inheritdoc cref="ReadPackedBoolColumn(int, byte)"/>
    public bool ReadPackedBoolColumn( int columnIdx ) =>
        Columns[columnIdx].Type switch
        {
            var t when t < ExcelColumnDataType.PackedBool0 || t > ExcelColumnDataType.PackedBool7 =>
                throw new InvalidOperationException( $"Unknown column type {t}" ),
            var t => ReadPackedBoolColumn( columnIdx, (byte)( t - ExcelColumnDataType.PackedBool0 ) )
        };

    static RawRow IExcelRow<RawRow>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}
