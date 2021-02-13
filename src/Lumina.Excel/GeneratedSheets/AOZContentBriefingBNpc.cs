// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContentBriefingBNpc", columnHash: 0xfc0810d7 )]
    public class AOZContentBriefingBNpc : ExcelRow
    {
        
        public LazyRow< BNpcName > BNpcName;
        public uint TargetSmall;
        public uint TargetLarge;
        public bool HideStats;
        public byte Endurance;
        public byte Fire;
        public byte Ice;
        public byte Wind;
        public byte Earth;
        public byte Thunder;
        public byte Water;
        public byte Slashing;
        public byte Piercing;
        public byte Blunt;
        public byte Magic;
        public bool SlowVuln;
        public bool PetrificationVuln;
        public bool ParalysisVuln;
        public bool InterruptionVuln;
        public bool BlindVuln;
        public bool StunVuln;
        public bool SleepVuln;
        public bool BindVuln;
        public bool HeavyVuln;
        public bool FlatOrDeathVuln;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 0 ), language );
            TargetSmall = parser.ReadColumn< uint >( 1 );
            TargetLarge = parser.ReadColumn< uint >( 2 );
            HideStats = parser.ReadColumn< bool >( 3 );
            Endurance = parser.ReadColumn< byte >( 4 );
            Fire = parser.ReadColumn< byte >( 5 );
            Ice = parser.ReadColumn< byte >( 6 );
            Wind = parser.ReadColumn< byte >( 7 );
            Earth = parser.ReadColumn< byte >( 8 );
            Thunder = parser.ReadColumn< byte >( 9 );
            Water = parser.ReadColumn< byte >( 10 );
            Slashing = parser.ReadColumn< byte >( 11 );
            Piercing = parser.ReadColumn< byte >( 12 );
            Blunt = parser.ReadColumn< byte >( 13 );
            Magic = parser.ReadColumn< byte >( 14 );
            SlowVuln = parser.ReadColumn< bool >( 15 );
            PetrificationVuln = parser.ReadColumn< bool >( 16 );
            ParalysisVuln = parser.ReadColumn< bool >( 17 );
            InterruptionVuln = parser.ReadColumn< bool >( 18 );
            BlindVuln = parser.ReadColumn< bool >( 19 );
            StunVuln = parser.ReadColumn< bool >( 20 );
            SleepVuln = parser.ReadColumn< bool >( 21 );
            BindVuln = parser.ReadColumn< bool >( 22 );
            HeavyVuln = parser.ReadColumn< bool >( 23 );
            FlatOrDeathVuln = parser.ReadColumn< bool >( 24 );
        }
    }
}