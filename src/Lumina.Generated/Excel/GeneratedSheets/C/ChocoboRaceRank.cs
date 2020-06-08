using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
    public class ChocoboRaceRank : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public int Icon;

        // col: 00 offset: 0004
        public ushort RatingMin;

        // col: 01 offset: 0006
        public ushort RatingMax;

        // col: 02 offset: 0008
        public ushort Name;

        // col: 03 offset: 000a
        public ushort Fee;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            RatingMin = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            RatingMax = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            Name = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            Fee = parser.ReadOffset< ushort >( 0xa );


        }
    }
}