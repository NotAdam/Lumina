// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContentBriefingBNpc", columnHash: 0xfc0810d7 )]
    public partial class AOZContentBriefingBNpc : ExcelRow
    {
        
        public LazyRow< BNpcName > BNpcName { get; set; }
        public uint TargetSmall { get; set; }
        public uint TargetLarge { get; set; }
        public bool HideStats { get; set; }
        public byte Endurance { get; set; }
        public byte Fire { get; set; }
        public byte Ice { get; set; }
        public byte Wind { get; set; }
        public byte Earth { get; set; }
        public byte Thunder { get; set; }
        public byte Water { get; set; }
        public byte Slashing { get; set; }
        public byte Piercing { get; set; }
        public byte Blunt { get; set; }
        public byte Magic { get; set; }
        public bool SlowVuln { get; set; }
        public bool PetrificationVuln { get; set; }
        public bool ParalysisVuln { get; set; }
        public bool InterruptionVuln { get; set; }
        public bool BlindVuln { get; set; }
        public bool StunVuln { get; set; }
        public bool SleepVuln { get; set; }
        public bool BindVuln { get; set; }
        public bool HeavyVuln { get; set; }
        public bool FlatOrDeathVuln { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< uint >( 0 ), language );
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