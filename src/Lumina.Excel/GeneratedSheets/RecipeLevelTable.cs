// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLevelTable", columnHash: 0x6d3c3f32 )]
    public partial class RecipeLevelTable : ExcelRow
    {
        
        public byte ClassJobLevel { get; set; }
        public byte Stars { get; set; }
        public ushort SuggestedCraftsmanship { get; set; }
        public ushort SuggestedControl { get; set; }
        public ushort Difficulty { get; set; }
        public uint Quality { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Durability { get; set; }
        public byte ConditionsFlag { get; set; }
        public ushort Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJobLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
            SuggestedCraftsmanship = parser.ReadColumn< ushort >( 2 );
            SuggestedControl = parser.ReadColumn< ushort >( 3 );
            Difficulty = parser.ReadColumn< ushort >( 4 );
            Quality = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Durability = parser.ReadColumn< byte >( 8 );
            ConditionsFlag = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
        }
    }
}