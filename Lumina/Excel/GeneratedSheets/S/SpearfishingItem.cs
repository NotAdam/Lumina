using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingItem", columnHash: 0xd17632b4 )]
    public class SpearfishingItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Description;

        // col: 01 offset: 0004
        public int Item;

        // col: 02 offset: 0008
        public ushort GatheringItemLevel;

        // col: 04 offset: 000a
        public ushort TerritoryType;

        // col: 03 offset: 000c
        public byte FishingRecordType;

        // col: 05 offset: 000d
        public bool IsVisible;
        public byte packedd;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Description = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Item = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            GatheringItemLevel = parser.ReadOffset< ushort >( 0x8 );

            // col: 4 offset: 000a
            TerritoryType = parser.ReadOffset< ushort >( 0xa );

            // col: 3 offset: 000c
            FishingRecordType = parser.ReadOffset< byte >( 0xc );

            // col: 5 offset: 000d
            packedd = parser.ReadOffset< byte >( 0xd, ExcelColumnDataType.UInt8 );

            IsVisible = ( packedd & 0x1 ) == 0x1;


        }
    }
}