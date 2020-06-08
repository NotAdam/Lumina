using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrderGuide", columnHash: 0xa76e50e1 )]
    public class GuildOrderGuide : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint unknown0;

        // col: 01 offset: 0004
        public uint unknown4;

        // col: 02 offset: 0008
        public uint unknown8;

        // col: 03 offset: 000c
        public uint unknownc;

        // col: 04 offset: 0010
        public uint unknown10;

        // col: 05 offset: 0014
        public uint unknown14;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );


        }
    }
}