// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyEquip", columnHash: 0xb429792a )]
    public class BuddyEquip : ExcelRow
    {
        
        public SeString Singular;
        public sbyte Adjective;
        public SeString Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public SeString Name;
        public int ModelTop;
        public int ModelBody;
        public int ModelLegs;
        public LazyRow< GrandCompany > GrandCompany;
        public ushort IconHead;
        public ushort IconBody;
        public ushort IconLegs;
        public byte Order;
        

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
            Name = parser.ReadColumn< SeString >( 8 );
            ModelTop = parser.ReadColumn< int >( 9 );
            ModelBody = parser.ReadColumn< int >( 10 );
            ModelLegs = parser.ReadColumn< int >( 11 );
            GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadColumn< byte >( 12 ), language );
            IconHead = parser.ReadColumn< ushort >( 13 );
            IconBody = parser.ReadColumn< ushort >( 14 );
            IconLegs = parser.ReadColumn< ushort >( 15 );
            Order = parser.ReadColumn< byte >( 16 );
        }
    }
}