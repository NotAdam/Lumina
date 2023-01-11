// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2Mission", columnHash: 0xec50a29c )]
    public partial class SkyIsland2Mission : ExcelRow
    {
        
        public LazyRow< EventItem > Item1 { get; set; }
        public LazyRow< EventItem > Item2 { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public ushort Unknown3 { get; set; }
        public LazyRow< SkyIsland2MissionDetail > Objective1 { get; set; }
        public uint PopRange0 { get; set; }
        public byte RequiredAmount1 { get; set; }
        public uint Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public LazyRow< SkyIsland2MissionDetail > Objective2 { get; set; }
        public uint PopRange1 { get; set; }
        public byte RequiredAmount2 { get; set; }
        public uint Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public LazyRow< SkyIsland2MissionDetail > Objective3 { get; set; }
        public uint PopRange2 { get; set; }
        public byte Unknown16 { get; set; }
        public uint Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public uint Unknown19 { get; set; }
        public uint Image { get; set; }
        public SeString Unknown21 { get; set; }
        public SeString Unknown22 { get; set; }
        public SeString Unknown23 { get; set; }
        public SeString Unknown24 { get; set; }
        public SeString Unknown25 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item1 = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Item2 = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 1 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Objective1 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            PopRange0 = parser.ReadColumn< uint >( 5 );
            RequiredAmount1 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Objective2 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            PopRange1 = parser.ReadColumn< uint >( 10 );
            RequiredAmount2 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Objective3 = new LazyRow< SkyIsland2MissionDetail >( gameData, parser.ReadColumn< ushort >( 14 ), language );
            PopRange2 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Image = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< SeString >( 21 );
            Unknown22 = parser.ReadColumn< SeString >( 22 );
            Unknown23 = parser.ReadColumn< SeString >( 23 );
            Unknown24 = parser.ReadColumn< SeString >( 24 );
            Unknown25 = parser.ReadColumn< SeString >( 25 );
        }
    }
}