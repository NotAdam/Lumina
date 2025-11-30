using Lumina.Excel;

namespace Lumina.Benchmark;

[Sheet( "Addon" )]
public readonly struct Addon( ExcelPage page, uint offset, uint row ) : IExcelRow< Addon >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public uint Data => row & offset;

    static Addon IExcelRow< Addon >.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
}

[Sheet( "Item" )]
public readonly struct Item( ExcelPage page, uint offset, uint row ) : IExcelRow< Item >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly ushort Icon => page.ReadUInt16( offset + 136 );

    static Item IExcelRow< Item >.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
}

[Sheet( "QuestLinkMarker" )]
public readonly struct QuestLinkMarker( ExcelPage page, uint offset, uint row, ushort subrow ) : IExcelSubrow< QuestLinkMarker >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public ushort SubrowId => subrow;
    public uint Data => row & offset;

    static QuestLinkMarker IExcelSubrow< QuestLinkMarker >.Create( ExcelPage page, uint offset, uint row, ushort subrow ) => new( page, offset, row, subrow );
}


[Sheet( "GatheringItem" )]
public readonly struct GatheringItem( ExcelPage page, uint offset, uint row ) : IExcelRow< GatheringItem >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly RowRef Item => RowRef.GetFirstValidRowOrUntyped( page.Module, (uint)page.ReadInt32( offset + 8 ), [typeof( Item ), typeof( EventItem )], 0, page.Language );
    public readonly RowRef< GatheringItemLevelConvertTable > GatheringItemLevel => new( page.Module, page.ReadUInt16( offset + 12 ), page.Language );

    static GatheringItem IExcelRow< GatheringItem >.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "EventItem" )]
public readonly struct EventItem( ExcelPage page, uint offset, uint row ) : IExcelRow< EventItem >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly ushort Icon => page.ReadUInt16( offset + 24 );

    static EventItem IExcelRow< EventItem >.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GatheringItemLevelConvertTable" )]
public readonly struct GatheringItemLevelConvertTable( ExcelPage page, uint offset, uint row ) : IExcelRow< GatheringItemLevelConvertTable >
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;
    public uint Data => row & offset;

    public readonly byte GatheringItemLevel => page.ReadUInt8( offset );

    static GatheringItemLevelConvertTable IExcelRow< GatheringItemLevelConvertTable >.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "ENpcBase" )]
public readonly unsafe struct ENpcBase( ExcelPage page, uint offset, uint row ) : IExcelRow<ENpcBase>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    private static RowRef ENpcDataCtor( ExcelPage page, uint parentOffset, uint offset, uint i ) => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + i * 4 ), [typeof( ChocoboTaxiStand ), typeof( CraftLeve ), typeof( CustomTalk ), typeof( DefaultTalk ), typeof( FccShop ), typeof( GCShop ), typeof( GilShop ), typeof( GuildleveAssignment ), typeof( GuildOrderGuide ), typeof( GuildOrderOfficer ), typeof( Quest ), typeof( SpecialShop ), typeof( Story ), typeof( SwitchTalk ), typeof( TopicSelect ), typeof( TripleTriad ), typeof( Warp )], 1, page.Language );
    public readonly Collection<RowRef> ENpcData => new( page, offset, offset, &ENpcDataCtor, 32 );

    static ENpcBase IExcelRow<ENpcBase>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "ChocoboTaxiStand" )]
public readonly struct ChocoboTaxiStand( ExcelPage page, uint offset, uint row ) : IExcelRow<ChocoboTaxiStand>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static ChocoboTaxiStand IExcelRow<ChocoboTaxiStand>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CraftLeve" )]
public readonly struct CraftLeve( ExcelPage page, uint offset, uint row ) : IExcelRow<CraftLeve>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static CraftLeve IExcelRow<CraftLeve>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CustomTalk" )]
public readonly struct CustomTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<CustomTalk>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static CustomTalk IExcelRow<CustomTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "DefaultTalk" )]
public readonly struct DefaultTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<DefaultTalk>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static DefaultTalk IExcelRow<DefaultTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "FccShop" )]
public readonly struct FccShop( ExcelPage page, uint offset, uint row ) : IExcelRow<FccShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static FccShop IExcelRow<FccShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GCShop" )]
public readonly struct GCShop( ExcelPage page, uint offset, uint row ) : IExcelRow<GCShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static GCShop IExcelRow<GCShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GilShop" )]
public readonly struct GilShop( ExcelPage page, uint offset, uint row ) : IExcelRow<GilShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static GilShop IExcelRow<GilShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildleveAssignment" )]
public readonly struct GuildleveAssignment( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildleveAssignment>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static GuildleveAssignment IExcelRow<GuildleveAssignment>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildOrderGuide" )]
public readonly struct GuildOrderGuide( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildOrderGuide>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static GuildOrderGuide IExcelRow<GuildOrderGuide>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildOrderOfficer" )]
public readonly struct GuildOrderOfficer( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildOrderOfficer>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static GuildOrderOfficer IExcelRow<GuildOrderOfficer>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Quest" )]
public readonly struct Quest( ExcelPage page, uint offset, uint row ) : IExcelRow<Quest>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static Quest IExcelRow<Quest>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "SpecialShop" )]
public readonly struct SpecialShop( ExcelPage page, uint offset, uint row ) : IExcelRow<SpecialShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static SpecialShop IExcelRow<SpecialShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Story" )]
public readonly struct Story( ExcelPage page, uint offset, uint row ) : IExcelRow<Story>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static Story IExcelRow<Story>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "SwitchTalk" )]
public readonly struct SwitchTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<SwitchTalk>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static SwitchTalk IExcelRow<SwitchTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "TopicSelect" )]
public readonly unsafe struct TopicSelect( ExcelPage page, uint offset, uint row ) : IExcelRow<TopicSelect>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    private static RowRef ShopCtor( ExcelPage page, uint parentOffset, uint offset, uint i ) => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + 4 + i * 4 ), [typeof( SpecialShop ), typeof( GilShop ), typeof( PreHandler )], 2, page.Language );
    public readonly Collection<RowRef> Shop => new( page, offset, offset, &ShopCtor, 10 );

    static TopicSelect IExcelRow<TopicSelect>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "TripleTriad" )]
public readonly struct TripleTriad( ExcelPage page, uint offset, uint row ) : IExcelRow<TripleTriad>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static TripleTriad IExcelRow<TripleTriad>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Warp" )]
public readonly struct Warp( ExcelPage page, uint offset, uint row ) : IExcelRow<Warp>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static Warp IExcelRow<Warp>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "PreHandler" )]
public readonly struct PreHandler( ExcelPage page, uint offset, uint row ) : IExcelRow<PreHandler>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    public readonly RowRef Target => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + 8 ), [typeof( CollectablesShop ), typeof( InclusionShop ), typeof( GilShop ), typeof( SpecialShop ), typeof( Description )], 3, page.Language );

    static PreHandler IExcelRow<PreHandler>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CollectablesShop" )]
public readonly struct CollectablesShop( ExcelPage page, uint offset, uint row ) : IExcelRow<CollectablesShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static CollectablesShop IExcelRow<CollectablesShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "InclusionShop" )]
public readonly struct InclusionShop( ExcelPage page, uint offset, uint row ) : IExcelRow<InclusionShop>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static InclusionShop IExcelRow<InclusionShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Description" )]
public readonly struct Description( ExcelPage page, uint offset, uint row ) : IExcelRow<Description>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    static Description IExcelRow<Description>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}