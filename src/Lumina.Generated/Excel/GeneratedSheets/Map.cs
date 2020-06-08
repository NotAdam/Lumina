using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Map", columnHash: 0x56a0aa07 )]
    public class Map : IExcelRow
    {
        
        public byte MapCondition;
        public byte PriorityCategoryUI;
        public byte PriorityUI;
        public sbyte MapIndex;
        public byte Hierarchy;
        public ushort MapMarkerRange;
        public string Id;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            MapCondition = parser.ReadColumn< byte >( 0 );
            PriorityCategoryUI = parser.ReadColumn< byte >( 1 );
            PriorityUI = parser.ReadColumn< byte >( 2 );
            MapIndex = parser.ReadColumn< sbyte >( 3 );
            Hierarchy = parser.ReadColumn< byte >( 4 );
            MapMarkerRange = parser.ReadColumn< ushort >( 5 );
            Id = parser.ReadColumn< string >( 6 );
            SizeFactor = parser.ReadColumn< ushort >( 7 );
            OffsetX = parser.ReadColumn< short >( 8 );
            OffsetY = parser.ReadColumn< short >( 9 );
            PlaceNameRegion = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 10 ) );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 11 ) );
            PlaceNameSub = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 12 ) );
            DiscoveryIndex = parser.ReadColumn< short >( 13 );
            DiscoveryFlag = parser.ReadColumn< uint >( 14 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 15 ) );
            DiscoveryArrayByte = parser.ReadColumn< bool >( 16 );
            IsEvent = parser.ReadColumn< bool >( 17 );
        }
    }
}