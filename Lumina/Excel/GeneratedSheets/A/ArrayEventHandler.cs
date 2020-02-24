using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ArrayEventHandler", columnHash: 0xb404681e )]
    public class ArrayEventHandler : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint[] Data;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Data = new uint[16];
            Data[0] = parser.ReadOffset< uint >( 0x0 );
            Data[1] = parser.ReadOffset< uint >( 0x4 );
            Data[2] = parser.ReadOffset< uint >( 0x8 );
            Data[3] = parser.ReadOffset< uint >( 0xc );
            Data[4] = parser.ReadOffset< uint >( 0x10 );
            Data[5] = parser.ReadOffset< uint >( 0x14 );
            Data[6] = parser.ReadOffset< uint >( 0x18 );
            Data[7] = parser.ReadOffset< uint >( 0x1c );
            Data[8] = parser.ReadOffset< uint >( 0x20 );
            Data[9] = parser.ReadOffset< uint >( 0x24 );
            Data[10] = parser.ReadOffset< uint >( 0x28 );
            Data[11] = parser.ReadOffset< uint >( 0x2c );
            Data[12] = parser.ReadOffset< uint >( 0x30 );
            Data[13] = parser.ReadOffset< uint >( 0x34 );
            Data[14] = parser.ReadOffset< uint >( 0x38 );
            Data[15] = parser.ReadOffset< uint >( 0x3c );


        }
    }
}