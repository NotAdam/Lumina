// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftAction", columnHash: 0x6057073b )]
    public partial class CraftAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public LazyRow< ActionTimeline > AnimationStart { get; set; }
        public LazyRow< ActionTimeline > AnimationEnd { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte ClassJobLevel { get; set; }
        public LazyRow< Quest > QuestRequirement { get; set; }
        public bool Specialist { get; set; }
        public ushort Unknown10 { get; set; }
        public byte Cost { get; set; }
        public LazyRow< CraftAction > CRP { get; set; }
        public LazyRow< CraftAction > BSM { get; set; }
        public LazyRow< CraftAction > ARM { get; set; }
        public LazyRow< CraftAction > GSM { get; set; }
        public LazyRow< CraftAction > LTW { get; set; }
        public LazyRow< CraftAction > WVR { get; set; }
        public LazyRow< CraftAction > ALC { get; set; }
        public LazyRow< CraftAction > CUL { get; set; }
        
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