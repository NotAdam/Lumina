using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingFurniture", columnHash: 0xccfbe5ff )]
    public class HousingFurniture : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public uint UsageParameter;

        // col: 06 offset: 0004
        public uint CustomTalk;

        // col: 07 offset: 0008
        public uint Item;

        // col: 00 offset: 000c
        public ushort ModelKey;

        // col: 01 offset: 000e
        public byte HousingItemCategory;

        // col: 02 offset: 000f
        public byte UsageType;

        // col: 04 offset: 0010
        public byte unknown10;

        // col: 05 offset: 0011
        public byte AquariumTier;

        // col: 10 offset: 0012
        public byte unknown12;

        // col: 11 offset: 0013
        public byte unknown13;

        // col: 12 offset: 0014
        public byte unknown14;

        // col: 08 offset: 0015
        public bool DestroyOnRemoval;
        public byte packed15;
        public bool Tooltip;
        public bool packed15_4;
        public bool packed15_8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            UsageParameter = parser.ReadOffset< uint >( 0x0 );

            // col: 6 offset: 0004
            CustomTalk = parser.ReadOffset< uint >( 0x4 );

            // col: 7 offset: 0008
            Item = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            ModelKey = parser.ReadOffset< ushort >( 0xc );

            // col: 1 offset: 000e
            HousingItemCategory = parser.ReadOffset< byte >( 0xe );

            // col: 2 offset: 000f
            UsageType = parser.ReadOffset< byte >( 0xf );

            // col: 4 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 5 offset: 0011
            AquariumTier = parser.ReadOffset< byte >( 0x11 );

            // col: 10 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );

            // col: 11 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 12 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 8 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15, ExcelColumnDataType.UInt8 );

            DestroyOnRemoval = ( packed15 & 0x1 ) == 0x1;
            Tooltip = ( packed15 & 0x2 ) == 0x2;
            packed15_4 = ( packed15 & 0x4 ) == 0x4;
            packed15_8 = ( packed15 & 0x8 ) == 0x8;


        }
    }
}