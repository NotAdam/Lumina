// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GrandCompanyRank", columnHash: 0x939f7424 )]
    public class GrandCompanyRank : ExcelRow
    {
        
        public byte Tier;
        public byte Order;
        public uint MaxSeals;
        public uint RequiredSeals;
        public int IconMaelstrom;
        public int IconSerpents;
        public int IconFlames;
        public LazyRow< Quest > QuestMaelstrom;
        public LazyRow< Quest > QuestSerpents;
        public LazyRow< Quest > QuestFlames;
        public byte Unknown10;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Tier = parser.ReadColumn< byte >( 0 );
            Order = parser.ReadColumn< byte >( 1 );
            MaxSeals = parser.ReadColumn< uint >( 2 );
            RequiredSeals = parser.ReadColumn< uint >( 3 );
            IconMaelstrom = parser.ReadColumn< int >( 4 );
            IconSerpents = parser.ReadColumn< int >( 5 );
            IconFlames = parser.ReadColumn< int >( 6 );
            QuestMaelstrom = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 7 ), language );
            QuestSerpents = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 8 ), language );
            QuestFlames = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}