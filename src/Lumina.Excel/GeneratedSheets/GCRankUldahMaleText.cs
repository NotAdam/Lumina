// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCRankUldahMaleText", columnHash: 0xd573cba6 )]
    public partial class GCRankUldahMaleText : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public SeString NameRank { get; set; }
        public SeString Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            NameRank = parser.ReadColumn< SeString >( 8 );
            Unknown9 = parser.ReadColumn< SeString >( 9 );
        }
    }
}