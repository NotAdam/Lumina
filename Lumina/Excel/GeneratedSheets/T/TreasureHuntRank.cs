using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureHuntRank", columnHash: 0x3997d502 )]
    public class TreasureHuntRank : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public uint Icon;

        // col: 02 offset: 0004
        public int ItemName;

        // col: 03 offset: 0008
        public int KeyItemName;

        // col: 04 offset: 000c
        public int InstanceMap;

        // col: 07 offset: 0010
        public ushort unknown10;

        // col: 00 offset: 0012
        public byte unknown12;

        // col: 05 offset: 0013
        public byte MaxPartySize;

        // col: 06 offset: 0014
        public byte MinPartySize;

        // col: 08 offset: 0015
        private byte packed15;
        public bool packed15_1 => ( packed15 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Icon = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            ItemName = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            KeyItemName = parser.ReadOffset< int >( 0x8 );

            // col: 4 offset: 000c
            InstanceMap = parser.ReadOffset< int >( 0xc );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 0 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );

            // col: 5 offset: 0013
            MaxPartySize = parser.ReadOffset< byte >( 0x13 );

            // col: 6 offset: 0014
            MinPartySize = parser.ReadOffset< byte >( 0x14 );

            // col: 8 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15, ExcelColumnDataType.UInt8 );


        }
    }
}