using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
    public class GatheringRarePopTimeTable : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort[] unknown0;

        // col: 04 offset: 0004
        public ushort unknown4;

        // col: 03 offset: 0008
        public ushort unknown8;

        // col: 05 offset: 000a
        public ushort unknowna;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = new ushort[3];
            unknown0[0] = parser.ReadOffset< ushort >( 0x0 );
            unknown0[1] = parser.ReadOffset< ushort >( 0x6 );
            unknown0[2] = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );


        }
    }
}