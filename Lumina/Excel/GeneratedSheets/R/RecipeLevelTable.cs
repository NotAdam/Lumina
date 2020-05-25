using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLevelTable", columnHash: 0xf24f1bf5 )]
    public class RecipeLevelTable : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 05 offset: 0000
        public uint Quality;

        // col: 02 offset: 0004
        public ushort SuggestedCraftsmanship;

        // col: 03 offset: 0006
        public ushort SuggestedControl;

        // col: 04 offset: 0008
        public ushort Difficulty;

        // col: 06 offset: 000a
        public ushort Durability;

        // col: 00 offset: 000c
        public byte ClassJobLevel;

        // col: 01 offset: 000d
        public byte Stars;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            Quality = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            SuggestedCraftsmanship = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            SuggestedControl = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            Difficulty = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            Durability = parser.ReadOffset< ushort >( 0xa );

            // col: 0 offset: 000c
            ClassJobLevel = parser.ReadOffset< byte >( 0xc );

            // col: 1 offset: 000d
            Stars = parser.ReadOffset< byte >( 0xd );


        }
    }
}