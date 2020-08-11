// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastTribe", columnHash: 0x336849f0 )]
    public class BeastTribe : IExcelRow
    {
        
        public bool Unknown0;
        public byte MinLevel;
        public LazyRow< BeastRankBonus > BeastRankBonus;
        public uint IconReputation;
        public uint Icon;
        public byte MaxRank;
        public LazyRow< ExVersion > Expansion;
        public LazyRow< Item > CurrencyItem;
        public byte DisplayOrder;
        public string Name;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Pronoun;
        public sbyte Article;
        public sbyte DEF;
        public string NameRelation;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< bool >( 0 );
            MinLevel = parser.ReadColumn< byte >( 1 );
            BeastRankBonus = new LazyRow< BeastRankBonus >( lumina, parser.ReadColumn< byte >( 2 ), language );
            IconReputation = parser.ReadColumn< uint >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
            MaxRank = parser.ReadColumn< byte >( 5 );
            Expansion = new LazyRow< ExVersion >( lumina, parser.ReadColumn< byte >( 6 ), language );
            CurrencyItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 7 ), language );
            DisplayOrder = parser.ReadColumn< byte >( 8 );
            Name = parser.ReadColumn< string >( 9 );
            Adjective = parser.ReadColumn< sbyte >( 10 );
            Plural = parser.ReadColumn< string >( 11 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 12 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 13 );
            Pronoun = parser.ReadColumn< sbyte >( 14 );
            Article = parser.ReadColumn< sbyte >( 15 );
            DEF = parser.ReadColumn< sbyte >( 16 );
            NameRelation = parser.ReadColumn< string >( 17 );
        }
    }
}