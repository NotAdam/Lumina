// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMagicStone", columnHash: 0xc638f2bf )]
    public partial class DeepDungeonMagicStone : ExcelRow
    {
        
        public uint Icon { get; set; }
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown6 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public SeString Name { get; set; }
        public SeString Tooltip { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Singular = parser.ReadColumn< SeString >( 1 );
            Adjective = parser.ReadColumn< sbyte >( 2 );
            Plural = parser.ReadColumn< SeString >( 3 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 4 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Pronoun = parser.ReadColumn< sbyte >( 7 );
            Article = parser.ReadColumn< sbyte >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Tooltip = parser.ReadColumn< SeString >( 10 );
        }
    }
}