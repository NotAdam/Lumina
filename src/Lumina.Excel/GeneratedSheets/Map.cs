// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Map", columnHash: 0x4a6baf49 )]
    public partial class Map : ExcelRow
    {
        
        public LazyRow< MapCondition > MapCondition { get; set; }
        public byte PriorityCategoryUI { get; set; }
        public byte PriorityUI { get; set; }
        public sbyte MapIndex { get; set; }
        public byte Hierarchy { get; set; }
        public ushort MapMarkerRange { get; set; }
        public SeString Id { get; set; }
        public ushort SizeFactor { get; set; }
        public short OffsetX { get; set; }
        public short OffsetY { get; set; }
        public LazyRow< PlaceName > PlaceNameRegion { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public LazyRow< PlaceName > PlaceNameSub { get; set; }
        public short DiscoveryIndex { get; set; }
        public uint DiscoveryFlag { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public bool DiscoveryArrayByte { get; set; }
        public bool IsEvent { get; set; }
        public bool Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MapCondition = new LazyRow< MapCondition >( gameData, parser.ReadColumn< byte >( 0 ), language );
            PriorityCategoryUI = parser.ReadColumn< byte >( 1 );
            PriorityUI = parser.ReadColumn< byte >( 2 );
            MapIndex = parser.ReadColumn< sbyte >( 3 );
            Hierarchy = parser.ReadColumn< byte >( 4 );
            MapMarkerRange = parser.ReadColumn< ushort >( 5 );
            Id = parser.ReadColumn< SeString >( 6 );
            SizeFactor = parser.ReadColumn< ushort >( 7 );
            OffsetX = parser.ReadColumn< short >( 8 );
            OffsetY = parser.ReadColumn< short >( 9 );
            PlaceNameRegion = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 12 ), language );
            DiscoveryIndex = parser.ReadColumn< short >( 13 );
            DiscoveryFlag = parser.ReadColumn< uint >( 14 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 15 ), language );
            DiscoveryArrayByte = parser.ReadColumn< bool >( 16 );
            IsEvent = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
        }
    }
}