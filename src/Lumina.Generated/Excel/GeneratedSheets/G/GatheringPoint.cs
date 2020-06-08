using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPoint", columnHash: 0x4f531171 )]
    public class GatheringPoint : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int GatheringPointBase;

        // col: 03 offset: 0004
        public ushort[] GatheringPointBonus;

        // col: 05 offset: 0008
        public ushort TerritoryType;

        // col: 06 offset: 000a
        public ushort PlaceName;

        // col: 07 offset: 000c
        public ushort GatheringSubCategory;

        // col: 00 offset: 000e
        public byte Type;

        // col: 02 offset: 000f
        public byte Count;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            GatheringPointBase = parser.ReadOffset< int >( 0x0 );

            // col: 3 offset: 0004
            GatheringPointBonus = new ushort[2];
            GatheringPointBonus[0] = parser.ReadOffset< ushort >( 0x4 );
            GatheringPointBonus[1] = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            TerritoryType = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            PlaceName = parser.ReadOffset< ushort >( 0xa );

            // col: 7 offset: 000c
            GatheringSubCategory = parser.ReadOffset< ushort >( 0xc );

            // col: 0 offset: 000e
            Type = parser.ReadOffset< byte >( 0xe );

            // col: 2 offset: 000f
            Count = parser.ReadOffset< byte >( 0xf );


        }
    }
}