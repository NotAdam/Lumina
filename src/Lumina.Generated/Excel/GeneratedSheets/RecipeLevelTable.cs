using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLevelTable", columnHash: 0xf24f1bf5 )]
    public class RecipeLevelTable : IExcelRow
    {
        
        public byte ClassJobLevel;
        public byte Stars;
        public ushort SuggestedCraftsmanship;
        public ushort SuggestedControl;
        public ushort Difficulty;
        public uint Quality;
        public ushort Durability;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJobLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
            SuggestedCraftsmanship = parser.ReadColumn< ushort >( 2 );
            SuggestedControl = parser.ReadColumn< ushort >( 3 );
            Difficulty = parser.ReadColumn< ushort >( 4 );
            Quality = parser.ReadColumn< uint >( 5 );
            Durability = parser.ReadColumn< ushort >( 6 );
        }
    }
}