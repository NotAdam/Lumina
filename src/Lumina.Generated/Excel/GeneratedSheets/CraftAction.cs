using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftAction", columnHash: 0x6057073b )]
    public class CraftAction : IExcelRow
    {
        
        public string Name;
        public string Description;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            AnimationStart = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 2 ) );
            AnimationEnd = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 3 ) );
            Icon = parser.ReadColumn< ushort >( 4 );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< sbyte >( 5 ) );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 6 ) );
            ClassJobLevel = parser.ReadColumn< byte >( 7 );
            QuestRequirement = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 8 ) );
            Specialist = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Cost = parser.ReadColumn< byte >( 11 );
            CRP = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 12 ) );
            BSM = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 13 ) );
            ARM = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 14 ) );
            GSM = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 15 ) );
            LTW = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 16 ) );
            WVR = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 17 ) );
            ALC = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 18 ) );
            CUL = new LazyRow< CraftAction >( lumina, parser.ReadColumn< int >( 19 ) );
        }
    }
}