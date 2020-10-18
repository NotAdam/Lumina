// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public class BeastReputationRank : IExcelRow
    {
        
        public ushort RequiredReputation;
        public SeString Name;
        public SeString AlliedNames;
        public LazyRow< UIColor > Color;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RequiredReputation = parser.ReadColumn< ushort >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            AlliedNames = parser.ReadColumn< SeString >( 2 );
            Color = new LazyRow< UIColor >( lumina, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}