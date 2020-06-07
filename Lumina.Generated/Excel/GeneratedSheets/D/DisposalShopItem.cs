using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShopItem", columnHash: 0x1990ed53 )]
    public class DisposalShopItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public uint QuantityReceived;

        // col: 00 offset: 0004
        public int ItemDisposed;

        // col: 02 offset: 0008
        public int ItemReceived;

        // col: 05 offset: 000c
        public ushort unknownc;

        // col: 01 offset: 000e
        public bool packede_1;
        public byte packede;
        public bool packede_2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            QuantityReceived = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            ItemDisposed = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            ItemReceived = parser.ReadOffset< int >( 0x8 );

            // col: 5 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 1 offset: 000e
            packede = parser.ReadOffset< byte >( 0xe, ExcelColumnDataType.UInt8 );

            packede_1 = ( packede & 0x1 ) == 0x1;
            packede_2 = ( packede & 0x2 ) == 0x2;


        }
    }
}