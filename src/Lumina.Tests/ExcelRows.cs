using Lumina.Excel;

namespace Lumina.Tests;

[Sheet( "ENpcBase" )]
public readonly unsafe struct ENpcBase( ExcelPage page, uint offset, uint row ) : IExcelRow<ENpcBase>
{
    public uint RowId => row;

    private static uint ENpcDataCtor( ExcelPage page, uint parentOffset, uint offset, uint i ) => page.ReadUInt32( offset + i * 4 );
    public readonly Collection<uint> ENpcData => new( page, offset, offset, &ENpcDataCtor, 32 );

    private static RowRef ENpcDataCtor2( ExcelPage page, uint parentOffset, uint offset, uint i ) => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + i * 4 ), [typeof( ChocoboTaxiStand ), typeof( CraftLeve ), typeof( CustomTalk ), typeof( DefaultTalk ), typeof( FccShop ), typeof( GCShop ), typeof( GilShop ), typeof( GuildleveAssignment ), typeof( GuildOrderGuide ), typeof( GuildOrderOfficer ), typeof( Quest ), typeof( SpecialShop ), typeof( Story ), typeof( SwitchTalk ), typeof( TopicSelect ), typeof( TripleTriad ), typeof( Warp )], 1 );
    public readonly Collection<RowRef> ENpcData2 => new( page, offset, offset, &ENpcDataCtor2, 32 );

    static ENpcBase IExcelRow<ENpcBase>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "ChocoboTaxiStand" )]
public readonly struct ChocoboTaxiStand( ExcelPage page, uint offset, uint row ) : IExcelRow<ChocoboTaxiStand>
{
    public uint RowId => row;

    static ChocoboTaxiStand IExcelRow<ChocoboTaxiStand>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CraftLeve" )]
public readonly struct CraftLeve( ExcelPage page, uint offset, uint row ) : IExcelRow<CraftLeve>
{
    public uint RowId => row;

    static CraftLeve IExcelRow<CraftLeve>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CustomTalk" )]
public readonly struct CustomTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<CustomTalk>
{
    public uint RowId => row;

    static CustomTalk IExcelRow<CustomTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "DefaultTalk" )]
public readonly struct DefaultTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<DefaultTalk>
{
    public uint RowId => row;

    static DefaultTalk IExcelRow<DefaultTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "FccShop" )]
public readonly struct FccShop( ExcelPage page, uint offset, uint row ) : IExcelRow<FccShop>
{
    public uint RowId => row;

    static FccShop IExcelRow<FccShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GCShop" )]
public readonly struct GCShop( ExcelPage page, uint offset, uint row ) : IExcelRow<GCShop>
{
    public uint RowId => row;

    static GCShop IExcelRow<GCShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GilShop" )]
public readonly struct GilShop( ExcelPage page, uint offset, uint row ) : IExcelRow<GilShop>
{
    public uint RowId => row;

    static GilShop IExcelRow<GilShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildleveAssignment" )]
public readonly struct GuildleveAssignment( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildleveAssignment>
{
    public uint RowId => row;

    static GuildleveAssignment IExcelRow<GuildleveAssignment>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildOrderGuide" )]
public readonly struct GuildOrderGuide( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildOrderGuide>
{
    public uint RowId => row;

    static GuildOrderGuide IExcelRow<GuildOrderGuide>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "GuildOrderOfficer" )]
public readonly struct GuildOrderOfficer( ExcelPage page, uint offset, uint row ) : IExcelRow<GuildOrderOfficer>
{
    public uint RowId => row;

    static GuildOrderOfficer IExcelRow<GuildOrderOfficer>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Quest" )]
public readonly struct Quest( ExcelPage page, uint offset, uint row ) : IExcelRow<Quest>
{
    public uint RowId => row;

    static Quest IExcelRow<Quest>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "SpecialShop" )]
public readonly struct SpecialShop( ExcelPage page, uint offset, uint row ) : IExcelRow<SpecialShop>
{
    public uint RowId => row;

    static SpecialShop IExcelRow<SpecialShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Story" )]
public readonly struct Story( ExcelPage page, uint offset, uint row ) : IExcelRow<Story>
{
    public uint RowId => row;

    static Story IExcelRow<Story>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "SwitchTalk" )]
public readonly struct SwitchTalk( ExcelPage page, uint offset, uint row ) : IExcelRow<SwitchTalk>
{
    public uint RowId => row;

    static SwitchTalk IExcelRow<SwitchTalk>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "TopicSelect" )]
public readonly unsafe struct TopicSelect( ExcelPage page, uint offset, uint row ) : IExcelRow<TopicSelect>
{
    public uint RowId => row;

    private static RowRef ShopCtor( ExcelPage page, uint parentOffset, uint offset, uint i ) => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + 4 + i * 4 ), [typeof( SpecialShop ), typeof( GilShop ), typeof( PreHandler )], 2 );
    public readonly Collection<RowRef> Shop => new( page, offset, offset, &ShopCtor, 10 );

    static TopicSelect IExcelRow<TopicSelect>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "TripleTriad" )]
public readonly struct TripleTriad( ExcelPage page, uint offset, uint row ) : IExcelRow<TripleTriad>
{
    public uint RowId => row;

    static TripleTriad IExcelRow<TripleTriad>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Warp" )]
public readonly struct Warp( ExcelPage page, uint offset, uint row ) : IExcelRow<Warp>
{
    public uint RowId => row;

    static Warp IExcelRow<Warp>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "PreHandler" )]
public readonly struct PreHandler( ExcelPage page, uint offset, uint row ) : IExcelRow<PreHandler>
{
    public uint RowId => row;

    public readonly RowRef Target => RowRef.GetFirstValidRowOrUntyped( page.Module, page.ReadUInt32( offset + 8 ), [typeof( CollectablesShop ), typeof( InclusionShop ), typeof( GilShop ), typeof( SpecialShop ), typeof( Description )], 3 );

    static PreHandler IExcelRow<PreHandler>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "CollectablesShop" )]
public readonly struct CollectablesShop( ExcelPage page, uint offset, uint row ) : IExcelRow<CollectablesShop>
{
    public uint RowId => row;

    static CollectablesShop IExcelRow<CollectablesShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "InclusionShop" )]
public readonly struct InclusionShop( ExcelPage page, uint offset, uint row ) : IExcelRow<InclusionShop>
{
    public uint RowId => row;

    static InclusionShop IExcelRow<InclusionShop>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}

[Sheet( "Description" )]
public readonly struct Description( ExcelPage page, uint offset, uint row ) : IExcelRow<Description>
{
    public uint RowId => row;

    static Description IExcelRow<Description>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}