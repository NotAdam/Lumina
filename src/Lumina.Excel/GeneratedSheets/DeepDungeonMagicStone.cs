// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMagicStone", columnHash: 0xc638f2bf )]
    public class DeepDungeonMagicStone : ExcelRow
    {
        
        public uint Icon;
        public SeString Singular;
        public sbyte Adjective;
        public SeString Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown6;
        public sbyte Pronoun;
        public sbyte Article;
        public SeString Name;
        public SeString Tooltip;
        

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