using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonItem", columnHash: 0x878768c6 )]
    public class DeepDungeonItem : IExcelRow
    {
        
        public uint Icon;
        public string Singular;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown6;
        public sbyte Pronoun;
        public sbyte Article;
        public string Name;
        public string Tooltip;
        public LazyRow< Action > Action;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< uint >( 0 );
            Singular = parser.ReadColumn< string >( 1 );
            Adjective = parser.ReadColumn< sbyte >( 2 );
            Plural = parser.ReadColumn< string >( 3 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 4 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Pronoun = parser.ReadColumn< sbyte >( 7 );
            Article = parser.ReadColumn< sbyte >( 8 );
            Name = parser.ReadColumn< string >( 9 );
            Tooltip = parser.ReadColumn< string >( 10 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 11 ), language );
        }
    }
}