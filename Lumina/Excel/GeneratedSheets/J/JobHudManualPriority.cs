using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManualPriority", columnHash: 0x5be005ad )]
    public class JobHudManualPriority : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 00 offset: 0000
        public byte[] JobHudManual;

        // col: 03 offset: 0003
        public byte unknown3;

        // col: 04 offset: 0004
        public byte unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            JobHudManual = new byte[3];
            JobHudManual[0] = parser.ReadOffset< byte >( 0x0 );
            JobHudManual[1] = parser.ReadOffset< byte >( 0x1 );
            JobHudManual[2] = parser.ReadOffset< byte >( 0x2 );

            // col: 3 offset: 0003
            unknown3 = parser.ReadOffset< byte >( 0x3 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}