using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBase", columnHash: 0x73fa0924 )]
    public class GatheringPointBase : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int GatheringType;

        // col: 02 offset: 0004
        public int[] Item;

        // col: 01 offset: 0024
        public byte GatheringLevel;

        // col: 10 offset: 0025
        public bool IsLimited;
        public byte packed25;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            GatheringType = parser.ReadOffset< int >( 0x0 );

            // col: 2 offset: 0004
            Item = new int[8];
            Item[0] = parser.ReadOffset< int >( 0x4 );
            Item[1] = parser.ReadOffset< int >( 0x8 );
            Item[2] = parser.ReadOffset< int >( 0xc );
            Item[3] = parser.ReadOffset< int >( 0x10 );
            Item[4] = parser.ReadOffset< int >( 0x14 );
            Item[5] = parser.ReadOffset< int >( 0x18 );
            Item[6] = parser.ReadOffset< int >( 0x1c );
            Item[7] = parser.ReadOffset< int >( 0x20 );

            // col: 1 offset: 0024
            GatheringLevel = parser.ReadOffset< byte >( 0x24 );

            // col: 10 offset: 0025
            packed25 = parser.ReadOffset< byte >( 0x25, ExcelColumnDataType.UInt8 );

            IsLimited = ( packed25 & 0x1 ) == 0x1;


        }
    }
}