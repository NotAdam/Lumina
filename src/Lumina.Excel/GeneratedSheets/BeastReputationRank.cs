// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public class BeastReputationRank : IExcelRow
    {
        
        public ushort RequiredReputation;
        public string Name;
        public string AlliedNames;
        public LazyRow< UIColor > Color;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RequiredReputation = parser.ReadColumn< ushort >( 0 );
            Name = parser.ReadColumn< string >( 1 );
            AlliedNames = parser.ReadColumn< string >( 2 );
            Color = new LazyRow< UIColor >( lumina, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}