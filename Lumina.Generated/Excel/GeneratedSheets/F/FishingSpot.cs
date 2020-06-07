using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingSpot", columnHash: 0x0a291860 )]
    public class FishingSpot : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string BigFishOnReach;

        // col: 02 offset: 0004
        public string BigFishOnEnd;

        // col: 12 offset: 0008
        public int[] Item;

        // col: 05 offset: 0030
        public ushort TerritoryType;

        // col: 06 offset: 0032
        public ushort PlaceNameMain;

        // col: 07 offset: 0034
        public ushort PlaceNameSub;

        // col: 10 offset: 0036
        public ushort Radius;

        // col: 22 offset: 0038
        public ushort PlaceName;

        // col: 08 offset: 003a
        public short X;

        // col: 09 offset: 003c
        public short Z;

        // col: 00 offset: 003e
        public byte GatheringLevel;

        // col: 03 offset: 003f
        public byte FishingSpotCategory;

        // col: 11 offset: 0040
        public byte unknown40;

        // col: 23 offset: 0041
        public byte Order;

        // col: 04 offset: 0042
        public bool Rare;
        public byte packed42;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            BigFishOnReach = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            BigFishOnEnd = parser.ReadOffset< string >( 0x4 );

            // col: 12 offset: 0008
            Item = new int[10];
            Item[0] = parser.ReadOffset< int >( 0x8 );
            Item[1] = parser.ReadOffset< int >( 0xc );
            Item[2] = parser.ReadOffset< int >( 0x10 );
            Item[3] = parser.ReadOffset< int >( 0x14 );
            Item[4] = parser.ReadOffset< int >( 0x18 );
            Item[5] = parser.ReadOffset< int >( 0x1c );
            Item[6] = parser.ReadOffset< int >( 0x20 );
            Item[7] = parser.ReadOffset< int >( 0x24 );
            Item[8] = parser.ReadOffset< int >( 0x28 );
            Item[9] = parser.ReadOffset< int >( 0x2c );

            // col: 5 offset: 0030
            TerritoryType = parser.ReadOffset< ushort >( 0x30 );

            // col: 6 offset: 0032
            PlaceNameMain = parser.ReadOffset< ushort >( 0x32 );

            // col: 7 offset: 0034
            PlaceNameSub = parser.ReadOffset< ushort >( 0x34 );

            // col: 10 offset: 0036
            Radius = parser.ReadOffset< ushort >( 0x36 );

            // col: 22 offset: 0038
            PlaceName = parser.ReadOffset< ushort >( 0x38 );

            // col: 8 offset: 003a
            X = parser.ReadOffset< short >( 0x3a );

            // col: 9 offset: 003c
            Z = parser.ReadOffset< short >( 0x3c );

            // col: 0 offset: 003e
            GatheringLevel = parser.ReadOffset< byte >( 0x3e );

            // col: 3 offset: 003f
            FishingSpotCategory = parser.ReadOffset< byte >( 0x3f );

            // col: 11 offset: 0040
            unknown40 = parser.ReadOffset< byte >( 0x40 );

            // col: 23 offset: 0041
            Order = parser.ReadOffset< byte >( 0x41 );

            // col: 4 offset: 0042
            packed42 = parser.ReadOffset< byte >( 0x42, ExcelColumnDataType.UInt8 );

            Rare = ( packed42 & 0x1 ) == 0x1;


        }
    }
}