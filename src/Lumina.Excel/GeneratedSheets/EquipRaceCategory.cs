// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipRaceCategory", columnHash: 0xf914b198 )]
    public partial class EquipRaceCategory : ExcelRow
    {
        
        public bool Hyur { get; set; }
        public bool Elezen { get; set; }
        public bool Lalafell { get; set; }
        public bool Miqote { get; set; }
        public bool Roegadyn { get; set; }
        public bool AuRa { get; set; }
        public bool Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Hyur = parser.ReadColumn< bool >( 0 );
            Elezen = parser.ReadColumn< bool >( 1 );
            Lalafell = parser.ReadColumn< bool >( 2 );
            Miqote = parser.ReadColumn< bool >( 3 );
            Roegadyn = parser.ReadColumn< bool >( 4 );
            AuRa = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Male = parser.ReadColumn< bool >( 8 );
            Female = parser.ReadColumn< bool >( 9 );
        }
    }
}