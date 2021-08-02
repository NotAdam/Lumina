// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineExploration", columnHash: 0xff922bb4 )]
    public partial class SubmarineExploration : ExcelRow
    {
        
        public SeString Destination { get; set; }
        public SeString Location { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Unknown4 { get; set; }
        public LazyRow< SubmarineMap > Map { get; set; }
        public bool Unknown6 { get; set; }
        public byte Stars { get; set; }
        public byte RankReq { get; set; }
        public byte CeruleumTankReq { get; set; }
        public ushort Durationmin { get; set; }
        public byte DistanceForSurvey { get; set; }
        public uint ExpReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Destination = parser.ReadColumn< SeString >( 0 );
            Location = parser.ReadColumn< SeString >( 1 );
            X = parser.ReadColumn< short >( 2 );
            Y = parser.ReadColumn< short >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Map = new LazyRow< SubmarineMap >( gameData, parser.ReadColumn< byte >( 5 ), language );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Stars = parser.ReadColumn< byte >( 7 );
            RankReq = parser.ReadColumn< byte >( 8 );
            CeruleumTankReq = parser.ReadColumn< byte >( 9 );
            Durationmin = parser.ReadColumn< ushort >( 10 );
            DistanceForSurvey = parser.ReadColumn< byte >( 11 );
            ExpReward = parser.ReadColumn< uint >( 12 );
        }
    }
}