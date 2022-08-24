// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionDetail", columnHash: 0x62246edb )]
    public partial class SkyIsland2MissionDetail : ExcelRow
    {
        
        public LazyRow< SkyIsland2MissionType > Type { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< SkyIsland2RangeType > Range { get; set; }
        public sbyte Unknown3 { get; set; }
        public LazyRow< EObjName > EObj { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public SeString Objective { get; set; }
        public SeString Unknown8 { get; set; }
        public SeString Unknown9 { get; set; }
        public SeString Unknown10 { get; set; }
        
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