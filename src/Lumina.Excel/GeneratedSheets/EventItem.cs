// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItem", columnHash: 0x2a1d4fb2 )]
    public partial class EventItem : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public bool Unknown8 { get; set; }
        public SeString Name { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< Action > Action { get; set; }
        public byte StackSize { get; set; }
        public byte Unknown13 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte CastTime { get; set; }
        public LazyRow< EventItemCastTimeline > CastTimeline { get; set; }
        public byte Timeline { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Icon = parser.ReadColumn< ushort >( 10 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            StackSize = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 14 ), language );
            CastTime = parser.ReadColumn< byte >( 15 );
            CastTimeline = new LazyRow< EventItemCastTimeline >( gameData, parser.ReadColumn< byte >( 16 ), language );
            Timeline = parser.ReadColumn< byte >( 17 );
        }
    }
}