using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCRank", columnHash: 0x0105b558 )]
    public class FCRank : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint NextPoint;

        // col: 01 offset: 0004
        public uint CurrentPoint;

        // col: 02 offset: 0008
        public ushort Rights;

        // col: 03 offset: 000a
        public ushort unknowna;

        // col: 04 offset: 000c
        public ushort unknownc;

        // col: 05 offset: 000e
        public byte FCActionActiveNum;

        // col: 06 offset: 000f
        public byte FCActionStockNum;

        // col: 07 offset: 0010
        public byte unknown10;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NextPoint = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            CurrentPoint = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Rights = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 5 offset: 000e
            FCActionActiveNum = parser.ReadOffset< byte >( 0xe );

            // col: 6 offset: 000f
            FCActionStockNum = parser.ReadOffset< byte >( 0xf );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );


        }
    }
}