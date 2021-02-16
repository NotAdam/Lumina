// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineExploration", columnHash: 0xff922bb4 )]
    public class SubmarineExploration : ExcelRow
    {
        
        public SeString Destination;
        public SeString Location;
        public short Unknown2;
        public short Unknown3;
        public short Unknown4;
        public LazyRow< SubmarineMap > Map;
        public bool Unknown6;
        public byte Stars;
        public byte RankReq;
        public byte CeruleumTankReq;
        public ushort Durationmin;
        public byte DistanceForSurvey;
        public uint ExpReward;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Destination = parser.ReadColumn< SeString >( 0 );
            Location = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< short >( 3 );
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