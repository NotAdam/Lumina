// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftAction", columnHash: 0x6057073b )]
    public class CraftAction : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public LazyRow< ActionTimeline > AnimationStart;
        public LazyRow< ActionTimeline > AnimationEnd;
        public ushort Icon;
        public LazyRow< ClassJob > ClassJob;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public byte ClassJobLevel;
        public LazyRow< Quest > QuestRequirement;
        public bool Specialist;
        public ushort Unknown10;
        public byte Cost;
        public LazyRow< CraftAction > CRP;
        public LazyRow< CraftAction > BSM;
        public LazyRow< CraftAction > ARM;
        public LazyRow< CraftAction > GSM;
        public LazyRow< CraftAction > LTW;
        public LazyRow< CraftAction > WVR;
        public LazyRow< CraftAction > ALC;
        public LazyRow< CraftAction > CUL;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            AnimationStart = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Icon = parser.ReadColumn< ushort >( 4 );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< sbyte >( 5 ), language );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 6 ), language );
            ClassJobLevel = parser.ReadColumn< byte >( 7 );
            QuestRequirement = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 8 ), language );
            Specialist = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Cost = parser.ReadColumn< byte >( 11 );
            CRP = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 12 ), language );
            BSM = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 13 ), language );
            ARM = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 14 ), language );
            GSM = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 15 ), language );
            LTW = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 16 ), language );
            WVR = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 17 ), language );
            ALC = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 18 ), language );
            CUL = new LazyRow< CraftAction >( gameData, parser.ReadColumn< int >( 19 ), language );
        }
    }
}