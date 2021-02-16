// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Map", columnHash: 0x56a0aa07 )]
    public class Map : ExcelRow
    {
        
        public byte MapCondition;
        public byte PriorityCategoryUI;
        public byte PriorityUI;
        public sbyte MapIndex;
        public byte Hierarchy;
        public ushort MapMarkerRange;
        public SeString Id;
        public ushort SizeFactor;
        public short OffsetX;
        public short OffsetY;
        public LazyRow< PlaceName > PlaceNameRegion;
        public LazyRow< PlaceName > PlaceName;
        public LazyRow< PlaceName > PlaceNameSub;
        public short DiscoveryIndex;
        public uint DiscoveryFlag;
        public LazyRow< TerritoryType > TerritoryType;
        public bool DiscoveryArrayByte;
        public bool IsEvent;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MapCondition = parser.ReadColumn< byte >( 0 );
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
        }
    }
}