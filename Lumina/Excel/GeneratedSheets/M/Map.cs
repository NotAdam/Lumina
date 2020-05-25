using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Map", columnHash: 0x56a0aa07 )]
    public class Map : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 06 offset: 0000
        public string Id;

        // col: 14 offset: 0004
        public uint DiscoveryFlag;

        // col: 05 offset: 0008
        public ushort MapMarkerRange;

        // col: 07 offset: 000a
        public ushort SizeFactor;

        // col: 10 offset: 000c
        public ushort PlaceNameRegion;

        // col: 11 offset: 000e
        public ushort PlaceName;

        // col: 12 offset: 0010
        public ushort PlaceNameSub;

        // col: 15 offset: 0012
        public ushort TerritoryType;

        // col: 08 offset: 0014
        public short OffsetX;

        // col: 09 offset: 0016
        public short OffsetY;

        // col: 13 offset: 0018
        public short DiscoveryIndex;

        // col: 00 offset: 001a
        public byte MapCondition;

        // col: 01 offset: 001b
        public byte PriorityCategoryUI;

        // col: 02 offset: 001c
        public byte PriorityUI;

        // col: 04 offset: 001d
        public byte Hierarchy;

        // col: 03 offset: 001e
        public sbyte MapIndex;

        // col: 16 offset: 001f
        public bool DiscoveryArrayByte;
        public byte packed1f;
        public bool IsEvent;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            Id = parser.ReadOffset< string >( 0x0 );

            // col: 14 offset: 0004
            DiscoveryFlag = parser.ReadOffset< uint >( 0x4 );

            // col: 5 offset: 0008
            MapMarkerRange = parser.ReadOffset< ushort >( 0x8 );

            // col: 7 offset: 000a
            SizeFactor = parser.ReadOffset< ushort >( 0xa );

            // col: 10 offset: 000c
            PlaceNameRegion = parser.ReadOffset< ushort >( 0xc );

            // col: 11 offset: 000e
            PlaceName = parser.ReadOffset< ushort >( 0xe );

            // col: 12 offset: 0010
            PlaceNameSub = parser.ReadOffset< ushort >( 0x10 );

            // col: 15 offset: 0012
            TerritoryType = parser.ReadOffset< ushort >( 0x12 );

            // col: 8 offset: 0014
            OffsetX = parser.ReadOffset< short >( 0x14 );

            // col: 9 offset: 0016
            OffsetY = parser.ReadOffset< short >( 0x16 );

            // col: 13 offset: 0018
            DiscoveryIndex = parser.ReadOffset< short >( 0x18 );

            // col: 0 offset: 001a
            MapCondition = parser.ReadOffset< byte >( 0x1a );

            // col: 1 offset: 001b
            PriorityCategoryUI = parser.ReadOffset< byte >( 0x1b );

            // col: 2 offset: 001c
            PriorityUI = parser.ReadOffset< byte >( 0x1c );

            // col: 4 offset: 001d
            Hierarchy = parser.ReadOffset< byte >( 0x1d );

            // col: 3 offset: 001e
            MapIndex = parser.ReadOffset< sbyte >( 0x1e );

            // col: 16 offset: 001f
            packed1f = parser.ReadOffset< byte >( 0x1f, ExcelColumnDataType.UInt8 );

            DiscoveryArrayByte = ( packed1f & 0x1 ) == 0x1;
            IsEvent = ( packed1f & 0x2 ) == 0x2;


        }
    }
}