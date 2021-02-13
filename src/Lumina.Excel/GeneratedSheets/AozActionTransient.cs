// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozActionTransient", columnHash: 0x4921bb28 )]
    public class AozActionTransient : ExcelRow
    {
        
        public byte Number;
        public uint Icon;
        public SeString Stats;
        public SeString Description;
        public byte LocationKey;
        public ushort Location;
        public LazyRow< Quest > RequiredForQuest;
        public LazyRow< Quest > PreviousQuest;
        public bool TargetsEnemy;
        public bool TargetsSelfOrAlly;
        public bool CauseSlow;
        public bool CausePetrify;
        public bool CauseParalysis;
        public bool CauseInterrupt;
        public bool CauseBlind;
        public bool CauseStun;
        public bool CauseSleep;
        public bool CauseBind;
        public bool CauseHeavy;
        public bool CauseDeath;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Number = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Stats = parser.ReadColumn< SeString >( 2 );
            Description = parser.ReadColumn< SeString >( 3 );
            LocationKey = parser.ReadColumn< byte >( 4 );
            Location = parser.ReadColumn< ushort >( 5 );
            RequiredForQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 6 ), language );
            PreviousQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 7 ), language );
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