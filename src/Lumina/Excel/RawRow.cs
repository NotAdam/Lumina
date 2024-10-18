using Lumina.Data.Structs.Excel;
using Lumina.Text.ReadOnly;
using System;
using System.Collections.Generic;

namespace Lumina.Excel;

public readonly struct RawRow( ExcelPage page, uint offset, uint row ) : IExcelRow<RawRow>
{
    /// <summary>
    /// The associated <see cref="ExcelPage"/> of the row.
    /// </summary>
    public ExcelPage Page => page;

    /// <summary>
    /// 
    /// </summary>
    public uint Offset => offset;
    public uint RowId => row;

    public IReadOnlyList< ExcelColumnDefinition > Columns =>
        page.Sheet.Columns;

    public ushort GetColumnOffset( int columnIdx ) =>
        page.Sheet.GetColumnOffset( columnIdx );

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

    public ReadOnlySeString ReadString( nuint offset ) =>
        page.ReadString( Offset + offset, Offset );

    public bool ReadBool( nuint offset ) =>
        page.ReadBool( Offset + offset );

    public sbyte ReadInt8( nuint offset ) =>
        page.ReadInt8( Offset + offset );

    public byte ReadUInt8( nuint offset ) =>
        page.ReadUInt8( Offset + offset );

    public short ReadInt16( nuint offset ) =>
        page.ReadInt16( Offset + offset );

    public ushort ReadUInt16( nuint offset ) =>
        page.ReadUInt16( Offset + offset );

    public int ReadInt32( nuint offset ) =>
        page.ReadInt32( Offset + offset );

    public uint ReadUInt32( nuint offset ) =>
        page.ReadUInt32( Offset + offset );

    public float ReadFloat32( nuint offset ) =>
        page.ReadFloat32( Offset + offset );

    public long ReadInt64( nuint offset ) =>
        page.ReadInt64( Offset + offset );

    public ulong ReadUInt64( nuint offset ) =>
        page.ReadUInt64( Offset + offset );

    public bool ReadPackedBool( nuint offset, byte bit ) =>
        page.ReadPackedBool( Offset + offset, bit );

    public ReadOnlySeString ReadStringColumn( int columnIdx ) =>
        ReadString( GetColumnOffset( columnIdx ) );

    public bool ReadBoolColumn( int columnIdx ) =>
        ReadBool( GetColumnOffset( columnIdx ) );

    public sbyte ReadInt8Column( int columnIdx ) =>
        ReadInt8( GetColumnOffset( columnIdx ) );

    public byte ReadUInt8Column( int columnIdx ) =>
        ReadUInt8( GetColumnOffset( columnIdx ) );

    public short ReadInt16Column( int columnIdx ) =>
        ReadInt16( GetColumnOffset( columnIdx ) );

    public ushort ReadUInt16Column( int columnIdx ) =>
        ReadUInt16( GetColumnOffset( columnIdx ) );

    public int ReadInt32Column( int columnIdx ) =>
        ReadInt32( GetColumnOffset( columnIdx ) );

    public uint ReadUInt32Column( int columnIdx ) =>
        ReadUInt32( GetColumnOffset( columnIdx ) );

    public float ReadFloat32Column( int columnIdx ) =>
        ReadFloat32( GetColumnOffset( columnIdx ) );

    public long ReadInt64Column( int columnIdx ) =>
        ReadInt64( GetColumnOffset( columnIdx ) );

    public ulong ReadUInt64Column( int columnIdx ) =>
        ReadUInt64( GetColumnOffset( columnIdx ) );

    public bool ReadPackedBoolColumn( int columnIdx, byte bit ) =>
        ReadPackedBool( GetColumnOffset( columnIdx ), bit );

    static RawRow IExcelRow<RawRow>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}
