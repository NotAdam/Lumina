using Lumina.Excel;

namespace Lumina.Benchmark;

[Sheet( "Addon" )]
public readonly struct Addon( ExcelPage page, uint offset, uint row ) : IExcelRow<Addon>
{
    public uint RowId => row;
    public uint Data => row & offset;

    static Addon IExcelRow<Addon>.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
}

[Sheet( "Item" )]
public readonly struct Item( ExcelPage page, uint offset, uint row ) : IExcelRow<Item>
{
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly ushort Icon => page.ReadUInt16( offset + 136 );

    static Item IExcelRow<Item>.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
}

[Sheet( "QuestLinkMarker" )]
public readonly struct QuestLinkMarker( ExcelPage page, uint offset, uint row, ushort subrow ) : IExcelSubrow<QuestLinkMarker>
{
    public uint RowId => row;
    public ushort SubrowId => subrow;
    public uint Data => row & offset;

    static QuestLinkMarker IExcelSubrow<QuestLinkMarker>.Create( ExcelPage page, uint offset, uint row, ushort subrow ) => new( page, offset, row, subrow );
}


[Sheet( "GatheringItem" )]
public readonly struct GatheringItem( ExcelPage page, uint offset, uint row ) : IExcelRow<GatheringItem>
{
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly RowRef Item => RowRef.GetFirstValidRowOrUntyped( page.Module, (uint)page.ReadInt32( offset + 8 ), [typeof( Item ), typeof( EventItem )] );
    public readonly RowRef<GatheringItemLevelConvertTable> GatheringItemLevel => new( page.Module, (uint)page.ReadUInt16( offset + 12 ) );

    static GatheringItem IExcelRow<GatheringItem>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "EventItem" )]
public readonly struct EventItem( ExcelPage page, uint offset, uint row ) : IExcelRow<EventItem>
{
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly ushort Icon => page.ReadUInt16( offset + 24 );

    static EventItem IExcelRow<EventItem>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GatheringItemLevelConvertTable" )]
public readonly struct GatheringItemLevelConvertTable( ExcelPage page, uint offset, uint row ) : IExcelRow<GatheringItemLevelConvertTable>
{
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly byte GatheringItemLevel => page.ReadUInt8( offset );

    static GatheringItemLevelConvertTable IExcelRow<GatheringItemLevelConvertTable>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}
