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
        public sbyte Unknown10;
        public string Unknown11;
        public sbyte Unknown12;
        public sbyte Unknown13;
        public sbyte Unknown14;
        public sbyte Unknown15;
        public sbyte Unknown16;
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
            Unknown10 = parser.ReadColumn< sbyte >( 10 );
            Unknown11 = parser.ReadColumn< string >( 11 );
            Unknown12 = parser.ReadColumn< sbyte >( 12 );
            Unknown13 = parser.ReadColumn< sbyte >( 13 );
            Unknown14 = parser.ReadColumn< sbyte >( 14 );
            Unknown15 = parser.ReadColumn< sbyte >( 15 );
            Unknown16 = parser.ReadColumn< sbyte >( 16 );
            NameRelation = parser.ReadColumn< string >( 17 );
        }
    }
}