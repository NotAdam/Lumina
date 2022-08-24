// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Emote", columnHash: 0xf3afded2 )]
    public partial class Emote : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< ActionTimeline >[] ActionTimeline { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public bool Unknown10 { get; set; }
        public LazyRow< EmoteCategory > EmoteCategory { get; set; }
        public LazyRow< EmoteMode > EmoteMode { get; set; }
        public bool Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        public bool HasCancelEmote { get; set; }
        public bool DrawsWeapon { get; set; }
        public bool Unknown17 { get; set; }
        public ushort Order { get; set; }
        public LazyRow< TextCommand > TextCommand { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< LogMessage > LogMessageTargeted { get; set; }
        public LazyRow< LogMessage > LogMessageUntargeted { get; set; }
        public uint UnlockLink { get; set; }
        public ushort Unknown24 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            ActionTimeline = new LazyRow< ActionTimeline >[ 7 ];
            for( var i = 0; i < 7; i++ )
                ActionTimeline[ i ] = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 1 + i ), language );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            EmoteCategory = new LazyRow< EmoteCategory >( gameData, parser.ReadColumn< byte >( 11 ), language );
            EmoteMode = new LazyRow< EmoteMode >( gameData, parser.ReadColumn< byte >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            HasCancelEmote = parser.ReadColumn< bool >( 15 );
            DrawsWeapon = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Order = parser.ReadColumn< ushort >( 18 );
            TextCommand = new LazyRow< TextCommand >( gameData, parser.ReadColumn< int >( 19 ), language );
            Icon = parser.ReadColumn< ushort >( 20 );
            LogMessageTargeted = new LazyRow< LogMessage >( gameData, parser.ReadColumn< ushort >( 21 ), language );
            LogMessageUntargeted = new LazyRow< LogMessage >( gameData, parser.ReadColumn< ushort >( 22 ), language );
            UnlockLink = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
        }
    }
}