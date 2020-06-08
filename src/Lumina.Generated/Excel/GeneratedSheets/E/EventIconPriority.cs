using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0x0bc77e1c )]
    public class EventIconPriority : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint[] Icon;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Icon = new uint[19];
            Icon[0] = parser.ReadOffset< uint >( 0x0 );
            Icon[1] = parser.ReadOffset< uint >( 0x4 );
            Icon[2] = parser.ReadOffset< uint >( 0x8 );
            Icon[3] = parser.ReadOffset< uint >( 0xc );
            Icon[4] = parser.ReadOffset< uint >( 0x10 );
            Icon[5] = parser.ReadOffset< uint >( 0x14 );
            Icon[6] = parser.ReadOffset< uint >( 0x18 );
            Icon[7] = parser.ReadOffset< uint >( 0x1c );
            Icon[8] = parser.ReadOffset< uint >( 0x20 );
            Icon[9] = parser.ReadOffset< uint >( 0x24 );
            Icon[10] = parser.ReadOffset< uint >( 0x28 );
            Icon[11] = parser.ReadOffset< uint >( 0x2c );
            Icon[12] = parser.ReadOffset< uint >( 0x30 );
            Icon[13] = parser.ReadOffset< uint >( 0x34 );
            Icon[14] = parser.ReadOffset< uint >( 0x38 );
            Icon[15] = parser.ReadOffset< uint >( 0x3c );
            Icon[16] = parser.ReadOffset< uint >( 0x40 );
            Icon[17] = parser.ReadOffset< uint >( 0x44 );
            Icon[18] = parser.ReadOffset< uint >( 0x48 );


        }
    }
}