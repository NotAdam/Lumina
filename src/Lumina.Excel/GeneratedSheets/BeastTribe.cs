// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastTribe", columnHash: 0x336849f0 )]
    public partial class BeastTribe : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public byte MinLevel { get; set; }
        public LazyRow< BeastRankBonus > BeastRankBonus { get; set; }
        public uint IconReputation { get; set; }
        public uint Icon { get; set; }
        public byte MaxRank { get; set; }
        public LazyRow< ExVersion > Expansion { get; set; }
        public LazyRow< Item > CurrencyItem { get; set; }
        public byte DisplayOrder { get; set; }
        public SeString Name { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public sbyte DEF { get; set; }
        public SeString NameRelation { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            MinLevel = parser.ReadColumn< byte >( 1 );
            BeastRankBonus = new LazyRow< BeastRankBonus >( gameData, parser.ReadColumn< byte >( 2 ), language );
            IconReputation = parser.ReadColumn< uint >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
            MaxRank = parser.ReadColumn< byte >( 5 );
            Expansion = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 6 ), language );
            CurrencyItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 7 ), language );
            DisplayOrder = parser.ReadColumn< byte >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Adjective = parser.ReadColumn< sbyte >( 10 );
            Plural = parser.ReadColumn< SeString >( 11 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 12 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 13 );
            Pronoun = parser.ReadColumn< sbyte >( 14 );
            Article = parser.ReadColumn< sbyte >( 15 );
            DEF = parser.ReadColumn< sbyte >( 16 );
            NameRelation = parser.ReadColumn< SeString >( 17 );
        }
    }
}