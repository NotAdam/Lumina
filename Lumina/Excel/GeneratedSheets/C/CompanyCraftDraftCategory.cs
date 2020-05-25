using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public class CompanyCraftDraftCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public ushort[] unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = new ushort[10];
            unknown4[0] = parser.ReadOffset< ushort >( 0x4 );
            unknown4[1] = parser.ReadOffset< ushort >( 0x6 );
            unknown4[2] = parser.ReadOffset< ushort >( 0x8 );
            unknown4[3] = parser.ReadOffset< ushort >( 0xa );
            unknown4[4] = parser.ReadOffset< ushort >( 0xc );
            unknown4[5] = parser.ReadOffset< ushort >( 0xe );
            unknown4[6] = parser.ReadOffset< ushort >( 0x10 );
            unknown4[7] = parser.ReadOffset< ushort >( 0x12 );
            unknown4[8] = parser.ReadOffset< ushort >( 0x14 );
            unknown4[9] = parser.ReadOffset< ushort >( 0x16 );


        }
    }
}