using Lumina.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lumina.Tests;

public class ExcelTests
{
    [RequiresGameInstallationFact]
    public void RowRefIntervalTree()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        var types = new Type[] { typeof( ChocoboTaxiStand ), typeof( CraftLeve ), typeof( CustomTalk ), typeof( DefaultTalk ), typeof( FccShop ), typeof( GCShop ), typeof( GilShop ), typeof( GuildleveAssignment ), typeof( GuildOrderGuide ), typeof( GuildOrderOfficer ), typeof( Quest ), typeof( SpecialShop ), typeof( Story ), typeof( SwitchTalk ), typeof( TopicSelect ), typeof( TripleTriad ), typeof( Warp ) };
        var sheets = new List<(string, RawExcelSheet)>();
        foreach( var t in types )
        {
            var n = t.Name;
            var sheet = gameData.Excel.GetRawSheet( n );
            sheets.Add( (n, sheet) );
        }

        var s = new StringBuilder();
        foreach( var npc in gameData.GetExcelSheet<ENpcBase>()! )
        {
            foreach( var variable in npc.ENpcData )
            {
                var found = false;
                foreach( var (name, sheet) in sheets )
                {
                    if( sheet.HasRow( variable ) )
                    {
                        found = true;
                        s.AppendLine( name );
                        break;
                    }
                }
                if( !found )
                    s.AppendLine( "unk" );
            }
        }
        var brute = s.ToString();

        s.Clear();
        foreach( var npc in gameData.GetExcelSheet<ENpcBase>()! )
        {
            foreach( var variable in npc.ENpcData2 )
            {
                if( variable.Is<ChocoboTaxiStand>() )
                    s.AppendLine( "ChocoboTaxiStand" );
                else if( variable.Is<CraftLeve>() )
                    s.AppendLine( "CraftLeve" );
                else if( variable.Is<CustomTalk>() )
                    s.AppendLine( "CustomTalk" );
                else if( variable.Is<DefaultTalk>() )
                    s.AppendLine( "DefaultTalk" );
                else if( variable.Is<FccShop>() )
                    s.AppendLine( "FccShop" );
                else if( variable.Is<GCShop>() )
                    s.AppendLine( "GCShop" );
                else if( variable.Is<GilShop>() )
                    s.AppendLine( "GilShop" );
                else if( variable.Is<GuildleveAssignment>() )
                    s.AppendLine( "GuildleveAssignment" );
                else if( variable.Is<GuildOrderGuide>() )
                    s.AppendLine( "GuildOrderGuide" );
                else if( variable.Is<GuildOrderOfficer>() )
                    s.AppendLine( "GuildOrderOfficer" );
                else if( variable.Is<Quest>() )
                    s.AppendLine( "Quest" );
                else if( variable.Is<SpecialShop>() )
                    s.AppendLine( "SpecialShop" );
                else if( variable.Is<Story>() )
                    s.AppendLine( "Story" );
                else if( variable.Is<SwitchTalk>() )
                    s.AppendLine( "SwitchTalk" );
                else if( variable.Is<TopicSelect>() )
                    s.AppendLine( "TopicSelect" );
                else if( variable.Is<TripleTriad>() )
                    s.AppendLine( "TripleTriad" );
                else if( variable.Is<Warp>() )
                    s.AppendLine( "Warp" );
                else
                    s.AppendLine( "unk" );
            }
        }
        var interval = s.ToString();

        Assert.Equal( brute, interval );
    }

    [RequiresGameInstallationFact]
    public void IndirectStringSheet()
    {
        var gameData = RequiresGameInstallationFact.CreateGameData();

        var row = gameData.GetExcelSheet<GatheringPointBase>()!.GetRow( 30 );
        var name = row.GatheringType.ValueNullable?.Name;
        Assert.Equal( "Harvesting", name );
    }
}
