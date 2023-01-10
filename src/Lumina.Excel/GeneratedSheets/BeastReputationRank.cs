// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public partial class BeastReputationRank : ExcelRow
    {
        
        public ushort RequiredReputation { get; set; }
        public SeString Name { get; set; }
        public SeString AlliedNames { get; set; }
        public LazyRow< UIColor > Color { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RequiredReputation = parser.ReadColumn< ushort >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            AlliedNames = parser.ReadColumn< SeString >( 2 );
            Color = new LazyRow< UIColor >( gameData, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}