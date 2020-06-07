using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingNotebook", columnHash: 0x0f196a4a )]
    public class SpearfishingNotebook : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public int TerritoryType;

        // col: 05 offset: 0004
        public ushort Radius;

        // col: 07 offset: 0006
        public ushort PlaceName;

        // col: 09 offset: 0008
        public ushort GatheringPointBase;

        // col: 10 offset: 000a
        public ushort unknowna;

        // col: 11 offset: 000c
        public ushort unknownc;

        // col: 03 offset: 000e
        public short X;

        // col: 04 offset: 0010
        public short Y;

        // col: 00 offset: 0012
        public byte GatheringLevel;

        // col: 06 offset: 0013
        public byte unknown13;

        // col: 08 offset: 0014
        public byte unknown14;

        // col: 01 offset: 0015
        public bool packed15_1;
        public byte packed15;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            TerritoryType = parser.ReadOffset< int >( 0x0 );

            // col: 5 offset: 0004
            Radius = parser.ReadOffset< ushort >( 0x4 );

            // col: 7 offset: 0006
            PlaceName = parser.ReadOffset< ushort >( 0x6 );

            // col: 9 offset: 0008
            GatheringPointBase = parser.ReadOffset< ushort >( 0x8 );

            // col: 10 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 11 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 3 offset: 000e
            X = parser.ReadOffset< short >( 0xe );

            // col: 4 offset: 0010
            Y = parser.ReadOffset< short >( 0x10 );

            // col: 0 offset: 0012
            GatheringLevel = parser.ReadOffset< byte >( 0x12 );

            // col: 6 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 8 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 1 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15, ExcelColumnDataType.UInt8 );

            packed15_1 = ( packed15 & 0x1 ) == 0x1;


        }
    }
}