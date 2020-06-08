using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItem", columnHash: 0x2a1d4fb2 )]
    public class EventItem : IExcelRow
    {
        
        public string Singular;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public bool Unknown8;
        public string Name;
        public ushort Icon;
        public LazyRow< Action > Action;
        public byte StackSize;
        public byte Unknown13;
        public LazyRow< Quest > Quest;
        public byte CastTime;
        public LazyRow< EventItemCastTimeline > CastTimeline;
        public byte Timeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Singular = parser.ReadColumn< string >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< string >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Name = parser.ReadColumn< string >( 9 );
            Icon = parser.ReadColumn< ushort >( 10 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 11 ) );
            StackSize = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 14 ) );
            CastTime = parser.ReadColumn< byte >( 15 );
            CastTimeline = new LazyRow< EventItemCastTimeline >( lumina, parser.ReadColumn< byte >( 16 ) );
            Timeline = parser.ReadColumn< byte >( 17 );
        }
    }
}