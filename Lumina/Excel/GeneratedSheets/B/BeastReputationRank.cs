using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastReputationRank", columnHash: 0x446d8bad )]
    public class BeastReputationRank : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string unknown4;

        // col: 03 offset: 0008
        public uint unknown8;

        // col: 00 offset: 000c
        public ushort RequiredReputation;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            RequiredReputation = parser.ReadOffset< ushort >( 0xc );


        }
    }
}