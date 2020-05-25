using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTask", columnHash: 0x99415e4e )]
    public class RetainerTask : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 07 offset: 0000
        public int Experience;

        // col: 03 offset: 0004
        public ushort unknown4;

        // col: 04 offset: 0006
        public ushort RetainerTaskParameter;

        // col: 05 offset: 0008
        public ushort VentureCost;

        // col: 06 offset: 000a
        public ushort MaxTimemin;

        // col: 08 offset: 000c
        public ushort RequiredItemLevel;

        // col: 11 offset: 000e
        public ushort RequiredGathering;

        // col: 12 offset: 0010
        public ushort unknown10;

        // col: 13 offset: 0012
        public ushort Task;

        // col: 01 offset: 0014
        public byte ClassJobCategory;

        // col: 02 offset: 0015
        public byte RetainerLevel;

        // col: 09 offset: 0016
        public byte unknown16;

        // col: 10 offset: 0017
        public byte unknown17;

        // col: 00 offset: 0018
        public bool IsRandom;
        public byte packed18;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            Experience = parser.ReadOffset< int >( 0x0 );

            // col: 3 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            RetainerTaskParameter = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            VentureCost = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            MaxTimemin = parser.ReadOffset< ushort >( 0xa );

            // col: 8 offset: 000c
            RequiredItemLevel = parser.ReadOffset< ushort >( 0xc );

            // col: 11 offset: 000e
            RequiredGathering = parser.ReadOffset< ushort >( 0xe );

            // col: 12 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 13 offset: 0012
            Task = parser.ReadOffset< ushort >( 0x12 );

            // col: 1 offset: 0014
            ClassJobCategory = parser.ReadOffset< byte >( 0x14 );

            // col: 2 offset: 0015
            RetainerLevel = parser.ReadOffset< byte >( 0x15 );

            // col: 9 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 10 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 0 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            IsRandom = ( packed18 & 0x1 ) == 0x1;


        }
    }
}