// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GrandCompanyRank", columnHash: 0x939f7424 )]
    public partial class GrandCompanyRank : ExcelRow
    {
        
        public byte Tier { get; set; }
        public byte Order { get; set; }
        public uint MaxSeals { get; set; }
        public uint RequiredSeals { get; set; }
        public int IconMaelstrom { get; set; }
        public int IconSerpents { get; set; }
        public int IconFlames { get; set; }
        public LazyRow< Quest > QuestMaelstrom { get; set; }
        public LazyRow< Quest > QuestSerpents { get; set; }
        public LazyRow< Quest > QuestFlames { get; set; }
        public byte Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Tier = parser.ReadColumn< byte >( 0 );
            Order = parser.ReadColumn< byte >( 1 );
            MaxSeals = parser.ReadColumn< uint >( 2 );
            RequiredSeals = parser.ReadColumn< uint >( 3 );
            IconMaelstrom = parser.ReadColumn< int >( 4 );
            IconSerpents = parser.ReadColumn< int >( 5 );
            IconFlames = parser.ReadColumn< int >( 6 );
            QuestMaelstrom = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 7 ), language );
            QuestSerpents = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 8 ), language );
            QuestFlames = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}