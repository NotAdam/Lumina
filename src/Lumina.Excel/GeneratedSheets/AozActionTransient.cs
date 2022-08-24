// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozActionTransient", columnHash: 0x4921bb28 )]
    public partial class AozActionTransient : ExcelRow
    {
        
        public byte Number { get; set; }
        public uint Icon { get; set; }
        public SeString Stats { get; set; }
        public SeString Description { get; set; }
        public byte LocationKey { get; set; }
        public ushort Location { get; set; }
        public LazyRow< Quest > RequiredForQuest { get; set; }
        public LazyRow< Quest > PreviousQuest { get; set; }
        public bool TargetsEnemy { get; set; }
        public bool TargetsSelfOrAlly { get; set; }
        public bool CauseSlow { get; set; }
        public bool CausePetrify { get; set; }
        public bool CauseParalysis { get; set; }
        public bool CauseInterrupt { get; set; }
        public bool CauseBlind { get; set; }
        public bool CauseStun { get; set; }
        public bool CauseSleep { get; set; }
        public bool CauseBind { get; set; }
        public bool CauseHeavy { get; set; }
        public bool CauseDeath { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Number = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Stats = parser.ReadColumn< SeString >( 2 );
            Description = parser.ReadColumn< SeString >( 3 );
            LocationKey = parser.ReadColumn< byte >( 4 );
            Location = parser.ReadColumn< ushort >( 5 );
            RequiredForQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 6 ), language );
            PreviousQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 7 ), language );
            TargetsEnemy = parser.ReadColumn< bool >( 8 );
            TargetsSelfOrAlly = parser.ReadColumn< bool >( 9 );
            CauseSlow = parser.ReadColumn< bool >( 10 );
            CausePetrify = parser.ReadColumn< bool >( 11 );
            CauseParalysis = parser.ReadColumn< bool >( 12 );
            CauseInterrupt = parser.ReadColumn< bool >( 13 );
            CauseBlind = parser.ReadColumn< bool >( 14 );
            CauseStun = parser.ReadColumn< bool >( 15 );
            CauseSleep = parser.ReadColumn< bool >( 16 );
            CauseBind = parser.ReadColumn< bool >( 17 );
            CauseHeavy = parser.ReadColumn< bool >( 18 );
            CauseDeath = parser.ReadColumn< bool >( 19 );
        }
    }
}