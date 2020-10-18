// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Emote", columnHash: 0xc4735d67 )]
    public class Emote : IExcelRow
    {
        
        public SeString Name;
        public LazyRow< ActionTimeline >[] ActionTimeline;
        public bool Unknown8;
        public bool Unknown9;
        public bool Unknown10;
        public LazyRow< EmoteCategory > EmoteCategory;
        public LazyRow< EmoteMode > EmoteMode;
        public bool Unknown13;
        public bool Unknown14;
        public bool HasCancelEmote;
        public bool DrawsWeapon;
        public ushort Unknown17;
        public LazyRow< TextCommand > TextCommand;
        public ushort Icon;
        public LazyRow< LogMessage > LogMessageTargeted;
        public LazyRow< LogMessage > LogMessageUntargeted;
        public uint UnlockLink;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            ActionTimeline = new LazyRow< ActionTimeline >[ 7 ];
            for( var i = 0; i < 7; i++ )
                ActionTimeline[ i ] = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 + i ), language );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            EmoteCategory = new LazyRow< EmoteCategory >( lumina, parser.ReadColumn< byte >( 11 ), language );
            EmoteMode = new LazyRow< EmoteMode >( lumina, parser.ReadColumn< byte >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            HasCancelEmote = parser.ReadColumn< bool >( 15 );
            DrawsWeapon = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< ushort >( 17 );
            TextCommand = new LazyRow< TextCommand >( lumina, parser.ReadColumn< int >( 18 ), language );
            Icon = parser.ReadColumn< ushort >( 19 );
            LogMessageTargeted = new LazyRow< LogMessage >( lumina, parser.ReadColumn< ushort >( 20 ), language );
            LogMessageUntargeted = new LazyRow< LogMessage >( lumina, parser.ReadColumn< ushort >( 21 ), language );
            UnlockLink = parser.ReadColumn< uint >( 22 );
        }
    }
}