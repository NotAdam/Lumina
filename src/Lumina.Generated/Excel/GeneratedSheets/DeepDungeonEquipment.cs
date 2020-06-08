using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonEquipment", columnHash: 0xc638f2bf )]
    public class DeepDungeonEquipment : IExcelRow
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
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
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
            Description = parser.ReadColumn< string >( 10 );
        }
    }
}