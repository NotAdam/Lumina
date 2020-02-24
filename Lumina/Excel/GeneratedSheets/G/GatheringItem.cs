using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItem", columnHash: 0x032ca4ae )]
    public class GatheringItem : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT


        // col: 03 offset: 0000
        public uint IsHidden;

        // col: 00 offset: 0004
        public int Item;

        // col: 01 offset: 0008
        public ushort GatheringItemLevel;

        // col: 02 offset: 000a
        private byte packeda;
        public bool packeda_1 => ( packeda & 0x1 ) == 0x1;
        public bool packeda_2 => ( packeda & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            IsHidden = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Item = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            GatheringItemLevel = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa, ExcelColumnDataType.UInt8 );


        }
    }
}