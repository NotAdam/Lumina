using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPAction", columnHash: 0x3818ca1d )]
    public class PvPAction : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public ushort Action;

        // col: 02 offset: 0002
        public ushort unknown2;

        // col: 03 offset: 0004
        public ushort unknown4;

        // col: 04 offset: 0006
        public ushort unknown6;

        // col: 01 offset: 0008
        public byte unknown8;

        // col: 08 offset: 0009
        public byte unknown9;

        // col: 05 offset: 000a
        public bool[] GrandCompany;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Action = parser.ReadOffset< ushort >( 0x0 );

            // col: 2 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 3 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 1 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 8 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 5 offset: 000a
            GrandCompany = new bool[3];
            GrandCompany[0] = parser.ReadOffset< bool >( 0xa );
            GrandCompany[1] = parser.ReadOffset< bool >( 0xb );
            GrandCompany[2] = parser.ReadOffset< bool >( 0xc );


        }
    }
}