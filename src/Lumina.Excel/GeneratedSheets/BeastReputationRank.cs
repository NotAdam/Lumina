// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public class BeastReputationRank : ExcelRow
    {
        
        public ushort RequiredReputation;
        public SeString Name;
        public SeString AlliedNames;
        public LazyRow< UIColor > Color;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            RequiredReputation = parser.ReadColumn< ushort >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            AlliedNames = parser.ReadColumn< SeString >( 2 );
            Color = new LazyRow< UIColor >( lumina, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}