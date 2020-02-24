using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadRule", columnHash: 0x48d210b8 )]
    public class TripleTriadRule : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string unknown4;

        // col: 05 offset: 0008
        public int unknown8;

        // col: 02 offset: 000c
        public byte unknownc;

        // col: 03 offset: 000d
        public byte unknownd;

        // col: 04 offset: 000e
        public byte unknowne;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< int >( 0x8 );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 3 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 4 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );


        }
    }
}