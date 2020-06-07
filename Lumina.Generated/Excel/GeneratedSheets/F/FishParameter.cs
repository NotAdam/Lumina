using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0x019385c9 )]
    public class FishParameter : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Text;

        // col: 01 offset: 0004
        public int Item;

        // col: 07 offset: 0008
        public int TerritoryType;

        // col: 02 offset: 000c
        public ushort GatheringItemLevel;

        // col: 08 offset: 000e
        public ushort GatheringSubCategory;

        // col: 03 offset: 0010
        public byte unknown10;

        // col: 06 offset: 0011
        public byte FishingRecordType;

        // col: 04 offset: 0012
        public bool IsHidden;
        public byte packed12;
        public bool packed12_2;
        public bool IsInLog;
        public bool TimeRestricted;
        public bool WeatherRestricted;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Item = parser.ReadOffset< int >( 0x4 );

            // col: 7 offset: 0008
            TerritoryType = parser.ReadOffset< int >( 0x8 );

            // col: 2 offset: 000c
            GatheringItemLevel = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            GatheringSubCategory = parser.ReadOffset< ushort >( 0xe );

            // col: 3 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 6 offset: 0011
            FishingRecordType = parser.ReadOffset< byte >( 0x11 );

            // col: 4 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            IsHidden = ( packed12 & 0x1 ) == 0x1;
            packed12_2 = ( packed12 & 0x2 ) == 0x2;
            IsInLog = ( packed12 & 0x4 ) == 0x4;
            TimeRestricted = ( packed12 & 0x8 ) == 0x8;
            WeatherRestricted = ( packed12 & 0x10 ) == 0x10;


        }
    }
}