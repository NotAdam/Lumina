using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZReport", columnHash: 0x1a97b0af )]
    public class AOZReport : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint unknown0;

        // col: 01 offset: 0004
        public byte Reward;

        // col: 02 offset: 0005
        public sbyte Order;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Reward = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            Order = parser.ReadOffset< sbyte >( 0x5 );


        }
    }
}