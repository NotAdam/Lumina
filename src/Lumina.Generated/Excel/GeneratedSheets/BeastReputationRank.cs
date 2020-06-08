using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public class BeastReputationRank : IExcelRow
    {
        
        public ushort RequiredReputation;
        public string Name;
        public string Unknown2;
        public uint Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RequiredReputation = parser.ReadColumn< ushort >( 0 );
            Name = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< string >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
        }
    }
}