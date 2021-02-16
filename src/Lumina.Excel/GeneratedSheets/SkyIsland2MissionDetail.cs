// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionDetail", columnHash: 0x62246edb )]
    public class SkyIsland2MissionDetail : ExcelRow
    {
        
        public LazyRow< SkyIsland2MissionType > Type;
        public byte Unknown1;
        public LazyRow< SkyIsland2RangeType > Range;
        public sbyte Unknown3;
        public LazyRow< EObjName > EObj;
        public uint Unknown5;
        public uint Unknown6;
        public SeString Objective;
        public SeString Unknown8;
        public SeString Unknown9;
        public SeString Unknown10;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = new LazyRow< SkyIsland2MissionType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Range = new LazyRow< SkyIsland2RangeType >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            EObj = new LazyRow< EObjName >( gameData, parser.ReadColumn< uint >( 4 ), language );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Objective = parser.ReadColumn< SeString >( 7 );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
            Unknown9 = parser.ReadColumn< SeString >( 9 );
            Unknown10 = parser.ReadColumn< SeString >( 10 );
        }
    }
}