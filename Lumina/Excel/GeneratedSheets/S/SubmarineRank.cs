using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineRank", columnHash: 0x697b9c75 )]
    public class SubmarineRank : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public uint ExpToNext;

        // col: 00 offset: 0004
        public ushort Rank;

        // col: 02 offset: 0006
        public byte unknown6;

        // col: 03 offset: 0007
        public byte unknown7;

        // col: 04 offset: 0008
        public byte unknown8;

        // col: 05 offset: 0009
        public byte unknown9;

        // col: 06 offset: 000a
        public byte unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ExpToNext = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Rank = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 3 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 4 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 5 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 6 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}